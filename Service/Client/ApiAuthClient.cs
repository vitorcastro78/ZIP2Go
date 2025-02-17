using EasyCaching.Core;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;
using Service.Client;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using ZIP2GO.Service.Models;

namespace ZIP2GO.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiAuthClient
    {
        private readonly IEasyCachingProvider _cache;
        private readonly Dictionary<string, string> _defaultHeaderMap = new Dictionary<string, string>();
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger _logger;
        private readonly IMemoryCache _memCache;
        private bool? _async;
        private HttpClient _client;
        private HttpClient _clientWithoutVersion;
        private string _acceptEncoding;
        private string _contentEncoding;
        private string _idempotencyKey;
        private string _zuoraDefaultVersion;
        private string _zuoraEntityIds;
        private string _zuoraTrackId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAuthClient" /> class.
        /// </summary>
        /// <param name="cache">The cache provider.</param>
        /// <param name="zuoraOptionsAccessor">The Zuora options accessor.</param>
        /// <param name="basePath">The base path.</param>
        public ApiAuthClient(IEasyCachingProvider cache, IOptionsMonitor<ZuoraOptions> zuoraOptionsAccessor, string basePath = "https://rest.sandbox.na.zuora.com/v2")
        {
            Options = zuoraOptionsAccessor.CurrentValue;
            BasePath = basePath;
            RestClient = new RestClient(BasePath);
            _cache = cache;
            SetDefaultZuoraVersion();
        }

        /// <summary>
        /// Gets or sets the base path.
        /// </summary>
        public string BasePath { get; set; }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        public Dictionary<string, string> DefaultHeader => _defaultHeaderMap;

        public virtual ZuoraOptions Options { get; private set; }

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        public RestClient RestClient { get; set; }

        /// <summary>
        /// Gets or sets the Zuora Entity Ids.
        /// </summary>
        protected virtual HttpClient OAuthClient
        {
            get
            {
                _client = GetOAuthHttpClient();
                SetZuoraEntityRequestHeader(_client);
                return _client;
            }
        }

        /// <summary>
        /// Gets or sets the Zuora Entity Ids.
        /// </summary>
        protected virtual HttpClient OAuthClientWithoutVersion
        {
            get
            {
                _clientWithoutVersion = GetOAuthHttpClientWithoutVersion();
                SetZuoraEntityRequestHeader(_clientWithoutVersion);
                return _clientWithoutVersion;
            }
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            var textByte = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textByte);
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// </summary>
        /// <param name="fromObject">Object to be casted.</param>
        /// <param name="toObject">Target type.</param>
        /// <returns>Casted object.</returns>
        public static object ConvertType(object fromObject, Type toObject)
        {
            return Convert.ChangeType(fromObject, toObject);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        public void AddDefaultHeader(string key, string value)
        {
            _defaultHeaderMap.Add(key, value);
        }

        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="authSettings">Authentication settings.</param>
        /// <returns>Object</returns>
        public object CallApi(string path, Method method, Dictionary<string, string> queryParams, string postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, string[] authSettings)
        {
            var request = new RestRequest(path, method);
            UpdateParamsForAuth(queryParams, headerParams, authSettings);
            AddHeadersToRequest(request, _defaultHeaderMap);
            AddHeadersToRequest(request, headerParams);
            AddParametersToRequest(request, queryParams, ParameterType.GetOrPost);
            AddParametersToRequest(request, formParams, ParameterType.GetOrPost);

            if (postBody != null)
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);

            return Deserialize(RestClient.Execute(request).Content, typeof(object));
        }

        public T CallApi<T>(string id, string path, Method method, Dictionary<string, string> queryParams = null, string postBody = null,
            Dictionary<string, string> headerParams = null, Dictionary<string, string> formParams = null,
            Dictionary<string, FileParameter> fileParams = null, string[] authSettings = null)
        {
            AddDefaultHeaders(headerParams);

            var request = new RestRequest(path, method);
            UpdateParamsForAuth(queryParams, headerParams, authSettings);

            AddHeadersToRequest(request, _defaultHeaderMap);
            AddHeadersToRequest(request, headerParams);
            AddParametersToRequest(request, queryParams, ParameterType.GetOrPost);
            AddParametersToRequest(request, formParams, ParameterType.GetOrPost);

            if (postBody != null)
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);

            var cachingTrigger = new CachingTrigger(_cache);

            if (method != Method.Get)
            {
                var response = RestClient.Execute(request);
                cachingTrigger.SetCachingTrigger<T>(method, response);
                var result = (T)Deserialize(response.Content, typeof(T));
                
                return result;
            }
            else
            {
                return cachingTrigger.GetCachingTrigger<T>(id);
            }
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="content">HTTP body (e.g. string, JSON).</param>
        /// <param name="type">Object type.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(string content, Type type, IList<Parameter> headers = null)
        {
            if (type == typeof(object))
                return content;

            if (type == typeof(Stream))
                return CreateFileStream(content, headers);

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime"))
                return DateTime.Parse(content, null, System.Globalization.DateTimeStyles.RoundtripKind);

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable"))
                return ConvertType(content, type);

            return JsonConvert.DeserializeObject(content, type);
        }

        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str)
        {
            return HttpUtility.UrlEncode(str);
        }

        /// <summary>
        /// Get the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string apiKeyIdentifier)
        {
            Configuration.ApiKey.TryGetValue(apiKeyIdentifier, out var apiKeyValue);
            Configuration.ApiKeyPrefix.TryGetValue(apiKeyIdentifier, out var apiKeyPrefix);
            return string.IsNullOrEmpty(apiKeyPrefix) ? apiKeyValue : $"{apiKeyPrefix} {apiKeyValue}";
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list of string, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            return obj switch
            {
                DateTime dateTime => dateTime.ToString(Configuration.DateTimeFormat),
                List<string> list => string.Join(",", list),
                _ => Convert.ToString(obj)
            };
        }

        /// <summary>
        /// Serialize an object into JSON string.
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public string Serialize(object obj)
        {
            return obj != null ? JsonConvert.SerializeObject(obj) : null;
        }

        /// <summary>
        /// Update parameters based on authentication.
        /// </summary>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="authSettings">Authentication settings.</param>
        public void UpdateParamsForAuth(Dictionary<string, string> queryParams, Dictionary<string, string> headerParams, string[] authSettings)
        {
            if (authSettings == null || authSettings.Length == 0)
                return;

            foreach (var auth in authSettings)
            {
                switch (auth)
                {
                    case "bearerAuth":
                        // Add bearer token logic here
                        break;
                    default:
                        // Show warning about security definition not found
                        break;
                }
            }
        }

        protected HttpContent SetZuoraVersionRequestHeader(string endpoint, HttpContent httpContent)
        {
            if (Options.EndpointSpecificVersions.TryGetValue(endpoint, out var version) ||
                Options.EndpointSpecificVersions.TryGetValue(RemoveSpecialChars(endpoint), out version) ||
                !string.IsNullOrWhiteSpace(_zuoraDefaultVersion) && !_zuoraDefaultVersion.Equals("latest"))
            {
                httpContent.Headers.Remove("zuora-version");
                httpContent.Headers.Add("zuora-version", version ?? _zuoraDefaultVersion);
            }

            _logger.LogDebug("Setting Zuora Version to: " + (httpContent.Headers.TryGetValues("zuora-version", out var values) ? values.First() : _zuoraDefaultVersion));
            return httpContent;
        }

        protected HttpRequestMessage SetZuoraVersionRequestHeader(string endpoint, HttpRequestMessage httpRequest)
        {
            if (Options.EndpointSpecificVersions.TryGetValue(endpoint, out var version) ||
                Options.EndpointSpecificVersions.TryGetValue(RemoveSpecialChars(endpoint), out version) ||
                !string.IsNullOrWhiteSpace(_zuoraDefaultVersion) && !_zuoraDefaultVersion.Equals("latest"))
            {
                httpRequest.Headers.Remove("zuora-version");
                httpRequest.Headers.Add("zuora-version", version ?? _zuoraDefaultVersion);
            }

            _logger.LogDebug("Setting Zuora Version to: " + (httpRequest.Headers.TryGetValues("zuora-version", out var values) ? values.First() : _zuoraDefaultVersion));
            return httpRequest;
        }

        private HttpClient GetOAuthHttpClient()
        {
            var httpClient = _httpClientFactory.CreateClient("zuora");
            httpClient.DefaultRequestHeaders.Remove("apiAccessKeyId");
            httpClient.DefaultRequestHeaders.Remove("apiSecretAccessKey");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GetToken());
            return httpClient;
        }

        private HttpClient GetOAuthHttpClientWithoutVersion()
        {
            var httpClient = _httpClientFactory.CreateClient("zuora");
            httpClient.DefaultRequestHeaders.Remove("zuora-version");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GetToken());
            return httpClient;
        }

        private string GetToken()
        {
            if (_memCache.TryGetValue("ZuoraToken", out ZuoraToken token) && DateTime.UtcNow < token.ExpiresAt?.AddSeconds(-60))
            {
                _logger.LogDebug($"Token expires in more than 60 seconds at {token.ExpiresAt}. Re-using token.");
                return token.Access_token;
            }

            _logger.LogDebug($"Token expires in less than 60 seconds at {token?.ExpiresAt}. Re-generating token.");
            var parameter = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{Options.UserId}:{Options.Password}"));
            var nameValueCollection = new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" },
                    { "client_id", Options.ClientID },
                    { "client_secret", Options.ClientSecret }
                };

            var httpClient = _httpClientFactory.CreateClient("zuora");
            httpClient.BaseAddress = new Uri(Options.BaseUrl);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", parameter);

            var result = httpClient.PostAsync($"{Options.BaseUrl}oauth/token", new FormUrlEncodedContent(nameValueCollection)).Result;
            if (!result.IsSuccessStatusCode)
            {
                var errorMessage = result.Content.ReadAsStringAsync().Result;
                if (result.Headers.TryGetValues("zuora-request-id", out var values))
                {
                    errorMessage += $" Zuora-Request-Id: {string.Join(',', values)}";
                }

                throw new InvalidOperationException($"Get Zuora token failed. Details: {errorMessage}");
            }

            token = JsonConvert.DeserializeObject<ZuoraToken>(result.Content.ReadAsStringAsync().Result);
            token.ExpiresAt = DateTime.UtcNow.AddSeconds(token.Expires_in <= 0 ? 900 : token.Expires_in);
            _memCache.Set("ZuoraToken", token, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(token.Expires_in <= 0 ? 900 : token.Expires_in)
            });

            return token.Access_token;
        }

        private string RemoveSpecialChars(string input)
        {
            return Regex.Replace(input, "[^0-9a-zA-Z\\._]", string.Empty);
        }

        private void SetDefaultZuoraVersion()
        {
            if (!string.IsNullOrWhiteSpace(Options.ClientDefaultZuoraVersion))
            {
                _zuoraDefaultVersion = Options.ClientDefaultZuoraVersion;
            }
        }

        private void SetZuoraEntityRequestHeader(HttpClient httpClient)
        {
            if (!string.IsNullOrWhiteSpace(Options.ZuoraEntityId))
            {
                httpClient.DefaultRequestHeaders.Remove("zuora-entity-ids");
                httpClient.DefaultRequestHeaders.Add("zuora-entity-ids", Options.ZuoraEntityId);
            }
        }

        private void AddHeadersToRequest(RestRequest request, Dictionary<string, string> headers)
        {
            if (headers == null) return;
            foreach (var header in headers)
            {
                request.AddHeader(header.Key, header.Value);
            }
        }

        private void AddParametersToRequest(RestRequest request, Dictionary<string, string> parameters, ParameterType parameterType)
        {
            if (parameters == null) return;
            foreach (var param in parameters)
            {
                request.AddParameter(param.Key, param.Value, parameterType);
            }
        }

        private void AddDefaultHeaders(Dictionary<string, string> headerParams)
        {
            headerParams.Add("zuora-track-id", _zuoraTrackId);
            headerParams.Add("async", _async.ToString());
            headerParams.Add("zuora-entity-ids", _zuoraEntityIds);
            headerParams.Add("idempotency-key", _idempotencyKey);
            headerParams.Add("accept-encoding", _acceptEncoding);
            headerParams.Add("content-encoding", _contentEncoding);
        }

        private FileStream CreateFileStream(string content, IList<Parameter> headers)
        {
            var filePath = string.IsNullOrEmpty(Configuration.TempFolderPath) ? Path.GetTempPath() : Configuration.TempFolderPath;
            var fileName = filePath + Guid.NewGuid();

            if (headers != null)
            {
                var regex = new Regex(@"Content-Disposition:.*filename=['""]?([^'""\s]+)['""]?$");
                var match = regex.Match(headers.ToString());
                if (match.Success)
                {
                    fileName = filePath + match.Value.Replace("\"", "").Replace("'", "");
                }
            }

            File.WriteAllText(fileName, content);
            return new FileStream(fileName, FileMode.Open);
        }
    }
}