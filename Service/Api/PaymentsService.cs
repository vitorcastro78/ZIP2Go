using RestSharp;
using Service.Interfaces;
using ZIP2GO.Client;
using ZIP2GO.Service.Models;

namespace ZIP2GO.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentsService : IPaymentsService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentsService(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsService"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsService(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Apply a payment Applies a payment to one or more invoices or debit memos.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="paymentId">Identifier for the payment, either &#x60;payment_number&#x60; or &#x60;payment_id&#x60;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;payment_number&#x60;, &#x60;payment_date&#x60;, &#x60;gateway_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reference_id&#x60;, &#x60;second_reference_id&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;statement_descriptor&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;amount_applied&#x60;, &#x60;amount_refunded&#x60;, &#x60;remaining_balance&#x60;, &#x60;currency&#x60;, &#x60;description&#x60;, &#x60;authorization_id&#x60;, &#x60;external&#x60;, &#x60;gateway_order_id&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;state_transitions&#x60;, &#x60;gateway_state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentMethodFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;, &#x60;id&#x60;, &#x60;state&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_item_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>Payment</returns>
        public Payment ApplyPayment(PaymentApplyUnapplyRequest body, string paymentId, string zuoraTrackId, bool? async, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding, List<string> fields, List<string> accountFields, List<string> paymentMethodFields, List<string> paymentAppliedToFields, List<string> paymentAppliedToItemsFields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ApplyPayment");
            // verify the required parameter 'paymentId' is set
            if (paymentId == null) throw new ApiException(400, "Missing required parameter 'paymentId' when calling ApplyPayment");

            var path = "/payments/{payment_id}/apply";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_id" + "}", ApiClient.ParameterToString(paymentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            if (paymentMethodFields != null) queryParams.Add("payment_method.fields[]", ApiClient.ParameterToString(paymentMethodFields)); // query parameter
            if (paymentAppliedToFields != null) queryParams.Add("payment_applied_to.fields[]", ApiClient.ParameterToString(paymentAppliedToFields)); // query parameter
            if (paymentAppliedToItemsFields != null) queryParams.Add("payment_applied_to_items.fields[]", ApiClient.ParameterToString(paymentAppliedToItemsFields)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
            if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds)); // header parameter
            if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey)); // header parameter
            if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding)); // header parameter
            if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ApplyPayment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ApplyPayment: " + response.ErrorMessage, response.ErrorMessage);

            return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment));
        }

        /// <summary>
        /// Cancel a payment Cancels an unapplied payment.
        /// </summary>
        /// <param name="paymentId">Identifier for the payment, either &#x60;payment_number&#x60; or &#x60;payment_id&#x60;</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;payment_number&#x60;, &#x60;payment_date&#x60;, &#x60;gateway_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reference_id&#x60;, &#x60;second_reference_id&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;statement_descriptor&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;amount_applied&#x60;, &#x60;amount_refunded&#x60;, &#x60;remaining_balance&#x60;, &#x60;currency&#x60;, &#x60;description&#x60;, &#x60;authorization_id&#x60;, &#x60;external&#x60;, &#x60;gateway_order_id&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;state_transitions&#x60;, &#x60;gateway_state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentMethodFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;, &#x60;id&#x60;, &#x60;state&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_item_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityId">An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>Payment</returns>
        public Payment CancelPayment(string paymentId, List<string> fields, List<string> accountFields, List<string> paymentMethodFields, List<string> paymentAppliedToFields, List<string> paymentAppliedToItemsFields, List<string> expand, List<string> filter, int? pageSize, string zuoraTrackId, bool? async, string zuoraEntityId, string idempotencyKey, string acceptEncoding, string contentEncoding)
        {
            // verify the required parameter 'paymentId' is set
            if (paymentId == null) throw new ApiException(400, "Missing required parameter 'paymentId' when calling CancelPayment");

            var path = "/payments/{payment_id}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_id" + "}", ApiClient.ParameterToString(paymentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            if (paymentMethodFields != null) queryParams.Add("payment_method.fields[]", ApiClient.ParameterToString(paymentMethodFields)); // query parameter
            if (paymentAppliedToFields != null) queryParams.Add("payment_applied_to.fields[]", ApiClient.ParameterToString(paymentAppliedToFields)); // query parameter
            if (paymentAppliedToItemsFields != null) queryParams.Add("payment_applied_to_items.fields[]", ApiClient.ParameterToString(paymentAppliedToItemsFields)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
            if (zuoraEntityId != null) headerParams.Add("zuora-entity-id", ApiClient.ParameterToString(zuoraEntityId)); // header parameter
            if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey)); // header parameter
            if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding)); // header parameter
            if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CancelPayment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CancelPayment: " + response.ErrorMessage, response.ErrorMessage);

            return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment));
        }

        /// <summary>
        /// Create a payment Creates a new payment object.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;payment_number&#x60;, &#x60;payment_date&#x60;, &#x60;gateway_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reference_id&#x60;, &#x60;second_reference_id&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;statement_descriptor&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;amount_applied&#x60;, &#x60;amount_refunded&#x60;, &#x60;remaining_balance&#x60;, &#x60;currency&#x60;, &#x60;description&#x60;, &#x60;authorization_id&#x60;, &#x60;external&#x60;, &#x60;gateway_order_id&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;state_transitions&#x60;, &#x60;gateway_state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentMethodFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;, &#x60;id&#x60;, &#x60;state&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_item_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>Payment</returns>
        public Payment CreatePayment(PaymentCreateRequest body, string zuoraTrackId, bool? async, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding, List<string> fields, List<string> accountFields, List<string> paymentMethodFields, List<string> paymentAppliedToFields, List<string> paymentAppliedToItemsFields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePayment");

            var path = "/payments";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            if (paymentMethodFields != null) queryParams.Add("payment_method.fields[]", ApiClient.ParameterToString(paymentMethodFields)); // query parameter
            if (paymentAppliedToFields != null) queryParams.Add("payment_applied_to.fields[]", ApiClient.ParameterToString(paymentAppliedToFields)); // query parameter
            if (paymentAppliedToItemsFields != null) queryParams.Add("payment_applied_to_items.fields[]", ApiClient.ParameterToString(paymentAppliedToItemsFields)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
            if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds)); // header parameter
            if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey)); // header parameter
            if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding)); // header parameter
            if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreatePayment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreatePayment: " + response.ErrorMessage, response.ErrorMessage);

            return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment));
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Retrieve a payment Retrieves the payment with the given ID.
        /// </summary>
        /// <param name="paymentId">Identifier for the payment, either &#x60;payment_number&#x60; or &#x60;payment_id&#x60;</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;payment_number&#x60;, &#x60;payment_date&#x60;, &#x60;gateway_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reference_id&#x60;, &#x60;second_reference_id&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;statement_descriptor&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;amount_applied&#x60;, &#x60;amount_refunded&#x60;, &#x60;remaining_balance&#x60;, &#x60;currency&#x60;, &#x60;description&#x60;, &#x60;authorization_id&#x60;, &#x60;external&#x60;, &#x60;gateway_order_id&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;state_transitions&#x60;, &#x60;gateway_state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentMethodFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;, &#x60;id&#x60;, &#x60;state&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_item_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>Payment</returns>
        public Payment GetPayment(string paymentId, List<string> fields, List<string> accountFields, List<string> paymentMethodFields, List<string> paymentAppliedToFields, List<string> paymentAppliedToItemsFields, List<string> expand, List<string> filter, int? pageSize, string zuoraTrackId, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding)
        {
            // verify the required parameter 'paymentId' is set
            if (paymentId == null) throw new ApiException(400, "Missing required parameter 'paymentId' when calling GetPayment");

            var path = "/payments/{payment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_id" + "}", ApiClient.ParameterToString(paymentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            if (paymentMethodFields != null) queryParams.Add("payment_method.fields[]", ApiClient.ParameterToString(paymentMethodFields)); // query parameter
            if (paymentAppliedToFields != null) queryParams.Add("payment_applied_to.fields[]", ApiClient.ParameterToString(paymentAppliedToFields)); // query parameter
            if (paymentAppliedToItemsFields != null) queryParams.Add("payment_applied_to_items.fields[]", ApiClient.ParameterToString(paymentAppliedToItemsFields)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds)); // header parameter
            if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey)); // header parameter
            if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding)); // header parameter
            if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetPayment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetPayment: " + response.ErrorMessage, response.ErrorMessage);

            return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment));
        }

        /// <summary>
        /// List payments Returns a dictionary with a data property that contains an array of payments, starting after the cursor, if used. Each entry in the array is a separate payment object. If no more payments are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <param name="cursor">A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="sort">A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. &#x60;account_number.asc&#x60;) or descending (e.g. &#x60;account_number.desc&#x60;). You cannot sort on properties that are arrays. If the array-type properties are specified for the &#x60;sort[]&#x60; parameter, they are ignored.</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;payment_number&#x60;, &#x60;payment_date&#x60;, &#x60;gateway_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reference_id&#x60;, &#x60;second_reference_id&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;statement_descriptor&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;amount_applied&#x60;, &#x60;amount_refunded&#x60;, &#x60;remaining_balance&#x60;, &#x60;currency&#x60;, &#x60;description&#x60;, &#x60;authorization_id&#x60;, &#x60;external&#x60;, &#x60;gateway_order_id&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;state_transitions&#x60;, &#x60;gateway_state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentMethodFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;, &#x60;id&#x60;, &#x60;state&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_item_id&#x60;          &lt;/details&gt;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>PaymentListResponse</returns>
        public PaymentListResponse GetPayments(string cursor, List<string> expand, List<string> filter, List<string> sort, int? pageSize, List<string> fields, List<string> accountFields, List<string> paymentMethodFields, List<string> paymentAppliedToFields, List<string> paymentAppliedToItemsFields, string zuoraTrackId, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding)
        {
            var path = "/payments";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (sort != null) queryParams.Add("sort[]", ApiClient.ParameterToString(sort)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            if (paymentMethodFields != null) queryParams.Add("payment_method.fields[]", ApiClient.ParameterToString(paymentMethodFields)); // query parameter
            if (paymentAppliedToFields != null) queryParams.Add("payment_applied_to.fields[]", ApiClient.ParameterToString(paymentAppliedToFields)); // query parameter
            if (paymentAppliedToItemsFields != null) queryParams.Add("payment_applied_to_items.fields[]", ApiClient.ParameterToString(paymentAppliedToItemsFields)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds)); // header parameter
            if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey)); // header parameter
            if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding)); // header parameter
            if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetPayments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetPayments: " + response.ErrorMessage, response.ErrorMessage);

            return (PaymentListResponse)ApiClient.Deserialize(response.Content, typeof(PaymentListResponse));
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Unapply a payment Unapplies an applied payment.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="paymentId">Identifier for the payment, either &#x60;payment_number&#x60; or &#x60;payment_id&#x60;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;payment_number&#x60;, &#x60;payment_date&#x60;, &#x60;gateway_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reference_id&#x60;, &#x60;second_reference_id&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;statement_descriptor&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;amount_applied&#x60;, &#x60;amount_refunded&#x60;, &#x60;remaining_balance&#x60;, &#x60;currency&#x60;, &#x60;description&#x60;, &#x60;authorization_id&#x60;, &#x60;external&#x60;, &#x60;gateway_order_id&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;state_transitions&#x60;, &#x60;gateway_state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentMethodFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;, &#x60;id&#x60;, &#x60;state&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_item_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>Payment</returns>
        public Payment UnapplyPayment(PaymentApplyUnapplyRequest body, string paymentId, string zuoraTrackId, bool? async, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding, List<string> fields, List<string> accountFields, List<string> paymentMethodFields, List<string> paymentAppliedToFields, List<string> paymentAppliedToItemsFields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UnapplyPayment");
            // verify the required parameter 'paymentId' is set
            if (paymentId == null) throw new ApiException(400, "Missing required parameter 'paymentId' when calling UnapplyPayment");

            var path = "/payments/{payment_id}/unapply";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_id" + "}", ApiClient.ParameterToString(paymentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            if (paymentMethodFields != null) queryParams.Add("payment_method.fields[]", ApiClient.ParameterToString(paymentMethodFields)); // query parameter
            if (paymentAppliedToFields != null) queryParams.Add("payment_applied_to.fields[]", ApiClient.ParameterToString(paymentAppliedToFields)); // query parameter
            if (paymentAppliedToItemsFields != null) queryParams.Add("payment_applied_to_items.fields[]", ApiClient.ParameterToString(paymentAppliedToItemsFields)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
            if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds)); // header parameter
            if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey)); // header parameter
            if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding)); // header parameter
            if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UnapplyPayment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UnapplyPayment: " + response.ErrorMessage, response.ErrorMessage);

            return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment));
        }

        /// <summary>
        /// Update a payment Updates the specified payment by setting the values of the parameters passed. Any parameters not provided will be left unchanged.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="paymentId">Identifier for the payment, either &#x60;payment_number&#x60; or &#x60;payment_id&#x60;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;payment_number&#x60;, &#x60;payment_date&#x60;, &#x60;gateway_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reference_id&#x60;, &#x60;second_reference_id&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;statement_descriptor&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;amount_applied&#x60;, &#x60;amount_refunded&#x60;, &#x60;remaining_balance&#x60;, &#x60;currency&#x60;, &#x60;description&#x60;, &#x60;authorization_id&#x60;, &#x60;external&#x60;, &#x60;gateway_order_id&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;state_transitions&#x60;, &#x60;gateway_state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentMethodFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;amount&#x60;, &#x60;billing_document_id&#x60;, &#x60;billing_document_type&#x60;, &#x60;id&#x60;, &#x60;state&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentAppliedToItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;id&#x60;, &#x60;amount&#x60;, &#x60;billing_document_item_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>Payment</returns>
        public Payment UpdatePayment(PaymentPatchRequest body, string paymentId, string zuoraTrackId, bool? async, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding, List<string> fields, List<string> accountFields, List<string> paymentMethodFields, List<string> paymentAppliedToFields, List<string> paymentAppliedToItemsFields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePayment");
            // verify the required parameter 'paymentId' is set
            if (paymentId == null) throw new ApiException(400, "Missing required parameter 'paymentId' when calling UpdatePayment");

            var path = "/payments/{payment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "payment_id" + "}", ApiClient.ParameterToString(paymentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            if (paymentMethodFields != null) queryParams.Add("payment_method.fields[]", ApiClient.ParameterToString(paymentMethodFields)); // query parameter
            if (paymentAppliedToFields != null) queryParams.Add("payment_applied_to.fields[]", ApiClient.ParameterToString(paymentAppliedToFields)); // query parameter
            if (paymentAppliedToItemsFields != null) queryParams.Add("payment_applied_to_items.fields[]", ApiClient.ParameterToString(paymentAppliedToItemsFields)); // query parameter
            if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async)); // header parameter
            if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds)); // header parameter
            if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey)); // header parameter
            if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding)); // header parameter
            if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdatePayment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdatePayment: " + response.ErrorMessage, response.ErrorMessage);

            return (Payment)ApiClient.Deserialize(response.Content, typeof(Payment));
        }
    }
}