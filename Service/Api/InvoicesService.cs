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
    public class InvoicesService : IInvoicesService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public InvoicesService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().InvoicesExpand;
            filter = new List<string>
                {
                    "state.EQ:posted",
                };
        }


        /// <summary>
        /// Cancel an invoice Cancels an invoice. Only the invoice with the &#x60;draft&#x60; status can be canceled.
        /// </summary>
        /// <param name="invoiceId">Identifier for the invoices, either &#x60;invoice_number&#x60; or &#x60;invoiceId&#x60;</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;state&#x60;, &#x60;balance&#x60;, &#x60;due_date&#x60;, &#x60;invoice_number&#x60;, &#x60;posted_by_id&#x60;, &#x60;state_transitions&#x60;, &#x60;description&#x60;, &#x60;accountId&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;tax&#x60;, &#x60;paid&#x60;, &#x60;past_due&#x60;, &#x60;document_date&#x60;, &#x60;amount_paid&#x60;, &#x60;amount_refunded&#x60;, &#x60;payment_terms&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;currency&#x60;          &lt;/details&gt;</param>
        /// <param name="invoiceItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoiceId&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscriptionId&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt;</param>
        /// <param name="taxationItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;amount_exempt&#x60;, &#x60;tax_date&#x60;, &#x60;jurisdiction&#x60;, &#x60;location_code&#x60;, &#x60;name&#x60;, &#x60;sales_tax_payable_account&#x60;, &#x60;tax_code&#x60;, &#x60;tax_code_name&#x60;, &#x60;tax_rate&#x60;, &#x60;tax_rate_name&#x60;, &#x60;tax_inclusive&#x60;, &#x60;tax_rate_type&#x60;, &#x60;amount_credited&#x60;, &#x60;amount_paid&#x60;, &#x60;remaining_balance&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="billToFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;accountId&#x60;, &#x60;address&#x60;, &#x60;home_phone&#x60;, &#x60;first_name&#x60;, &#x60;last_name&#x60;, &#x60;email&#x60;, &#x60;work_email&#x60;, &#x60;nickname&#x60;, &#x60;other_phone&#x60;, &#x60;work_phone&#x60;, &#x60;mobile_phone&#x60;, &#x60;tax_region&#x60;, &#x60;other_phone_type&#x60;, &#x60;fax&#x60;          &lt;/details&gt;</param>
        /// <param name="lineItemFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[accountId].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityId">An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>Invoice</returns>
        public Invoice CancelInvoice(string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling CancelInvoice");

            var path =$"v2/invoices/{invoiceId}/cancel";
            
            path = path.Replace("{" + "invoiceId" + "}", _apiClient.ParameterToString(invoiceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;


            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Invoice>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CancelInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CancelInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (Invoice)_apiClient.Deserialize(response.Content, typeof(Invoice));
        }

        /// <summary>
        /// Create an invoice Creates an invoice for the specified account. The invoice is created with the &#x60;draft&#x60; status. You can then post the invoice to change its status to &#x60;posted&#x60;. If you want to create a posted invoice, you can use the [Create Posted Invoice](https://developer.zuora.com/api-reference/quickstart-api/tag/Invoices/operation/CreatePostedInvoice/) operation.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public Invoice CreateInvoice(InvoiceCreateRequest body, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateInvoice");

            var path =$"v2/invoices";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Invoice>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (Invoice)_apiClient.Deserialize(response.Content, typeof(Invoice));
        }


        /// <summary>
        /// Delete an invoice Deletes an invoice. Only the invoice with the &#x60;draft&#x60; status can be deleted. If you want to delete a posted invoice, you can use the [Delete Posted Invoice](https://developer.zuora.com/api-reference/quickstart-api/tag/Invoices/operation/DeletePostedInvoice/) operation.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <exception cref="ApiException"></exception>
        public void DeleteInvoice(string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling DeleteInvoice");

            var path =$"v2/invoices/{invoiceId}";
            
            path = path.Replace("{" + "invoiceId" + "}", _apiClient.ParameterToString(invoiceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;


            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Invoice>(path, Method.Delete, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Email an invoice Emails an invoice to the account&#39;s email address. The email is sent to the &#x60;bill_to&#x60; contact by default. If you want to send the email to the &#x60;sold_to&#x60; contact, you can use the [Email Posted Invoice](https://developer.zuora.com/api-reference/quickstart-api/tag/Invoices/operation/EmailPostedInvoice/) operation.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <exception cref="ApiException"></exception>
        public void EmailInvoice(string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling EmailInvoice");

            var path =$"v2/invoices/{invoiceId}/email";
            
            path = path.Replace("{" + "invoiceId" + "}", _apiClient.ParameterToString(invoiceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
                                                                                              // if (zuoraEntityId != null) headerParams.Add("zuora-entity-id", ApiClient.ParameterToString(zuoraEntityId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Invoice>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling EmailInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling EmailInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }


        /// <summary>
        ///     Get an invoice Retrieves information about a specific invoice. You can use either the &#x60;invoice_number&#x60; or the &#x60;invoiceId&#x60; to identify the invoice. If you want to retrieve a posted invoice, you can use the [Retrieve Posted Invoice](https://developer.zuora.com/api-reference/quickstart-api/tag/Invoices/operation/RetrievePostedInvoice/) operation.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public Invoice GetInvoice(string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling GetInvoice");

            var path =$"v2/invoices/{invoiceId}";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
           
            // make the HTTP request
            return _apiClient.ExecuteRequest<Invoice>(path, queryParams, postBody);
        }


        /// <summary>
        ///  Retrieve a list of invoice items
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public InvoiceItemListResponse GetInvoiceItems( string zuoraTrackId, bool? async)
        {
            var path =$"v2/invoice_items";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (cursor != null) queryParams.Add("cursor", _apiClient.ParameterToString(cursor)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (sort != null) queryParams.Add("sort[]", ApiClient.ParameterToString(sort)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            // if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", ApiClient.ParameterToString(taxationItemsFields)); // query parameter
            // if (lineItemFields != null) queryParams.Add("line_item.fields[]", _apiClient.ParameterToString(lineItemFields)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<InvoiceItemListResponse>(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoiceItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoiceItems: " + response.ErrorMessage, response.ErrorMessage);

            return (InvoiceItemListResponse)_apiClient.Deserialize(response.Content, typeof(InvoiceItemListResponse));
        }

        /// <summary>
        /// Retrieve a list of invoices
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public InvoiceListResponse GetInvoices( string zuoraTrackId, bool? async)
        {
            var path =$"v2/invoices";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (cursor != null) queryParams.Add("cursor", _apiClient.ParameterToString(cursor)); // query parameter
            //if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //if (sort != null) queryParams.Add("sort[]", ApiClient.ParameterToString(sort)); // query parameter
            //if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            //if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (invoiceItemsFields != null) queryParams.Add("invoice_items.fields[]", _apiClient.ParameterToString(invoiceItemsFields)); // query parameter
            //if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", _apiClient.ParameterToString(taxationItemsFields)); // query parameter
            //if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            //if (billToFields != null) queryParams.Add("bill_to.fields[]", _apiClient.ParameterToString(billToFields)); // query parameter
            //if (lineItemFields != null) queryParams.Add("line_item.fields[]", _apiClient.ParameterToString(lineItemFields)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<InvoiceListResponse>(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetInvoices: " + response.ErrorMessage, response.ErrorMessage);

            return (InvoiceListResponse)_apiClient.Deserialize(response.Content, typeof(InvoiceListResponse));
        }

        public void FillInvoicesCache(string zuoraTrackId, bool async)
        {
            var path = $"v2/invoices";
            
            
            filter = new List<string>
                {
                    "state.EQ:posted",
                };

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

            string postBody = null;

            if (expand.Any()) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter.Any()) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            _apiClient.FillPersistentCache<InvoiceListResponse>(path, queryParams, postBody);

        }


        /// <summary>
        /// Patch an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public Invoice PatchInvoice(InvoicePatchRequest body, string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchInvoice");
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling PatchInvoice");

            var path =$"v2/invoices/{invoiceId}";
            
            path = path.Replace("{" + "invoiceId" + "}", _apiClient.ParameterToString(invoiceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (invoiceItemsFields != null) queryParams.Add("invoice_items.fields[]", _apiClient.ParameterToString(invoiceItemsFields)); // query parameter
            //if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", _apiClient.ParameterToString(taxationItemsFields)); // query parameter
            //if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            //if (billToFields != null) queryParams.Add("bill_to.fields[]", _apiClient.ParameterToString(billToFields)); // query parameter
            //if (lineItemFields != null) queryParams.Add("line_item.fields[]", _apiClient.ParameterToString(lineItemFields)); // query parameter
            //if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Invoice>(path, Method.Patch, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PatchInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PatchInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (Invoice)_apiClient.Deserialize(response.Content, typeof(Invoice));
        }

        /// <summary>
        /// Pay an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public Invoice PayInvoice(PayInvoiceRequest body, string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PayInvoice");
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling PayInvoice");

            var path =$"v2/invoices/{invoiceId}/pay";
            
            path = path.Replace("{" + "invoiceId" + "}", _apiClient.ParameterToString(invoiceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (invoiceItemsFields != null) queryParams.Add("invoice_items.fields[]", _apiClient.ParameterToString(invoiceItemsFields)); // query parameter
            //if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", _apiClient.ParameterToString(taxationItemsFields)); // query parameter
            //if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            //if (billToFields != null) queryParams.Add("bill_to.fields[]", _apiClient.ParameterToString(billToFields)); // query parameter
            //if (lineItemFields != null) queryParams.Add("line_item.fields[]", _apiClient.ParameterToString(lineItemFields)); // query parameter
            //if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            //if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Invoice>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PayInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PayInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (Invoice)_apiClient.Deserialize(response.Content, typeof(Invoice));
        }

        /// <summary>
        /// Post an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public Invoice PostInvoice(string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling PostInvoice");

            var path =$"v2/invoices/{invoiceId}/post";
            
            path = path.Replace("{" + "invoiceId" + "}", _apiClient.ParameterToString(invoiceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (invoiceItemsFields != null) queryParams.Add("invoice_items.fields[]", _apiClient.ParameterToString(invoiceItemsFields)); // query parameter
            //if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", _apiClient.ParameterToString(taxationItemsFields)); // query parameter
            //if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            //if (billToFields != null) queryParams.Add("bill_to.fields[]", _apiClient.ParameterToString(billToFields)); // query parameter
            //if (lineItemFields != null) queryParams.Add("line_item.fields[]", _apiClient.ParameterToString(lineItemFields)); // query parameter
            //if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
                                                                                              // if (zuoraEntityId != null) headerParams.Add("zuora-entity-id", ApiClient.ParameterToString(zuoraEntityId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Invoice>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PostInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PostInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (Invoice)_apiClient.Deserialize(response.Content, typeof(Invoice));
        }

        /// <summary>
        /// Reverse an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public Invoice ReverseInvoice(InvoiceReverseRequest body, string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReverseInvoice");
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling ReverseInvoice");

            var path =$"v2/invoices/{invoiceId}/reverse";
            
            path = path.Replace("{" + "invoiceId" + "}", _apiClient.ParameterToString(invoiceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (invoiceItemsFields != null) queryParams.Add("invoice_items.fields[]", _apiClient.ParameterToString(invoiceItemsFields)); // query parameter
            //if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", _apiClient.ParameterToString(taxationItemsFields)); // query parameter
            //if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            //if (billToFields != null) queryParams.Add("bill_to.fields[]", _apiClient.ParameterToString(billToFields)); // query parameter
            //if (lineItemFields != null) queryParams.Add("line_item.fields[]", _apiClient.ParameterToString(lineItemFields)); // query parameter
            //if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Invoice>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ReverseInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ReverseInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (Invoice)_apiClient.Deserialize(response.Content, typeof(Invoice));
        }



        /// <summary>
        /// Unpost an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public Invoice UnpostInvoice(string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling UnpostInvoice");

            var path =$"v2/invoices/{invoiceId}/unpost";
            
            path = path.Replace("{" + "invoiceId" + "}", _apiClient.ParameterToString(invoiceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (invoiceItemsFields != null) queryParams.Add("invoice_items.fields[]", _apiClient.ParameterToString(invoiceItemsFields)); // query parameter
            //if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", _apiClient.ParameterToString(taxationItemsFields)); // query parameter
            //if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            //if (billToFields != null) queryParams.Add("bill_to.fields[]", _apiClient.ParameterToString(billToFields)); // query parameter
            //if (lineItemFields != null) queryParams.Add("line_item.fields[]", _apiClient.ParameterToString(lineItemFields)); // query parameter
            //if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
                                                                                              // if (zuoraEntityId != null) headerParams.Add("zuora-entity-id", ApiClient.ParameterToString(zuoraEntityId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Invoice>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UnpostInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UnpostInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (Invoice)_apiClient.Deserialize(response.Content, typeof(Invoice));
        }

        /// <summary>
        /// Write off an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public CreditMemo WriteOffInvoice(WriteOffRequest body, string invoiceId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling WriteOffInvoice");
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling WriteOffInvoice");

            var path =$"v2/invoices/{invoiceId}/write-off";
            
            path = path.Replace("{" + "invoiceId" + "}", _apiClient.ParameterToString(invoiceId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            //if (appliedToFields != null) queryParams.Add("applied_to.fields[]", _apiClient.ParameterToString(appliedToFields)); // query parameter
            //if (creditMemoItemsFields != null) queryParams.Add("credit_memo_items.fields[]", _apiClient.ParameterToString(creditMemoItemsFields)); // query parameter
            //if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", _apiClient.ParameterToString(taxationItemsFields)); // query parameter
            //if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            //if (billToFields != null) queryParams.Add("bill_to.fields[]", _apiClient.ParameterToString(billToFields)); // query parameter
            //if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            //if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling WriteOffInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling WriteOffInvoice: " + response.ErrorMessage, response.ErrorMessage);

            return (CreditMemo)_apiClient.Deserialize(response.Content, typeof(CreditMemo));
        }

        /// <summary>
        /// /// Get a list of invoices from cache
        /// </summary>
        /// <returns></returns>
        public InvoiceListResponse GetInvoicesCached()
        {
            return new InvoiceListResponse
            {
                Data = _apiClient.RequestCachedResult<Invoice>()
            };
        }


        /// <summary>
        /// /// Get an invoice from cache
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public Invoice GetInvoiceCached(string invoiceId)
        {
            return _apiClient.RequestCachedResult<Invoice>(invoiceId); 
        }

        /// <summary>
        /// /// Get a list of invoice items from cache
        /// </summary>
        /// <returns></returns>
        public InvoiceItemListResponse GetInvoiceItemsCached()
        {
            return new InvoiceItemListResponse
            {
                Data = _apiClient.RequestCachedResult<InvoiceItem>()
            };
        }

        /// <summary>
        /// /// Get an invoice item from cache  
        /// </summary>
        /// <param name="invoiceItemId"></param>
        /// <returns></returns>
        public InvoiceItem GetInvoiceItemCached(string invoiceItemId) => _apiClient.RequestCachedResult<InvoiceItem>(invoiceItemId);


        /// <summary>
        /// /// Get a list of invoices by account ID
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
		public InvoiceListResponse GetInvoicesByAccountId(string accountId, string zuoraTrackId, bool? async)
		{

			filter = new List<string>
				{
					$"account_id.EQ:{accountId}",
					"state.EQ:posted",
				};

			var path = $"v2/invoices";
			

			var queryParams = new Dictionary<string, string>();
			var headerParams = new Dictionary<string, string>();


			string postBody = null;

			if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
			if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
			if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
			if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

			var response = _apiClient.CallApi<InvoiceListResponse>(path, Method.Get, queryParams, postBody, true);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode, "Error calling GetSubscriptionByKey: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode, "Error calling GetSubscriptionByKey: " + response.ErrorMessage, response.ErrorMessage);

			return (InvoiceListResponse)_apiClient.Deserialize(response.Content, typeof(InvoiceListResponse));
		}

        /// <summary>
        /// /// Get a list of invoices from cache by account ID
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
		public InvoiceListResponse GetInvoicesCachedByAccountId(string accountId)
		{
			var invoice = new InvoiceListResponse
			{
				Data = _apiClient.RequestCachedResult<Invoice>()
			};

			invoice.Data = invoice.Data.Where(s => s.AccountId == accountId).ToList();

			return invoice;
		}
	}
}