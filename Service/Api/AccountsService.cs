﻿using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;
using EasyCaching.Core;

namespace Service
{
    /// <summary>
    /// Service responsible for managing accounts in the system.
    /// Provides methods for creating, updating, deleting, and querying accounts.
    /// </summary>
    public class AccountsService : IAccountsService
    {
        private readonly IEasyCachingProvider _cache;
        public readonly IApiClient _apiClient;
        private readonly List<string> expand;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public AccountsService(ApiClient apiClient, IEasyCachingProvider cache)
        {

            _apiClient = apiClient;
            _cache = cache;
            expand = new List<string>
                {
                    //"account.subscriptions",
                    //"account.subscription_plans",
                    //"account.subscription_items",
                    //"account.invoice_owner_account",
                    //"account.plan",
                    //"account.payment_methods",
                    //"account.payments",
                    //"account.billing_documents",
                    //"account.billing_document_items",
                    //"account.bill_to",
                    //"account.sold_to",
                    //"account.default_payment_method",
                    //"account.usage_records",
                    //"account.invoices",
                    //"account.credit_memos",
                    //"account.debit_memos"
                };
        }

       

        /// <summary>
        /// Gets or sets the API client used for making HTTP requests.
        /// </summary>
        /// <value>An instance of the ApiClient</value>

        /// <summary>
        /// Creates a new account in the system.
        /// </summary>
        /// <param name="body">Account data to be created</param>
        /// <param name="zuoraTrackId">Custom identifier for tracking API requests</param>
        /// <param name="async">Indicates if the operation should be asynchronous</param>
        /// <param name="expand">Relationships to expand in the response</param>
        /// <returns>The created account</returns>
        /// <exception cref="ApiException">Thrown when the API request fails</exception>
        public Account CreateAccount(AccountCreateRequest body, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAccount");

            var path = "v2/accounts";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            string PostBody = null;

            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
            PostBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Account>(path, Method.Post, queryParams, PostBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAccount: " + response.ErrorMessage, response.ErrorMessage);

            return (Account)_apiClient.Deserialize(response.Content, typeof(Account));
        }

        /// <summary>
        /// Deletes an existing account from the system.
        /// </summary>
        /// <remarks>This operation is permanent and cannot be undone.</remarks>
        /// <param name="accountId">ID of the account to be deleted</param>
        /// <param name="zuoraTrackId">Custom identifier for tracking API requests</param>
        /// <param name="async">Indicates if the operation should be asynchronous</param>
        /// <exception cref="ApiException">Thrown when the API request fails</exception>
        /// <exception cref="ArgumentNullException">Thrown when accountId is null or empty</exception>
        public void DeleteAccount(string accountId, string zuoraTrackId, bool? async)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentNullException(nameof(accountId), "Account ID cannot be null or empty");

            var path = "v2/accounts/{account_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", _apiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            string PostBody = null;

            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            try
            {
                // make the HTTP request
                RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Delete, queryParams, PostBody);

                if (((int)response.StatusCode) >= 400)
                    throw new ApiException((int)response.StatusCode, $"Error calling DeleteAccount: {response.Content}", response.Content);
                else if (((int)response.StatusCode) == 0)
                    throw new ApiException((int)response.StatusCode, $"Error calling DeleteAccount: {response.ErrorMessage}", response.ErrorMessage);
            }
            catch (Exception ex) when (ex is not ApiException)
            {
                throw new ApiException(500, "An unexpected error occurred while deleting the account", ex);
            }
        }

        /// <summary>
        /// Generate billing documents for an account Creates billing documents for an account.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accountId">Identifier for the account, either &#x60;account_number&#x60; or &#x60;account_id&#x60;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent Post or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>GenerateBillingDocumentsAccountResponse</returns>
        public GenerateBillingDocumentsAccountResponse GenerateBillingDocuments(GenerateBillingDocumentsAccountRequest body, string accountId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GenerateBillingDocuments");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GenerateBillingDocuments");

            var path = "v2/accounts/{account_id}/bill";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", _apiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string PostBody = null;

            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            PostBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<GenerateBillingDocumentsAccountResponse>(path, Method.Get, queryParams, PostBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GenerateBillingDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GenerateBillingDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return (GenerateBillingDocumentsAccountResponse)_apiClient.Deserialize(response.Content, typeof(GenerateBillingDocumentsAccountResponse));
        }

