using EasyCaching.Core;
using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BillingDocumentsService : IBillingDocumentsService
    {

        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public BillingDocumentsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new List<string>();
            filter = new List<string>();
        }



        /// <summary>
        /// Retrieve a billing document Retrieves the billing document with the given ID.
        /// </summary>
        /// <param name="billingDocumentId">Identifier for the billingDocument, either &#x60;billing_document_number&#x60; or &#x60;billing_document_id&#x60;</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;accountId&#x60;, &#x60;balance&#x60;, &#x60;description&#x60;, &#x60;state&#x60;, &#x60;tax&#x60;          &lt;/details&gt;</param>
        /// <param name="billingDocumentItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscriptionId&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;          &lt;/details&gt;</param>
        /// <param name="taxationItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>BillingDocument</returns>
        public BillingDocument GetBillingDocument(string billingDocumentId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'billingDocumentId' is set
            if (billingDocumentId == null) throw new ApiException(400, "Missing required parameter 'billingDocumentId' when calling GetBillingDocument");

            var path =$"v2/billing_documents/{billingDocumentId}";
            
            path = path.Replace("{" + "billing_document_id" + "}", _apiClient.ParameterToString(billingDocumentId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<BillingDocument>(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetBillingDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetBillingDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingDocument)_apiClient.Deserialize(response.Content, typeof(BillingDocument));
        }

        /// <summary>
        /// List billing documents Returns a dictionary with a data property that contains an array of billing documents, starting after cursor. Each entry in the array is a separate billing document object. If no more billing documents are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <param name="cursor">A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="sort">A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. &#x60;account_number.asc&#x60;) or descending (e.g. &#x60;account_number.desc&#x60;). You cannot sort on properties that are arrays. If the array-type properties are specified for the &#x60;sort[]&#x60; parameter, they are ignored.</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;accountId&#x60;, &#x60;balance&#x60;, &#x60;description&#x60;, &#x60;state&#x60;, &#x60;tax&#x60;          &lt;/details&gt;</param>
        /// <param name="billingDocumentItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscriptionId&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;          &lt;/details&gt;</param>
        /// <param name="taxationItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;          &lt;/details&gt;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>BillingDocumentListResponse</returns>
        public BillingDocumentListResponse GetBillingDocuments(string cursor, string zuoraTrackId, bool? async)
        {
            var path =$"v2/billing_documents";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.ExecuteRequest<BillingDocumentListResponse>(path, queryParams, postBody, true);
            return new BillingDocumentListResponse();
        }

        public BillingDocumentListResponse GetBillingDocumentsCached()
        {
            return new BillingDocumentListResponse
            {
                Data = _apiClient.RequestCachedResult<BillingDocument>()
            };
        }

        public BillingDocument GetBillingDocumentCached(string billingDocumentId) => _apiClient.RequestCachedResult<BillingDocument>(billingDocumentId);

        /// <summary>
        /// Create a billing document Creates different types of billing document objects, including invoices, credit memos, and debit memos.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;accountId&#x60;, &#x60;balance&#x60;, &#x60;description&#x60;, &#x60;state&#x60;, &#x60;tax&#x60;          &lt;/details&gt;</param>
        /// <param name="billingDocumentItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscriptionId&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;          &lt;/details&gt;</param>
        /// <param name="taxationItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>BillingDocument</returns>
        public BillingDocument PostBillingDocument(BillingDocumentCreateRequest body, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostBillingDocument");

            var path =$"v2/billing_documents";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (billingDocumentItemsFields != null) queryParams.Add("billing_document_items.fields[]", _apiClient.ParameterToString(billingDocumentItemsFields)); // query parameter
            //if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", _apiClient.ParameterToString(taxationItemsFields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<BillingDocument>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PostBillingDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PostBillingDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingDocument)_apiClient.Deserialize(response.Content, typeof(BillingDocument));
        }

    }
}