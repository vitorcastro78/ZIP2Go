using RestSharp;
using Service.Interfaces;
using ZIP2GO.Service.Client;
using ZIP2GO.Service.Models;

namespace ZIP2GO.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TaxationItemsService : ITaxationItemsService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxationItemsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TaxationItemsService(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxationItemsService"/> class.
        /// </summary>
        /// <returns></returns>
        public TaxationItemsService(string basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Create a taxation item Creates a taxation item.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>TaxationItem</returns>
        public TaxationItem CreateTaxationItem(TaxationItemCreateRequest body, string zuoraTrackId, bool? async, List<string> fields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateTaxationItem");

            var path = "/taxation_items";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
           
           
           
           
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateTaxationItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateTaxationItem: " + response.ErrorMessage, response.ErrorMessage);

            return (TaxationItem)ApiClient.Deserialize(response.Content, typeof(TaxationItem));
        }

        /// <summary>
        /// Delete a taxation item Permanently deletes a taxation item. This operation cannot be undone once it is performed.
        /// </summary>
        /// <param name="taxationItemId">ID of the taxation item.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns></returns>
        public void DeleteTaxationItem(string taxationItemId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'taxationItemId' is set
            if (taxationItemId == null) throw new ApiException(400, "Missing required parameter 'taxationItemId' when calling DeleteTaxationItem");

            var path = "/taxation_items/{taxation_item_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taxation_item_id" + "}", ApiClient.ParameterToString(taxationItemId));

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
                throw new ApiException((int)response.StatusCode, "Error calling DeleteTaxationItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteTaxationItem: " + response.ErrorMessage, response.ErrorMessage);

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
        /// Retrieve a taxation item Retrieves the taxation item with the given ID.
        /// </summary>
        /// <param name="taxationItemId">ID of the taxation item.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>TaxationItem</returns>
        public TaxationItem GetTaxationItem(string taxationItemId, List<string> fields, List<string> expand, List<string> filter, int? pageSize, string zuoraTrackId)
        {
            // verify the required parameter 'taxationItemId' is set
            if (taxationItemId == null) throw new ApiException(400, "Missing required parameter 'taxationItemId' when calling GetTaxationItem");

            var path = "/taxation_items/{taxation_item_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taxation_item_id" + "}", ApiClient.ParameterToString(taxationItemId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
           
           
           
           

            // authentication setting, if any
            string[] authSettings = new string[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetTaxationItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetTaxationItem: " + response.ErrorMessage, response.ErrorMessage);

            return (TaxationItem)ApiClient.Deserialize(response.Content, typeof(TaxationItem));
        }

        /// <summary>
        /// List taxation items Returns an array of taxation items. Each entry in the array is a separate Taxation Item object. If no more taxation items are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <param name="cursor">A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="sort">A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. &#x60;account_number.asc&#x60;) or descending (e.g. &#x60;account_number.desc&#x60;). You cannot sort on properties that are arrays. If the array-type properties are specified for the &#x60;sort[]&#x60; parameter, they are ignored.</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>TaxationItemListResponse</returns>
        public TaxationItemListResponse GetTaxationItems(string cursor, List<string> expand, List<string> filter, List<string> sort, int? pageSize, List<string> fields, string zuoraTrackId)
        {
            var path = "/taxation_items";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (sort != null) queryParams.Add("sort[]", ApiClient.ParameterToString(sort)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
           
           
           
           

            // authentication setting, if any
            string[] authSettings = new string[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetTaxationItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetTaxationItems: " + response.ErrorMessage, response.ErrorMessage);

            return (TaxationItemListResponse)ApiClient.Deserialize(response.Content, typeof(TaxationItemListResponse));
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
        /// Update a taxation item Updates a taxation item by setting the values of the specified fields. Any fields not provided in the request remain unchanged.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="taxationItemId">ID of the taxation item.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>TaxationItem</returns>
        public TaxationItem UpdateTaxationItem(TaxationItemPatchRequest body, string taxationItemId, string zuoraTrackId, bool? async, List<string> fields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateTaxationItem");
            // verify the required parameter 'taxationItemId' is set
            if (taxationItemId == null) throw new ApiException(400, "Missing required parameter 'taxationItemId' when calling UpdateTaxationItem");

            var path = "/taxation_items/{taxation_item_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taxation_item_id" + "}", ApiClient.ParameterToString(taxationItemId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
           
           
           
           
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = new string[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Patch, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateTaxationItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateTaxationItem: " + response.ErrorMessage, response.ErrorMessage);

            return (TaxationItem)ApiClient.Deserialize(response.Content, typeof(TaxationItem));
        }
    }
}