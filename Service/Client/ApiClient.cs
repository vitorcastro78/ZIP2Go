using EasyCaching.Core;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Service.Client;
using Service.Models;
using System.Net.Http.Headers;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Service.Client
{

    /// <summary>
    /// API client is mainly responible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiClient : IApiClient
    {
        private readonly IEasyCachingProvider _cache;

        private readonly Dictionary<string, string> _defaultHeaderMap = new Dictionary<string, string>();

        private bool? _allowAsync;

        ///private readonly ApiAuthClient apiAuthClient;
        private ZuoraOptions _options;

        private string acceptEncoding;

        private string contentEncoding;

        private string idempotencyKey;

        private string zuoraEntityIds;

        private string zuoraTrackId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public ApiClient(string Basepath, IEasyCachingProvider cache)
        {
            // apiAuthClient = new ApiAuthClient(_cache);
            this._cache = cache;
            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + $"\\config.json"))
            {
                var tst = r.ReadToEnd().ToString();
                _options = JsonConvert.DeserializeObject<ZuoraOptions>(tst);

                zuoraTrackId = _options.ZuoraTrackId.ToString();
                BasePath = _options.BaseUrl;
                zuoraEntityIds = _options.ZuoraEntityId;
                idempotencyKey = _options.ZuoraIdempotencyKey;
                RestClient = new RestClient(BasePath);
            }
        }

        public string BasePath { get; set; }

        /// <summary>
        /// Gets or sets the base path.
        /// </summary>
        /// <value>The base path</value>

        /// <summary>
        /// Gets the default header.
        /// </summary>
        public Dictionary<string, string> DefaultHeader
        {
            get { return _defaultHeaderMap; }
        }

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public RestClient RestClient { get; set; }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string key, string value)
        {
            _defaultHeaderMap.Add(key, value);
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public string Base64Encode(string text)
        {
            var textByte = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textByte);
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
        public RestResponse CallApi(string path, RestSharp.Method method, Dictionary<string, string> queryParams, string postBody, bool? async = true)
        {
            var headerParams = new Dictionary<string, string>();
            var request = new RestRequest(path, method);
            var response = new Object();

            var token = this.GetToken();

            if (!string.IsNullOrEmpty(_options.ZuoraTrackId.ToString()))
                headerParams.Add("zuora-track-id", _options.ZuoraTrackId.ToString());
            if (!string.IsNullOrEmpty(_options.ZuoraEntityId))
                headerParams.Add("zuora-entity-ids", _options.ZuoraEntityId);
            if (!string.IsNullOrEmpty(token))
                headerParams.Add("Authorization", "Bearer " + token);

            if (method == Method.Patch || method == Method.Post)
            {
                if (!string.IsNullOrEmpty(_options.ZuoraIdempotencyKey))
                    headerParams.Add("idempotency-key", _options.ZuoraIdempotencyKey); // header parameter
            }

            foreach (var defaultHeader in _defaultHeaderMap)
                request.AddHeader(defaultHeader.Key, defaultHeader.Value);

            foreach (var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            foreach (var param in queryParams)
                request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

            if (postBody != null) // http body (model) parameter
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);

            var result = RestClient.Execute(request);

            var ret = Deserialize(result.Content, typeof(Product));

            if (method != Method.Get)
            {
                FillCache(ret);
                return result;
            }
            else
            {
                return result;
            }
        }

        public RestResponse CallApi<T>(string path, RestSharp.Method method, Dictionary<string, string>? queryParams, string postBody, bool? async = true)
        {
            var headerParams = new Dictionary<string, string>();
            var request = new RestRequest(path, method);
            var response = new Object();

            var token = this.GetToken();

            if (!string.IsNullOrEmpty(_options.ZuoraTrackId.ToString()))
                headerParams.Add("zuora-track-id", _options.ZuoraTrackId.ToString());
            if (!string.IsNullOrEmpty(_options.ZuoraEntityId))
                headerParams.Add("zuora-entity-ids", _options.ZuoraEntityId);
            if (!string.IsNullOrEmpty(token))
                headerParams.Add("Authorization", "Bearer " + token);

            if (method == Method.Patch || method == Method.Post)
            {
                if (!string.IsNullOrEmpty(_options.ZuoraIdempotencyKey))
                    headerParams.Add("idempotency-key", _options.ZuoraIdempotencyKey); // header parameter
            }

            foreach (var defaultHeader in _defaultHeaderMap)
                request.AddHeader(defaultHeader.Key, defaultHeader.Value);

            foreach (var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            foreach (var param in queryParams)
                request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

            if (postBody != null) // http body (model) parameter
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);

            var result = RestClient.Execute(request);

            if (method != Method.Get)
            {
                var ret = Deserialize(result.Content, typeof(T));
                SetCache<T>(ret);
                return result;
            }
            else
            {
                return result;
            }
        }

        public List<T> CallApi<T>()
        {
            var cacheKey = $"{typeof(T).Name}";
            return _cache.GetByPrefix<T>(cacheKey).Values.Select(f => f.Value).ToList();
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// </summary>
        /// <param name="fromObject">Object to be casted</param>
        /// <param name="toObject">Target type</param>
        /// <returns>Casted object</returns>
        public Object ConvertType(Object fromObject, Type toObject)
        {
            return Convert.ChangeType(fromObject, toObject);
        }

        /// <summary>
        /// Deserialize the JSON strireturn _apiClient.ExecuteRequest<ProductListResponse>(path, queryParams, postBody);ng into a proper object.
        /// </summary>
        /// <param name="content">HTTP body (e.g. string, JSON).</param>
        /// <param name="type">Object type.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(string content, Type type, IList<Parameter> headers = null)
        {
            if (type == typeof(Object)) // return an object
            {
                return content;
            }

            if (type == typeof(Stream))
            {
                var filePath = string.IsNullOrEmpty(Configuration.TempFolderPath)
                    ? Path.GetTempPath()
                    : Configuration.TempFolderPath;

                var fileName = filePath + Guid.NewGuid();
                if (headers != null)
                {
                    var regex = new Regex(@"Content-Disposition:.*filename=['""]?([^'""\s]+)['""]?$");
                    var match = regex.Match(headers.ToString());
                    if (match.Success)
                        fileName = filePath + match.Value.Replace("\"", "").Replace("'", "");
                }
                File.WriteAllText(fileName, content);
                return new FileStream(fileName, FileMode.Open);
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(content, null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(content, type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(content, type);
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">string to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str)
        {
            return HttpUtility.UrlEncode(str);
        }

        public T ExecuteRequest<T>(string path, Dictionary<string, string> queryParams, string postBody)
        {
            queryParams.Add("page_size", ParameterToString(95));

            var response = (RestResponse)CallApi(path, Method.Get, queryParams, postBody);
            var responseObject = (dynamic)Deserialize(response.Content, typeof(T));

            // query parameter
            queryParams.Add("cursor", ParameterToString(responseObject.NextPage));

            while (!string.IsNullOrEmpty(responseObject.NextPage))
            {
                // query parameter
                queryParams["cursor"] = responseObject.NextPage;
                response = (RestResponse)CallApi(path, Method.Get, queryParams, postBody);
                var accountResponse = (dynamic)Deserialize(response.Content, typeof(T));
                responseObject.Data.AddRange(accountResponse.Data);
                responseObject.NextPage = accountResponse.NextPage;
            }

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAccounts: " + response.ErrorMessage, response.ErrorMessage);

            FillCache(responseObject);

            return responseObject;
        }

        /// <summary>
        /// Get the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string apiKeyIdentifier)
        {
            var apiKeyValue = "";
            Configuration.ApiKey.TryGetValue(apiKeyIdentifier, out apiKeyValue);
            var apiKeyPrefix = "";
            if (Configuration.ApiKeyPrefix.TryGetValue(apiKeyIdentifier, out apiKeyPrefix))
                return apiKeyPrefix + " " + apiKeyValue;
            else
                return apiKeyValue;
        }

        public string GetToken()
        {
            var token = new ZuoraToken();

            if (_cache != null && _cache.Exists("ZuoraToken"))
            {
                token = _cache.Get<ZuoraToken>("ZuoraToken").Value;
            }
            if (token != null && DateTime.UtcNow < token.ExpiresAt?.AddSeconds(-60))
            {
                // _logger.LogDebug($"Token expires in more than 60 seconds at {token.ExpiresAt}. Re-using token.");
                return token.Access_token;
            }

            // _logger.LogDebug($"Token expires in less than 60 seconds at {token?.ExpiresAt}. Re-generating token.");
            //  var parameter = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{_options.UserId}:{_options.Password}"));
            var nameValueCollection = new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" },
                    { "client_id", _options.ClientID },
                    { "client_secret", _options.ClientSecret }
                };

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_options.BaseUrl);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", parameter);

            var result = httpClient.PostAsync($"{_options.BaseUrl}oauth/token", new FormUrlEncodedContent(nameValueCollection)).Result;
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
            _cache.Set("ZuoraToken", token, TimeSpan.FromSeconds(token.Expires_in <= 0 ? 900 : token.Expires_in)
            );

            return token.Access_token;
        }

        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        //public FileParameter ParameterToFile(string name, Stream stream, CancellationToken cancellationToken)
        //{
        //    if (stream is FileStream)
        //        return FileParameter.Create(name, stream.(), Path.GetFileName(((FileStream)stream).Name));
        //    else
        //        return FileParameter.Create(name, stream.ReadAllBytes(), "no_file_name_provided");
        //}
        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list of string, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime)obj).ToString(Configuration.DateTimeFormat);
            else if (obj is List<string>)
                return string.Join(",", (obj as List<string>).ToArray());
            else
                return Convert.ToString(obj);
        }

        public List<T> RequestCachedResult<T>()
        {
            var cacheKey = $"{typeof(T).Name}";
            return _cache.GetByPrefix<T>(cacheKey).Values.Select(f => f.Value).ToList();
        }

        public T RequestCachedResult<T>(string id)
        {
            var cacheKey = $"{typeof(T).Name}";
            return _cache.Get<T>($"{cacheKey}_{id}").Value;
        }

        public T RequestCachedResultById<T>(string id)
        {
            return _cache.Get<T>($"{id}").Value;
        }
        /// <summary>
        /// Serialize an object into JSON string.
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public string Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
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

            foreach (string auth in authSettings)
            {
                // determine which one to use
                switch (auth)
                {
                    case "bearerAuth":

                        break;

                    default:
                        //TODO show warning about security definition not found
                        break;
                }
            }
        }

        private void FillCache(dynamic result)
        {
            foreach (var item in result.Data)
            {
                var name = item.GetType().Name;
                _cache.SetAsync<dynamic>($"{name}_{item.Id}", item, TimeSpan.FromHours(12));
            }
        }


        private void SetCache<T>(dynamic result)
        {
            var cacheKey = $"{typeof(T).Name}";
            _cache.SetAsync<dynamic>($"{cacheKey}_{result.Id}", result, TimeSpan.FromHours(12));
        }
        private void SetCache(dynamic result)
        {
            var cacheKey = result.GetType().Name;
            _cache.SetAsync<dynamic>($"{cacheKey}_{result.Id}", result, TimeSpan.FromHours(12));
        }

        private T GetCahe<T>(string id)
        {
            var cacheKey = $"{typeof(T).Name}";
            return _cache.Get<T>($"{cacheKey}_{id}").Value;
        }

        public List<T> GetCahe<T>()
        {
            var cacheKey = $"{typeof(T).Name}";
            return _cache.GetByPrefix<T>(cacheKey).Values.Select(f => f.Value).ToList();
        }
    }
}