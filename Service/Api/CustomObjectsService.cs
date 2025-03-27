using RestSharp;
using Service.Interfaces;
using ZIP2GO.Service.Client;
using ZIP2GO.Service.Models;

namespace ZIP2GO.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomObjectsService : ICustomObjectsService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomObjectsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CustomObjectsService(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomObjectsService"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomObjectsService(string basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Create a custom object Creates a new custom object.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="customObjectType">Custom Object Definition Type</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response. Accepted &#x60;field&#x60; values will be those available in your tenant.</param>
        /// <param name="customObjectCustomObjectTypeFields">Allows you to specify which fields are returned in the response. Accepted &#x60;field&#x60; values and &#x60;custom_object_types&#x60; will be those available in your tenant.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the &#x27;Filter lists&#x27; section of the [Quickstart API Tutorial](https://developer.zuora.com/quickstart-api/tutorial/overview/) for detailed instructions.</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <returns>CustomObject</returns>
        public CustomObject CreateCustomObject(Dictionary<string, Object> body, string customObjectType, string zuoraTrackId, bool? async, List<string> fields, List<string> customObjectCustomObjectTypeFields, List<string> filter, int? pageSize, List<string> expand)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateCustomObject");
            // verify the required parameter 'customObjectType' is set
            if (customObjectType == null) throw new ApiException(400, "Missing required parameter 'customObjectType' when calling CreateCustomObject");

            var path = "/custom_objects/{custom_object_type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "custom_object_type" + "}", ApiClient.ParameterToString(customObjectType));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (customObjectCustomObjectTypeFields != null) queryParams.Add("custom_object[custom_object_type].fields[]", ApiClient.ParameterToString(customObjectCustomObjectTypeFields)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
           
           
           
           
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateCustomObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateCustomObject: " + response.ErrorMessage, response.ErrorMessage);

            return (CustomObject)ApiClient.Deserialize(response.Content, typeof(CustomObject));
        }

        /// <summary>
        /// Delete a custom object Permanently deletes a custom object. It cannot be undone.
        /// </summary>
        /// <param name="customObjectType">Custom Object Definition Type</param>
        /// <param name="customObjectId">Custom Object Id</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns></returns>
        public void DeleteCustomObject(string customObjectType, string customObjectId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'customObjectType' is set
            if (customObjectType == null) throw new ApiException(400, "Missing required parameter 'customObjectType' when calling DeleteCustomObject");
            // verify the required parameter 'customObjectId' is set
            if (customObjectId == null) throw new ApiException(400, "Missing required parameter 'customObjectId' when calling DeleteCustomObject");

            var path = "/custom_objects/{custom_object_type}/{custom_object_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "custom_object_type" + "}", ApiClient.ParameterToString(customObjectType));
            path = path.Replace("{" + "custom_object_id" + "}", ApiClient.ParameterToString(customObjectId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
           
           
           
           

            // authentication setting, if any
            string[] authSettings = new string[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Delete, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteCustomObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteCustomObject: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public string GetBasePath(string basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Retrieve a custom object Retrieves the custom object with the given ID.
        /// </summary>
        /// <param name="customObjectType">Custom Object Definition Type</param>
        /// <param name="customObjectId">Custom Object Id</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response. Accepted &#x60;field&#x60; values will be those available in your tenant.</param>
        /// <param name="customObjectCustomObjectTypeFields">Allows you to specify which fields are returned in the response. Accepted &#x60;field&#x60; values and &#x60;custom_object_types&#x60; will be those available in your tenant.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the &#x27;Filter lists&#x27; section of the [Quickstart API Tutorial](https://developer.zuora.com/quickstart-api/tutorial/overview/) for detailed instructions.</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>CustomObject</returns>
        public CustomObject GetCustomObject(string customObjectType, string customObjectId, List<string> fields, List<string> customObjectCustomObjectTypeFields, List<string> filter, int? pageSize, List<string> expand, string zuoraTrackId)
        {
            // verify the required parameter 'customObjectType' is set
            if (customObjectType == null) throw new ApiException(400, "Missing required parameter 'customObjectType' when calling GetCustomObject");
            // verify the required parameter 'customObjectId' is set
            if (customObjectId == null) throw new ApiException(400, "Missing required parameter 'customObjectId' when calling GetCustomObject");

            var path = "/custom_objects/{custom_object_type}/{custom_object_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "custom_object_type" + "}", ApiClient.ParameterToString(customObjectType));
            path = path.Replace("{" + "custom_object_id" + "}", ApiClient.ParameterToString(customObjectId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (customObjectCustomObjectTypeFields != null) queryParams.Add("custom_object[custom_object_type].fields[]", ApiClient.ParameterToString(customObjectCustomObjectTypeFields)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
           
           
           
           

            // authentication setting, if any
            string[] authSettings = new string[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetCustomObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCustomObject: " + response.ErrorMessage, response.ErrorMessage);

            return (CustomObject)ApiClient.Deserialize(response.Content, typeof(CustomObject));
        }

        /// <summary>
        /// List custom objects Returns a list of your custom objects.
        /// </summary>
        /// <param name="customObjectType">Custom Object Definition Type</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="cursor">A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="sort">A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. &#x60;account_number.asc&#x60;) or descending (e.g. &#x60;account_number.desc&#x60;). You cannot sort on properties that are arrays. If the array-type properties are specified for the &#x60;sort[]&#x60; parameter, they are ignored.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response. Accepted &#x60;field&#x60; values will be those available in your tenant.</param>
        /// <param name="customObjectCustomObjectTypeFields">Allows you to specify which fields are returned in the response. Accepted &#x60;field&#x60; values and &#x60;custom_object_types&#x60; will be those available in your tenant.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>ListCustomObjectResponse</returns>
        public ListCustomObjectResponse GetCustomObjects(string customObjectType, int? pageSize, List<string> expand, string cursor, List<string> filter, List<string> sort, List<string> fields, List<string> customObjectCustomObjectTypeFields, string zuoraTrackId)
        {
            // verify the required parameter 'customObjectType' is set
            if (customObjectType == null) throw new ApiException(400, "Missing required parameter 'customObjectType' when calling GetCustomObjects");

            var path = "/custom_objects/{custom_object_type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "custom_object_type" + "}", ApiClient.ParameterToString(customObjectType));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (sort != null) queryParams.Add("sort[]", ApiClient.ParameterToString(sort)); // query parameter
            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (customObjectCustomObjectTypeFields != null) queryParams.Add("custom_object[custom_object_type].fields[]", ApiClient.ParameterToString(customObjectCustomObjectTypeFields)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
           
           
           
           

            // authentication setting, if any
            string[] authSettings = new string[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetCustomObjects: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCustomObjects: " + response.ErrorMessage, response.ErrorMessage);

            return (ListCustomObjectResponse)ApiClient.Deserialize(response.Content, typeof(ListCustomObjectResponse));
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(string basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Update a custom object Updates the specified custom object by setting the values of the parameters passed. Any parameters not provided will be left unchanged.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="customObjectType">Custom Object Definition Type</param>
        /// <param name="customObjectId">Custom Object Id</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response. Accepted &#x60;field&#x60; values will be those available in your tenant.</param>
        /// <param name="customObjectCustomObjectTypeFields">Allows you to specify which fields are returned in the response. Accepted &#x60;field&#x60; values and &#x60;custom_object_types&#x60; will be those available in your tenant.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the &#x27;Filter lists&#x27; section of the [Quickstart API Tutorial](https://developer.zuora.com/quickstart-api/tutorial/overview/) for detailed instructions.</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <returns>CustomObject</returns>
        public CustomObject UpdateCustomObject(Dictionary<string, Object> body, string customObjectType, string customObjectId, string zuoraTrackId, bool? async, List<string> fields, List<string> customObjectCustomObjectTypeFields, List<string> filter, int? pageSize, List<string> expand)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCustomObject");
            // verify the required parameter 'customObjectType' is set
            if (customObjectType == null) throw new ApiException(400, "Missing required parameter 'customObjectType' when calling UpdateCustomObject");
            // verify the required parameter 'customObjectId' is set
            if (customObjectId == null) throw new ApiException(400, "Missing required parameter 'customObjectId' when calling UpdateCustomObject");

            var path = "/custom_objects/{custom_object_type}/{custom_object_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "custom_object_type" + "}", ApiClient.ParameterToString(customObjectType));
            path = path.Replace("{" + "custom_object_id" + "}", ApiClient.ParameterToString(customObjectId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (customObjectCustomObjectTypeFields != null) queryParams.Add("custom_object[custom_object_type].fields[]", ApiClient.ParameterToString(customObjectCustomObjectTypeFields)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
           
           
           
           
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Patch, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateCustomObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateCustomObject: " + response.ErrorMessage, response.ErrorMessage);

            return (CustomObject)ApiClient.Deserialize(response.Content, typeof(CustomObject));
        }
    }
}