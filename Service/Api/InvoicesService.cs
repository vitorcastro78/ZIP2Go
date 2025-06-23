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

        private List<string> expand;

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
        /// 
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
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
        ///  Retrieve a list of invoice items
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public void FillInvoicesItemsCache(string zuoraTrackId, bool async)
        {
            var path = $"v2/invoice_items";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var expand = new Expands().InvoiceItemsExpand;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            _apiClient.FillPersistentCache<InvoiceItemListResponse>(path, queryParams, null);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
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

              expand = new Expands().InvoicesExpand;

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