        /// <summary>
        public Account GetAccount(string accountId, string zuoraTrackId, bool? async)
        {
            //        private const string APIV2_GET_ALL_SUBSCRIPTIONS = "/v2/subscriptions?expand%5B%5D=account.bill_to&expand%5B%5D=account.sold_to&expand%5B%5D=subscription_plans.subscription_items&filter%5B%5D=Status.EQ:{0}&filter%5B%5D=InvoiceOwnerId.EQ:{1}&filter%5B%5D=latest_version.EQ:true&page_size=95"; // "/v2/subscriptions?expand%5B%5D=account.bill_to&expand%5B%5D=account.sold_to&expand%5B%5D=subscription_plans.subscription_items&filter%5B%5D=InvoiceOwnerId.EQ:{0}&filter%5B%5D=latest_version.EQ:true&page_size=95";

            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetAccount");

            var path = "v2/accounts/{account_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", _apiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter


            RestResponse response = (RestResponse)_apiClient.CallApi(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetProduct: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetProduct: " + response.ErrorMessage, response.ErrorMessage);

            return (Account)_apiClient.Deserialize(response.Content, typeof(Account));
        }

        public Account GetAccountCached(string accountId)
        {
            // make the HTTP request
            return _apiClient.RequestCachedResult<Account>(accountId);
        
        }

        /// <summary>
        /// List accounts Returns a dictionary with a data property that contains an array of accounts, starting after the cursor, if used. Each entry in the array is a separate account object. If no more accounts are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <param name="cursor">A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="sort">A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. &#x60;account_number.asc&#x60;) or descending (e.g. &#x60;account_number.desc&#x60;). You cannot sort on properties that are arrays. If the array-type properties are specified for the &#x60;sort[]&#x60; parameter, they are ignored.</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="subscriptionsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;subscription_number&#x60;, &#x60;state&#x60;, &#x60;account_id&#x60;, &#x60;invoice_owner_account_id&#x60;, &#x60;auto_renew&#x60;, &#x60;version&#x60;, &#x60;initial_term&#x60;, &#x60;current_term&#x60;, &#x60;renewal_term&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;description&#x60;, &#x60;contract_effective&#x60;, &#x60;service_activation&#x60;, &#x60;customer_acceptance&#x60;, &#x60;invoice_separately&#x60;, &#x60;latest_version&#x60;, &#x60;payment_terms&#x60;, &#x60;billing_document_settings&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;contracted_mrr&#x60;, &#x60;currency&#x60;, &#x60;cancel_reason&#x60;, &#x60;last_booking_date&#x60;, &#x60;order_number&#x60;          &lt;/details&gt;</param>
        /// <param name="subscriptionPlansFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;name&#x60;, &#x60;plan_id&#x60;, &#x60;subscription_id&#x60;, &#x60;product_id&#x60;          &lt;/details&gt;</param>
        /// <param name="subscriptionItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;tiers&#x60;, &#x60;subscription_item_number&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;charged_through_date&#x60;, &#x60;recurring&#x60;, &#x60;price_id&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;overage&#x60;, &#x60;subscription_plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;processed_through_date&#x60;, &#x60;active&#x60;, &#x60;state&#x60;, &#x60;unit_amount&#x60;, &#x60;amount&#x60;, &#x60;discount_amount&#x60;, &#x60;discount_percent&#x60;          &lt;/details&gt;</param>
        /// <param name="invoiceOwnerAccountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="planFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;name&#x60;, &#x60;active&#x60;, &#x60;description&#x60;, &#x60;plan_number&#x60;, &#x60;product_id&#x60;, &#x60;active_currencies&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentMethodsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt;</param>
        /// <param name="paymentsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;payment_number&#x60;, &#x60;payment_date&#x60;, &#x60;gateway_id&#x60;, &#x60;payment_method_id&#x60;, &#x60;payout_id&#x60;, &#x60;reference_id&#x60;, &#x60;second_reference_id&#x60;, &#x60;statement_descriptor_phone&#x60;, &#x60;state&#x60;, &#x60;statement_descriptor&#x60;, &#x60;account_id&#x60;, &#x60;amount&#x60;, &#x60;amount_applied&#x60;, &#x60;amount_refunded&#x60;, &#x60;remaining_balance&#x60;, &#x60;currency&#x60;, &#x60;description&#x60;, &#x60;authorization_id&#x60;, &#x60;external&#x60;, &#x60;gateway_order_id&#x60;, &#x60;gateway_reconciliation_status&#x60;, &#x60;gateway_reconciliation_reason&#x60;, &#x60;gateway_response&#x60;, &#x60;gateway_response_code&#x60;, &#x60;gateway_state&#x60;, &#x60;state_transitions&#x60;, &#x60;gateway_state_transitions&#x60;          &lt;/details&gt;</param>
        /// <param name="billingDocumentsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;balance&#x60;, &#x60;description&#x60;, &#x60;state&#x60;, &#x60;tax&#x60;          &lt;/details&gt;</param>
        /// <param name="billingDocumentItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;          &lt;/details&gt;</param>
        /// <param name="billToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt;</param>
        /// <param name="soldToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt;</param>
        /// <param name="defaultPaymentMethodFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;type&#x60;, &#x60;account_id&#x60;, &#x60;bank_identification_number&#x60;, &#x60;device_session_id&#x60;, &#x60;ip_address&#x60;, &#x60;maximum_payment_attempts&#x60;, &#x60;payment_retry_interval&#x60;, &#x60;state&#x60;, &#x60;use_default_retry_rule&#x60;, &#x60;existing_mandate&#x60;, &#x60;last_failed_sale_transaction_time&#x60;, &#x60;last_transaction_time&#x60;, &#x60;last_transaction_status&#x60;, &#x60;number_of_consecutive_failures&#x60;, &#x60;total_number_of_processed_payments&#x60;, &#x60;total_number_of_error_payments&#x60;, &#x60;billing_details&#x60;, &#x60;card&#x60;, &#x60;apple_pay&#x60;, &#x60;google_pay&#x60;, &#x60;ach_debit&#x60;, &#x60;cc_ref&#x60;, &#x60;paypal_adaptive&#x60;, &#x60;paypal_express_native&#x60;, &#x60;paypal_express&#x60;, &#x60;sepa_debit&#x60;, &#x60;betalings_debit&#x60;, &#x60;autogiro_debit&#x60;, &#x60;bacs_debit&#x60;, &#x60;au_becs_debit&#x60;, &#x60;nz_becs_debit&#x60;, &#x60;pad_debit&#x60;          &lt;/details&gt;</param>
        /// <param name="usageRecordsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;account_id&#x60;, &#x60;account_number&#x60;, &#x60;subscription_item_id&#x60;, &#x60;subscription_item_number&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_number&#x60;, &#x60;unit_of_measure&#x60;, &#x60;description&#x60;, &#x60;end_time&#x60;, &#x60;state&#x60;, &#x60;start_time&#x60;, &#x60;quantity&#x60;          &lt;/details&gt;</param>
        /// <param name="invoicesFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;Posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;currency&#x60;          &lt;/details&gt;</param>
        /// <param name="creditMemosFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;credit_memo_number&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;document_date&#x60;, &#x60;exclude_from_auto_apply_rules&#x60;, &#x60;Posted_by_id&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;invoice_id&#x60;, &#x60;reason_code&#x60;, &#x60;amount_refunded&#x60;, &#x60;bill_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;currency&#x60;          &lt;/details&gt;</param>
        /// <param name="debitMemosFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;debit_memo_number&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;account_id&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;document_date&#x60;, &#x60;Posted_by_id&#x60;, &#x60;state&#x60;, &#x60;reason_code&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;billing_document_settings&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;invoice_id&#x60;, &#x60;currency&#x60;          &lt;/details&gt;</param>
        /// <param name="prepaidBalanceFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;prepaid_UOM&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;total_balance&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt;</param>
        /// <param name="transactionsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;transaction_date&#x60;, &#x60;type&#x60;, &#x60;quantity&#x60;          &lt;/details&gt;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent Post or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>ListAccountResponse</returns>
        public ListAccountResponse GetAccounts(string zuoraTrackId, bool? async)
        {
            var path = "v2/accounts";
            path = path.Replace("{format}", "json");
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            //if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            return _apiClient.ExecuteRequest<ListAccountResponse>(path, queryParams, postBody);
        }

        /// <summary>
        /// Previews an account before creation.
        /// </summary>
        /// <param name="body">Account data to preview</param>
        /// <param name="accountId">ID of the account to preview</param>
        /// <param name="zuoraTrackId">Custom identifier for tracking API requests</param>
        /// <param name="async">Indicates if the operation should be asynchronous</param>
        /// <returns>Preview response containing account details</returns>
        /// <exception cref="ApiException">Thrown when the API request fails</exception>
        public AccountPreviewResponse PreviewAccount(AccountPreviewRequest body, string accountId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PreviewAccount");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling PreviewAccount");

            var path = "v2/accounts/{account_id}/preview";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", _apiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string PostBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            PostBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<AccountPreviewResponse>(path, Method.Post, queryParams, PostBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PreviewAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PreviewAccount: " + response.ErrorMessage, response.ErrorMessage);

            return (AccountPreviewResponse)_apiClient.Deserialize(response.Content, typeof(AccountPreviewResponse));
        }

        /// <summary>
        /// Updates an existing account's data.
        /// </summary>
        /// <param name="body">Updated account data</param>
        /// <param name="accountId">ID of the account to update</param>
        /// <param name="zuoraTrackId">Custom identifier for tracking API requests</param>
        /// <param name="async">Indicates if the operation should be asynchronous</param>
        /// <returns>The updated account</returns>
        /// <exception cref="ApiException">Thrown when the API request fails</exception>
        public Account UpdateAccount(AccountPatchRequest body, string accountId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateAccount");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateAccount");

            var path = "v2/accounts/{account_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", _apiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string PostBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            PostBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Account>(path, Method.Patch, queryParams, PostBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAccount: " + response.ErrorMessage, response.ErrorMessage);

            return (Account)_apiClient.Deserialize(response.Content, typeof(Account));
        }
    }
}