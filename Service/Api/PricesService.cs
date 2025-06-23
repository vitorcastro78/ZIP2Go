using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;
using EasyCaching.Core;
using Service.Constants;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PricesService : IPricesService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="PricesService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public PricesService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = expand = new Expands().PriceExpand;
            filter = new List<string>();
        }


        /// <summary>
        /// Create a price Creates a new price for an existing plan.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;tiers&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;revenue_recognition_rule&#x60;, &#x60;stacked_discount&#x60;, &#x60;recognized_revenue_accounting_code&#x60;, &#x60;deferred_revenue_accounting_code&#x60;, &#x60;accounting_code&#x60;, &#x60;recurring&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;taxable&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;min_quantity&#x60;, &#x60;max_quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;discount_level&#x60;, &#x60;overage&#x60;, &#x60;plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;apply_discount_to&#x60;, &#x60;prepayment&#x60;, &#x60;drawdown&#x60;, &#x60;discount_amounts&#x60;, &#x60;unit_amounts&#x60;, &#x60;discount_percent&#x60;, &#x60;amounts&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>Price</returns>
        public Price CreatePrice(PriceCreateRequest body, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePrice");

            var path =$"v2/prices";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Price>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreatePrice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreatePrice: " + response.ErrorMessage, response.ErrorMessage);

            return (Price)_apiClient.Deserialize(response.Content, typeof(Price));
        }

        /// <summary>
        /// Delete a price Permanently deletes a price. It cannot be undone.
        /// </summary>
        /// <param name="priceId">Price Id</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns></returns>
        public void DeletePrice(string priceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'priceId' is set
            if (priceId == null) throw new ApiException(400, "Missing required parameter 'priceId' when calling DeletePrice");

            var path =$"v2/prices/{priceId}";
            
            path = path.Replace("{" + "priceId" + "}", _apiClient.ParameterToString(priceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Price>(path, Method.Delete, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeletePrice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeletePrice: " + response.ErrorMessage, response.ErrorMessage);

            return;
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
        /// Retrieve a price Retrieves the price with the given ID.
        /// </summary>
        /// <param name="priceId">Price Id</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;tiers&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;revenue_recognition_rule&#x60;, &#x60;stacked_discount&#x60;, &#x60;recognized_revenue_accounting_code&#x60;, &#x60;deferred_revenue_accounting_code&#x60;, &#x60;accounting_code&#x60;, &#x60;recurring&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;taxable&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;min_quantity&#x60;, &#x60;max_quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;discount_level&#x60;, &#x60;overage&#x60;, &#x60;plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;apply_discount_to&#x60;, &#x60;prepayment&#x60;, &#x60;drawdown&#x60;, &#x60;discount_amounts&#x60;, &#x60;unit_amounts&#x60;, &#x60;discount_percent&#x60;, &#x60;amounts&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>Price</returns>
        public Price GetPrice(string priceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'priceId' is set
            if (priceId == null) throw new ApiException(400, "Missing required parameter 'priceId' when calling GetPrice");

            var path =$"v2/prices/{priceId}";
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();


            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            // make the HTTP request
            return _apiClient.ExecuteRequest<Price>(path, queryParams, postBody);
        }

        /// <summary>
        /// Retrieves a list of prices based on the specified parameters.
        /// </summary>
        /// <remarks>This method sends a GET request to the API endpoint to retrieve pricing information.  Query
        /// parameters and headers are dynamically constructed based on the provided arguments.  Ensure that the API client is
        /// properly configured before calling this method.</remarks>
        /// <param name="zuoraTrackId">A unique identifier used to track the request in Zuora. This parameter is optional but, if provided,  must be a
        /// non-empty string.</param>
        /// <param name="async">A boolean value indicating whether the request should be processed asynchronously.  If <see langword="true"/>, the
        /// operation will be performed asynchronously; otherwise, it will be synchronous.</param>
        /// <returns>A <see cref="PriceListResponse"/> object containing the list of prices and associated metadata.</returns>
        /// <exception cref="ApiException">Thrown if the API call fails due to a client or server error. The exception contains details about the  HTTP status
        /// code and error message.</exception>
        public void GetPrices(string zuoraTrackId, bool? async)
        {
            var path =$"v2/prices";
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();



            //if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            _apiClient.FillPersistentCache<PriceListResponse>(path, queryParams, null);
        }

        /// <summary>
        /// Populates the persistent cache with price data retrieved from the API.
        /// </summary>
        /// <remarks>This method retrieves price data from the API and stores it in a persistent cache for future use. 
        /// The cache is populated using the specified query parameters and API path.</remarks>
        /// <param name="zuoraTrackId">The tracking identifier used for logging or tracing the request. This parameter cannot be null or empty.</param>
        /// <param name="async">A boolean value indicating whether the operation should be performed asynchronously.  If <see langword="true"/>, the
        /// operation is performed asynchronously; otherwise, it is performed synchronously.</param>
        public void FillPricesCache(string zuoraTrackId, bool? async)
        {
            var path = $"v2/prices";
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();



            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
//            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            _apiClient.FillPersistentCache<PriceListResponse>(path, queryParams, null);
        }


        /// <summary>
        /// Updates an existing price resource with the specified changes.
        /// </summary>
        /// <remarks>The <paramref name="body"/> parameter must include the fields to be updated for the
        /// specified price resource. The <paramref name="priceId"/> parameter identifies the price resource to be
        /// updated. If <paramref name="async"/> is set to <see langword="true"/>, the operation may return before the
        /// update is fully completed.</remarks>
        /// <param name="body">The request object containing the fields to update for the price resource. This parameter cannot be <see
        /// langword="null"/>.</param>
        /// <param name="priceId">The unique identifier of the price resource to update. This parameter cannot be <see langword="null"/> or
        /// empty.</param>
        /// <param name="zuoraTrackId">An optional tracking identifier for the request, used for tracing purposes.</param>
        /// <param name="async">An optional flag indicating whether the operation should be performed asynchronously. If <see
        /// langword="true"/>, the operation is performed asynchronously; otherwise, it is performed synchronously.</param>
        /// <returns>The updated <see cref="Price"/> resource.</returns>
        /// <exception cref="ApiException">Thrown if the request fails due to invalid input, a missing required parameter, or a server-side error.</exception>
        public Price PatchPrice(PricePatchRequest body, string priceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchPrice");
            // verify the required parameter 'priceId' is set
            if (priceId == null) throw new ApiException(400, "Missing required parameter 'priceId' when calling PatchPrice");

            var path =$"v2/prices/{priceId}";
            
            path = path.Replace("{" + "priceId" + "}", _apiClient.ParameterToString(priceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Price>(path, Method.Patch, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PatchPrice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PatchPrice: " + response.ErrorMessage, response.ErrorMessage);

            return (Price)_apiClient.Deserialize(response.Content, typeof(Price));
        }

        public PriceListResponse GetPricesCached()
        {
            return new PriceListResponse
            {
                Data = _apiClient.RequestCachedResult<Price>()
            };
        }

        public Price GetPriceCached(string priceId) => _apiClient.RequestCachedResult<Price>(priceId);
    }
}