using EasyCaching.Core;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Service.Client;
using Service.Models;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection;
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

        private readonly ILogger<ApiClient> _logger;

        private bool? _allowAsync;

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
        public ApiClient(IEasyCachingProvider cache, ILogger<ApiClient> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this._cache = cache;
            Counter = 0;
            using (StreamReader r = new StreamReader("config.json"))
            {
                _options = JsonConvert.DeserializeObject<ZuoraOptions>(r.ReadToEnd().ToString());

                zuoraTrackId = _options.ZuoraTrackId.ToString();
                BasePath = _options.BaseUrl;
                zuoraEntityIds = _options.ZuoraEntityId;
                idempotencyKey = _options.ZuoraIdempotencyKey;
                RestClient = new RestClient(BasePath);
            }
        }

        public int Counter{ get; set; }

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

        public string AddExpandParameter(Dictionary<string, string> paramtrs)
        {
            var parameters = new List<string>();
            if (paramtrs.Where(f => f.Key.Contains("expand")).Any())
            {
                parameters = paramtrs
                .Where(f => f.Key.Contains("expand"))
                .Select(f => f.Value)
                .FirstOrDefault()
                .Split(",")
                .ToList();
            }

            var expand = new StringBuilder();

            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            foreach (var item in parameters)
            {
                if (parameters.IndexOf(item) == (parameters.Count - 1))
                {
                    expand.Append($"expand%5B%5D={item}");
                }
                else
                {
                    expand.Append($"expand%5B%5D={item}&");
                }
            }

            return expand.ToString();
        }

        public string AddFilterParameter(Dictionary<string, string> paramtrs)
        {
            var parameters = new List<string>();
            if (paramtrs.Where(f => f.Key.Contains("filter")).Any())
            {
                parameters = paramtrs
                .Where(f => f.Key.Contains("filter"))
                .Select(f => f.Value)
                .FirstOrDefault()
                .Split(",")
                .ToList();
            }

            var expand = new StringBuilder();

            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            foreach (var item in parameters)
            {
                if (parameters.IndexOf(item) == (parameters.Count - 1))
                {
                    expand.Append($"filter%5B%5D={item}");
                }
                else
                {
                    expand.Append($"filter%5B%5D={item}&");
                }
            }

            return expand.ToString();
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
        public string AddPageSizeParameter(Dictionary<string, string> paramtrs)
        {
            var parameters = new List<string>();
            if (paramtrs.Where(f => f.Key.Contains("page_size")).Any())
            {
                parameters = paramtrs
                .Where(f => f.Key.Contains("page_size"))
                .Select(f => f.Value)
                .FirstOrDefault()
                .Split(",")
                .ToList();
            }

            //expand%5B%5D=account.bill_to&expand%5B%5D=account.sold_to&expand%5B%5D=subscription_plans.subscription_items
            var expand = new StringBuilder();

            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            foreach (var item in parameters)
            {
                expand.Append($"page_size={item}");
            }

            return expand.ToString();
        }

        /// <summary>
        /// Add cursor parameter to the query string.
        /// </summary>
        /// <param name="paramtrs"></param>
        /// <returns></returns>
        public string AddCursorParameter(Dictionary<string, string> paramtrs)
        {
            var parameters = new List<string>();
            if (paramtrs.Where(f => f.Key.Contains("cursor")).Any())
            {
                parameters = paramtrs
                .Where(f => f.Key.Contains("cursor"))
                .Select(f => f.Value)
                .FirstOrDefault()
                .Split(",")
                .ToList();
            }

            //expand%5B%5D=account.bill_to&expand%5B%5D=account.sold_to&expand%5B%5D=subscription_plans.subscription_items
            var expand = new StringBuilder();

            if (parameters == null || parameters.Count == 0)
                return string.Empty;

            foreach (var item in parameters)
            {
                expand.Append($"cursor={item}");
            }

            return expand.ToString();
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

        private string BuildParameters(Dictionary<string, string> queryParams)
        {
            string path = string.Empty;

            if (queryParams.Any())
            {
                path += "?";
            }
            if (queryParams.Where(f => f.Key.Contains("expand")).Any())
            {
                path += AddExpandParameter(queryParams);
            }
            if (queryParams.Where(f => f.Key.Contains("filter")).Any())
            {
                path += "&";
                path += AddFilterParameter(queryParams);
            }
            if (queryParams.Where(f => f.Key.Contains("page_size")).Any())
            {
                path += "&";
                path += AddPageSizeParameter(queryParams);
            }
            if (queryParams.Where(f => f.Key.Contains("cursor")).Any())
            {
                path += "&";
                path += AddCursorParameter(queryParams);
            }
            
            return path;
        }

        public RestResponse CallApi<T>(string pathRoute, RestSharp.Method method, Dictionary<string, string>? queryParams, string postBody, bool? async = true)
        {
            var path = pathRoute;
            path += BuildParameters(queryParams);
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

            //foreach (var param in queryParams)
            //    request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

            if (postBody != null) // http body (model) parameter
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);

            var result = RestClient.Execute(request);

                return result;
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
        public dynamic Deserialize(string content, Type type, IList<Parameter> headers = null)
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


        public void FillPersistentCache<T>(string path, Dictionary<string, string> queryParams, string postBody)
        {
            queryParams.Add("page_size", ParameterToString(95));
            int counter = 0;
          
            var response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
            var responseObject = (dynamic)Deserialize(response.Content, typeof(T));
            var nextPage = responseObject.NextPage;

            FillCache(responseObject, out counter);
            
            if (response.IsSuccessful && !string.IsNullOrEmpty(responseObject.NextPage))
            {
                queryParams.Add("cursor", ParameterToString(responseObject.NextPage));
                
                while (!string.IsNullOrEmpty(nextPage))
                {
                    // query parameter
                    queryParams["cursor"] = nextPage;
                    response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
                    var contentResponse = Deserialize(response.Content, typeof(T));
                    FillCache(contentResponse, out counter);
                    nextPage = contentResponse.NextPage;
                }
                Counter += counter;
                _logger.LogInformation($"Total items processed: {Counter} for {typeof(T).Name}");
            }
            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, $"Error calling {path}: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, $"Error calling {path}: " + response.ErrorMessage, response.ErrorMessage);
        }

        /// <summary>
        /// Executes an API request to retrieve data of the specified type, handling pagination and caching as needed.
        /// </summary>
        /// <remarks>This method handles paginated API responses by iteratively retrieving all pages of data until no
        /// further pages are available. It also caches the retrieved data for performance optimization. If the API response
        /// includes a "NextPage" cursor, the method automatically appends it to the query parameters to fetch subsequent
        /// pages.</remarks>
        /// <typeparam name="T">The type of the data to be retrieved from the API response.</typeparam>
        /// <param name="path">The API endpoint path to which the request is sent.</param>
        /// <param name="queryParams">A dictionary of query parameters to include in the request. Additional parameters may be added internally.</param>
        /// <param name="postBody">The body of the request, typically used for POST or PUT operations. Can be null for GET requests.</param>
        /// <returns>An object of type <typeparamref name="T"/> containing the aggregated data from the API response, including all
        /// paginated results if applicable.</returns>
        /// <exception cref="ApiException">Thrown if the API request fails with a status code of 400 or higher, or if there is a network error resulting in a
        /// status code of 0.</exception>
        public T ExecuteRequest<T>(string path, Dictionary<string, string> queryParams, string postBody)
        {
            queryParams.Add("page_size", ParameterToString(95));
            int counter = 0;
            var response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
            var responseObject = (dynamic)Deserialize(response.Content, typeof(T));
            FillCache(responseObject, out counter);

            if (CheckForProperty(responseObject, "Data"))
            {
                if (response.IsSuccessful && !string.IsNullOrEmpty(responseObject.NextPage))
                {
                    queryParams.Add("cursor", ParameterToString(responseObject.NextPage));

                    while (!string.IsNullOrEmpty(responseObject.NextPage))
                    {
                        // query parameter
                        queryParams["cursor"] = responseObject.NextPage;
                        response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
                        var contentResponse = (dynamic)Deserialize(response.Content, typeof(T));
                        responseObject.Data.AddRange(contentResponse.Data);
                        responseObject.NextPage = contentResponse.NextPage;
                        FillCache(contentResponse, out counter);

                    }

                    Counter += counter;

                    _logger.LogInformation($"Total items processed: {Counter} for {typeof(T).Name}");
                }
            }
            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, $"Error calling {path}: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, $"Error calling {path}: " + response.ErrorMessage, response.ErrorMessage);

            return responseObject;
        }

        public void ExecuteRequest<T>(string path, Dictionary<string, string> queryParams, string postBody, bool NoResponse)
        {
            queryParams.Add("page_size", ParameterToString(95));
            int counter = 0;
            var response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
            var responseObject = (dynamic)Deserialize(response.Content, typeof(T));
            FillCache(responseObject, out counter);

            if (CheckForProperty(responseObject, "Data"))
            {
                if (response.IsSuccessful && !string.IsNullOrEmpty(responseObject.NextPage))
                {
                    queryParams.Add("cursor", ParameterToString(responseObject.NextPage));

                    while (!string.IsNullOrEmpty(responseObject.NextPage))
                    {
                        // query parameter
                        queryParams["cursor"] = responseObject.NextPage;
                        response = (RestResponse)CallApi<T>(path, Method.Get, queryParams, postBody);
                        var accountResponse = (dynamic)Deserialize(response.Content, typeof(T));
                        FillCache(accountResponse, out counter);
                        responseObject.NextPage = accountResponse.NextPage;
                    }

                    Counter += counter;

                    _logger.LogInformation($"Total items processed: {Counter} for {typeof(T).Name}");
                }
            }
            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAccounts: " + response.ErrorMessage, response.ErrorMessage);
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

        public List<T> GetCahe<T>()
        {
            var cacheKey = $"{typeof(T).Name}";
            return _cache.GetByPrefix<T>(cacheKey).Values.Select(f => f.Value).ToList();
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
                return token.Access_token;
            }

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

        public List<T> RequestCachedResults<T>(string filter)
        {
            var cacheKey = $"{typeof(T).Name}_{filter}";
            return _cache.GetByPrefix<T>(cacheKey).Values.Select(f => f.Value).ToList();
        }

        public T RequestCachedResult<T>(string id)
        {
            var cacheKey = $"{typeof(T).Name}";
            return _cache.Get<T>($"{cacheKey}_{id}").Value;
        }

        public T RequestCachedResult<T>(string id, string secondFilter)
        {
            var cacheKey = $"{typeof(T).Name}";
            return _cache.Get<T>($"{cacheKey}_{id}_{secondFilter}").Value;
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
        public string? Serialize(object obj)
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

        private void FillCache(dynamic result, out int counter)
        {
            if (CheckForProperty(result,"Data"))
            {
                foreach (var item in result.Data)
                {
                    var name = item.GetType().Name;
                    if (_cache.Exists($"{name}_{item.Id}"))
                    {
                        _cache.Remove($"{name}_{item.Id}");
                        _cache.Set<dynamic>($"{name}_{item.Id}", item, TimeSpan.FromHours(23));
                    }
                    else
                    {
                        _cache.Set<dynamic>($"{name}_{item.Id}", item, TimeSpan.FromHours(23));
                    }
                    Counter++;
                }
                
            }
            else
            {
                var name = result.GetType().Name;
                if (_cache.Exists($"{name}_{result.Id}"))
                {
                    _cache.Remove($"{name}_{result.Id}");
                    _cache.Set<dynamic>($"{name}_{result.Id}", result, TimeSpan.FromHours(23));
                }
                else
                {
                    _cache.Set<dynamic>($"{name}_{result.Id}", result, TimeSpan.FromHours(23));
                }
            }
            counter = Counter;
        }

        public static bool CheckForProperty(dynamic settings, string name)
        {
            if (settings is ExpandoObject)
                return ((IDictionary<string, object>)settings).ContainsKey(name);

            return settings.GetType().GetProperty(name) != null;
        }
        private T GetCahe<T>(string id)
        {
            var cacheKey = $"{typeof(T).Name}";
            return _cache.Get<T>($"{cacheKey}_{id}").Value;
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

        private string GetRoute(Uri url)
        {
            Uri uri = url;
            string routeWithoutId = string.Empty;
            string path = uri.AbsolutePath;
            string[] segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);

            // Remove o último segmento (que seria o ID)
            if (segments.Length > 0)
            {
                // Junta todos os segmentos exceto o último
                 routeWithoutId = "/" + string.Join("/", segments.Take(2));
            }
            return routeWithoutId;
        }
    }
}