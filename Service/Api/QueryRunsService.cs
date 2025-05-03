using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;
using EasyCaching.Core;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QueryRunsService : IQueryRunsService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        private readonly IEasyCachingProvider _cache;
        public readonly IApiClient _apiClient;
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public QueryRunsService(ApiClient apiClient, IEasyCachingProvider cache)
        {

            _apiClient = apiClient;
            _cache = cache;
        }




        /// <summary>
        /// Cancel a query run Cancels a query run. This operation is only applicable if the state of the query run is &#x60;accepted&#x60; or &#x60;in_progress&#x60;.
        /// </summary>
        /// <param name="queryRunId">query_run_id</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;created_by_id&#x60;, &#x60;id&#x60;, &#x60;sql&#x60;, &#x60;remaining_attempts&#x60;, &#x60;updated_time&#x60;, &#x60;file&#x60;, &#x60;number_of_rows&#x60;, &#x60;processing_duration&#x60;, &#x60;state&#x60;, &#x60;column_separator&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityId">An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>QueryRun</returns>
        public QueryRun CancelQueryRun(string queryRunId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'queryRunId' is set
            if (queryRunId == null) throw new ApiException(400, "Missing required parameter 'queryRunId' when calling CancelQueryRun");

            var path = "/query_runs/{query_run_id}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "query_run_id" + "}", _apiClient.ParameterToString(queryRunId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", _apiClient.ParameterToString(fields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", _apiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
                                                                                              // if (zuoraEntityId != null) headerParams.Add("zuora-entity-id", _apiClient.ParameterToString(zuoraEntityId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CancelQueryRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CancelQueryRun: " + response.ErrorMessage, response.ErrorMessage);

            return (QueryRun)_apiClient.Deserialize(response.Content, typeof(QueryRun));
        }

        /// <summary>
        /// Create a query run Creates a new query run job.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;created_by_id&#x60;, &#x60;id&#x60;, &#x60;sql&#x60;, &#x60;remaining_attempts&#x60;, &#x60;updated_time&#x60;, &#x60;file&#x60;, &#x60;number_of_rows&#x60;, &#x60;processing_duration&#x60;, &#x60;state&#x60;, &#x60;column_separator&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>QueryRun</returns>
        public QueryRun CreateQueryRun(QueryRunCreateRequest body, string zuoraTrackId, bool? async, List<string> fields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateQueryRun");

            var path = "/query_runs";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", _apiClient.ParameterToString(fields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", _apiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateQueryRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateQueryRun: " + response.ErrorMessage, response.ErrorMessage);

            return (QueryRun)_apiClient.Deserialize(response.Content, typeof(QueryRun));
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public string GetBasePath(string basePath)
        {
            return this._apiClient.BasePath;
        }

        /// <summary>
        /// Retrieve a query run Retrieves the query run with the given ID.
        /// </summary>
        /// <param name="queryRunId">query_run_id</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;created_by_id&#x60;, &#x60;id&#x60;, &#x60;sql&#x60;, &#x60;remaining_attempts&#x60;, &#x60;updated_time&#x60;, &#x60;file&#x60;, &#x60;number_of_rows&#x60;, &#x60;processing_duration&#x60;, &#x60;state&#x60;, &#x60;column_separator&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>QueryRun</returns>
        public QueryRun GetQueryRun(string queryRunId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'queryRunId' is set
            if (queryRunId == null) throw new ApiException(400, "Missing required parameter 'queryRunId' when calling GetQueryRun");

            var path = "/query_runs/{query_run_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "query_run_id" + "}", _apiClient.ParameterToString(queryRunId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", _apiClient.ParameterToString(fields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", _apiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetQueryRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetQueryRun: " + response.ErrorMessage, response.ErrorMessage);

            return (QueryRun)_apiClient.Deserialize(response.Content, typeof(QueryRun));
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(string basePath)
        {
            this._apiClient.BasePath = basePath;
        }
    }
}