using Newtonsoft.Json;
using RestSharp;
using System.Text.RegularExpressions;
using System.Web;
using ZIP2GO.Service.Models;

namespace ZIP2GO.Client
{
    /// <summary>
    /// API client is mainly responible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiClient
    {
        private string zuoraTrackId;
        private bool? _async;
        private string zuoraEntityIds;
        private string idempotencyKey;
        private string acceptEncoding;
        private string contentEncoding;

        private readonly Dictionary<string, string> _defaultHeaderMap = new Dictionary<string, string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public ApiClient(string basePath = "https://rest.sandbox.na.zuora.com/v2")
        {
            BasePath = basePath;
            RestClient = new RestClient(BasePath);
        }

        /// <summary>
        /// Gets or sets the base path.
        /// </summary>
        /// <value>The base path</value>
        public string BasePath { get; set; }

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
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            var textByte = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textByte);
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// </summary>
        /// <param name="fromObject">Object to be casted</param>
        /// <param name="toObject">Target type</param>
        /// <returns>Casted object</returns>
        public static Object ConvertType(Object fromObject, Type toObject)
        {
            return Convert.ChangeType(fromObject, toObject);
        }

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
        public Object CallApi(string path, RestSharp.Method method, Dictionary<string, string> queryParams, string postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, string[] authSettings)
        {
            var request = new RestRequest(path, method);
            var response = new Object();
            UpdateParamsForAuth(queryParams, headerParams, authSettings);

            // add default header, if any
            foreach (var defaultHeader in _defaultHeaderMap)
                request.AddHeader(defaultHeader.Key, defaultHeader.Value);

            // add header parameter, if any
            foreach (var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            // add query parameter, if any
            foreach (var param in queryParams)
                request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

            // add form parameter, if any
            foreach (var param in formParams)
                request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

            // add file parameter, if any
            //// foreach(var param in fileParams)
            ////    request.AddFile(param.Value.Name, param.Value, param.Value.FileName, param.Value.ContentType);

            if (postBody != null) // http body (model) parameter
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);


            if(method == Method.Post)
            {
                response = (Object)RestClient.Execute(request);
                
            }

            return response;

        }

        public T CallApi<T>(string path, RestSharp.Method method, Dictionary<string, string> queryParams, string postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, string[] authSettings)
        {
            var request = new RestRequest(path, method);
            var response = new Object();
            UpdateParamsForAuth(queryParams, headerParams, authSettings);

            // add default header, if any
            foreach (var defaultHeader in _defaultHeaderMap)
                request.AddHeader(defaultHeader.Key, defaultHeader.Value);

            // add header parameter, if any
            foreach (var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            // add query parameter, if any
            foreach (var param in queryParams)
                request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

            // add form parameter, if any
            foreach (var param in formParams)
                request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

            // add file parameter, if any
            //// foreach(var param in fileParams)
            ////    request.AddFile(param.Value.Name, param.Value, param.Value.FileName, param.Value.ContentType);

            if (postBody != null) // http body (model) parameter
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);


            return (T)Deserialize(RestClient.Execute(request).Content,typeof(T));
            
            

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
    }
}