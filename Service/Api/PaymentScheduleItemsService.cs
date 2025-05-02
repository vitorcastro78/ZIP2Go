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
    public class PaymentScheduleItemsService : IPaymentScheduleItemsService
    {
        private readonly IEasyCachingProvider _cache;
        public readonly ApiClient _apiClient;
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentScheduleItemsService(ApiClient apiClient, IEasyCachingProvider cache)
        {

            _apiClient = apiClient;
            _cache = cache;
        }


        /// <summary>
        /// Cancel a payment schedule item Cancels the payment schedule item with the given ID.
        /// </summary>
        /// <param name="paymentScheduleItemId">Identifier for the payment schedule item. Can be either &#x60;payment_schedule_item_id&#x60; or &#x60;payment_schedule_item_number&#x60;</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentScheduleFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityId">An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>PaymentScheduleItem</returns>
        public PaymentScheduleItem CancelPaymentScheduleItem(string paymentScheduleItemId, List<string> fields, List<string> paymentScheduleFields, List<string> expand, List<string> filter, int? pageSize, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'paymentScheduleItemId' is set
            if (paymentScheduleItemId == null) throw new ApiException(400, "Missing required parameter 'paymentScheduleItemId' when calling CancelPaymentScheduleItem");

            var path = "/payment_schedule_items/{payment_schedule_item_id}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_schedule_item_id" + "}", _apiClient.ParameterToString(paymentScheduleItemId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (paymentScheduleFields != null) queryParams.Add("payment_schedule.fields[]", _apiClient.ParameterToString(paymentScheduleFields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
                                                                                              // if (zuoraEntityId != null) headerParams.Add("zuora-entity-id", ApiClient.ParameterToString(zuoraEntityId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CancelPaymentScheduleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CancelPaymentScheduleItem: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentScheduleItem)_apiClient.Deserialize(response.Content, typeof(PaymentScheduleItem));
        }

        /// <summary>
        /// Create a payment schedule item Creates a new Payment Schedule Item object.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentScheduleFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>PaymentScheduleItem</returns>
        public PaymentScheduleItem CreatePaymentScheduleItem(PaymentScheduleItemCreateRequest body, string zuoraTrackId, bool? async, List<string> fields, List<string> paymentScheduleFields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePaymentScheduleItem");

            var path = "/payment_schedule_items";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (paymentScheduleFields != null) queryParams.Add("payment_schedule.fields[]", _apiClient.ParameterToString(paymentScheduleFields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreatePaymentScheduleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreatePaymentScheduleItem: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentScheduleItem)_apiClient.Deserialize(response.Content, typeof(PaymentScheduleItem));
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
        /// Retrieve a payment schedule item Retrieves the payment schedule item with the given ID.
        /// </summary>
        /// <param name="paymentScheduleItemId">Identifier for the payment schedule item. Can be either &#x60;payment_schedule_item_id&#x60; or &#x60;payment_schedule_item_number&#x60;</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentScheduleFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>PaymentScheduleItem</returns>
        public PaymentScheduleItem GetPaymentScheduleItem(string paymentScheduleItemId, List<string> fields, List<string> paymentScheduleFields, List<string> expand, List<string> filter, int? pageSize, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'paymentScheduleItemId' is set
            if (paymentScheduleItemId == null) throw new ApiException(400, "Missing required parameter 'paymentScheduleItemId' when calling GetPaymentScheduleItem");

            var path = "/payment_schedule_items/{payment_schedule_item_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_schedule_item_id" + "}", _apiClient.ParameterToString(paymentScheduleItemId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (paymentScheduleFields != null) queryParams.Add("payment_schedule.fields[]", _apiClient.ParameterToString(paymentScheduleFields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetPaymentScheduleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetPaymentScheduleItem: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentScheduleItem)_apiClient.Deserialize(response.Content, typeof(PaymentScheduleItem));
        }

        /// <summary>
        /// Retry a payment shedule item Retries the payment schedule item with the given ID.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="paymentScheduleItemId">Identifier for the payment schedule item. Can be either &#x60;payment_schedule_item_id&#x60; or &#x60;payment_schedule_item_number&#x60;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentScheduleFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>PaymentScheduleItem</returns>
        public PaymentScheduleItem RetryPaymentScheduleItem(PaymentScheduleItemRetry body, string paymentScheduleItemId, string zuoraTrackId, bool? async, List<string> fields, List<string> paymentScheduleFields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RetryPaymentScheduleItem");
            // verify the required parameter 'paymentScheduleItemId' is set
            if (paymentScheduleItemId == null) throw new ApiException(400, "Missing required parameter 'paymentScheduleItemId' when calling RetryPaymentScheduleItem");

            var path = "/payment_schedule_items/{payment_schedule_item_id}/retry";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_schedule_item_id" + "}", _apiClient.ParameterToString(paymentScheduleItemId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (paymentScheduleFields != null) queryParams.Add("payment_schedule.fields[]", _apiClient.ParameterToString(paymentScheduleFields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling RetryPaymentScheduleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling RetryPaymentScheduleItem: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentScheduleItem)_apiClient.Deserialize(response.Content, typeof(PaymentScheduleItem));
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

        /// <summary>
        /// Skip a payment schedule item Skips the payment schedule item with the given ID.
        /// </summary>
        /// <param name="paymentScheduleItemId">Identifier for the payment schedule item. Can be either &#x60;payment_schedule_item_id&#x60; or &#x60;payment_schedule_item_number&#x60;</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentScheduleFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityId">An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>PaymentScheduleItem</returns>
        public PaymentScheduleItem SkipPaymentScheduleItem(string paymentScheduleItemId, List<string> fields, List<string> paymentScheduleFields, List<string> expand, List<string> filter, int? pageSize, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'paymentScheduleItemId' is set
            if (paymentScheduleItemId == null) throw new ApiException(400, "Missing required parameter 'paymentScheduleItemId' when calling SkipPaymentScheduleItem");

            var path = "/payment_schedule_items/{payment_schedule_item_id}/skip";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_schedule_item_id" + "}", _apiClient.ParameterToString(paymentScheduleItemId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (paymentScheduleFields != null) queryParams.Add("payment_schedule.fields[]", _apiClient.ParameterToString(paymentScheduleFields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
                                                                                              // if (zuoraEntityId != null) headerParams.Add("zuora-entity-id", ApiClient.ParameterToString(zuoraEntityId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling SkipPaymentScheduleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling SkipPaymentScheduleItem: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentScheduleItem)_apiClient.Deserialize(response.Content, typeof(PaymentScheduleItem));
        }

        /// <summary>
        /// Update a payment schedule item Updates the specified payment schedule item by setting the values of the parameters passed. Any parameters not provided will remain unchanged.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="paymentScheduleItemId">Identifier for the payment schedule item. Can be either &#x60;payment_schedule_item_id&#x60; or &#x60;payment_schedule_item_number&#x60;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;balance&#x60;, &#x60;currency&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;, &#x60;payment_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;description&#x60;, &#x60;prepayment&#x60;, &#x60;payment_gateway_id&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;scheduled_date&#x60;, &#x60;payment_schedule_item_number&#x60;, &#x60;payment_schedule_id&#x60;, &#x60;cancellation_reason&#x60;, &#x60;error_message&#x60;, &#x60;payment_option_id&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentScheduleFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;description&#x60;, &#x60;next_payment_date&#x60;, &#x60;payment_schedule_number&#x60;, &#x60;number_of_payments&#x60;, &#x60;prepayment&#x60;, &#x60;start_date&#x60;, &#x60;run_hour&#x60;, &#x60;state&#x60;, &#x60;recent_payment_date&#x60;, &#x60;total_payments_errored&#x60;, &#x60;total_payments_processed&#x60;, &#x60;total_amount&#x60;, &#x60;debit_memo_id&#x60;, &#x60;invoice_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>PaymentScheduleItem</returns>
        public PaymentScheduleItem UpdatePaymentScheduleItem(PaymentScheduleItemPatch body, string paymentScheduleItemId, string zuoraTrackId, bool? async, List<string> fields, List<string> paymentScheduleFields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePaymentScheduleItem");
            // verify the required parameter 'paymentScheduleItemId' is set
            if (paymentScheduleItemId == null) throw new ApiException(400, "Missing required parameter 'paymentScheduleItemId' when calling UpdatePaymentScheduleItem");

            var path = "/payment_schedule_items/{payment_schedule_item_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_schedule_item_id" + "}", _apiClient.ParameterToString(paymentScheduleItemId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (paymentScheduleFields != null) queryParams.Add("payment_schedule.fields[]", _apiClient.ParameterToString(paymentScheduleFields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Patch, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdatePaymentScheduleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdatePaymentScheduleItem: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentScheduleItem)_apiClient.Deserialize(response.Content, typeof(PaymentScheduleItem));
        }
    }
}