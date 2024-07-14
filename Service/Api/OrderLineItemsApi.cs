using System;
using System.Collections.Generic;
using RestSharp;
using ZIP2Go.Client;
using ZIP2Go.Model;

namespace ZIP2Go.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrderLineItemsApi
    {
        /// <summary>
        /// Retrieve an order line item Use this operation to retrieve the detailed information about a specific order line item.
        /// </summary>
        /// <param name="orderLineItemId">Identifier for the order line item.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt;</param>
        /// <param name="lineItemFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt;</param>
        /// <param name="invoiceItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>OrderLineItem</returns>
        OrderLineItem GetOrderLineItem (string orderLineItemId, List<string> fields, List<string> lineItemFields, List<string> invoiceItemsFields, List<string> expand, List<string> filter, int? pageSize, string zuoraTrackId, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding);
        /// <summary>
        /// Update an order line item Use this operation to update the information of a specific order line item.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="orderLineItemId">Identifier for the order line item.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt;</param>
        /// <param name="lineItemFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt;</param>
        /// <param name="invoiceItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>OrderLineItem</returns>
        OrderLineItem PatchOrderLineItem (LineItemPatchRequest body, string orderLineItemId, string zuoraTrackId, bool? async, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding, List<string> fields, List<string> lineItemFields, List<string> invoiceItemsFields, List<string> expand, List<string> filter, int? pageSize);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderLineItemsApi : IOrderLineItemsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItemsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrderLineItemsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItemsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderLineItemsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
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
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Retrieve an order line item Use this operation to retrieve the detailed information about a specific order line item.
        /// </summary>
        /// <param name="orderLineItemId">Identifier for the order line item.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt;</param>
        /// <param name="lineItemFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt;</param>
        /// <param name="invoiceItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>OrderLineItem</returns>
        public OrderLineItem GetOrderLineItem (string orderLineItemId, List<string> fields, List<string> lineItemFields, List<string> invoiceItemsFields, List<string> expand, List<string> filter, int? pageSize, string zuoraTrackId, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding)
        {
            // verify the required parameter 'orderLineItemId' is set
            if (orderLineItemId == null) throw new ApiException(400, "Missing required parameter 'orderLineItemId' when calling GetOrderLineItem");
    
            var path = "/order_line_items/{order_line_item_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_line_item_id" + "}", ApiClient.ParameterToString(orderLineItemId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
 if (lineItemFields != null) queryParams.Add("line_item.fields[]", ApiClient.ParameterToString(lineItemFields)); // query parameter
 if (invoiceItemsFields != null) queryParams.Add("invoice_items.fields[]", ApiClient.ParameterToString(invoiceItemsFields)); // query parameter
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
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderLineItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrderLineItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OrderLineItem) ApiClient.Deserialize(response.Content, typeof(OrderLineItem));
        }
    
        /// <summary>
        /// Update an order line item Use this operation to update the information of a specific order line item.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="orderLineItemId">Identifier for the order line item.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt;</param>
        /// <param name="lineItemFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;total&#x60;, &#x60;subtotal&#x60;, &#x60;quantity_fulfilled&#x60;, &#x60;quantity_pending_fulfillment&#x60;, &#x60;unit_of_measure&#x60;, &#x60;accounting_code&#x60;, &#x60;adjustment_liability_account&#x60;, &#x60;unit_amount&#x60;, &#x60;target_date&#x60;, &#x60;billing_rule&#x60;, &#x60;contract_asset_account&#x60;, &#x60;contract_liability_account&#x60;, &#x60;description&#x60;, &#x60;discount_total&#x60;, &#x60;revenue&#x60;, &#x60;discount_unit_amount&#x60;, &#x60;discount_percent&#x60;, &#x60;category&#x60;, &#x60;name&#x60;, &#x60;item_number&#x60;, &#x60;type&#x60;, &#x60;list_price&#x60;, &#x60;list_unit_price&#x60;, &#x60;original_order_date&#x60;, &#x60;original_order_id&#x60;, &#x60;original_order_line_item_id&#x60;, &#x60;original_order_line_item_number&#x60;, &#x60;original_order_number&#x60;, &#x60;product_code&#x60;, &#x60;price_id&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;quantity_available_for_return&#x60;, &#x60;related_subscription_number&#x60;, &#x60;requires_fulfillment&#x60;, &#x60;sold_to_id&#x60;, &#x60;original_sold_to_id&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;end_date&#x60;, &#x60;start_date&#x60;, &#x60;unbilled_receivables_account&#x60;, &#x60;state&#x60;, &#x60;order_id&#x60;          &lt;/details&gt;</param>
        /// <param name="invoiceItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;amount&#x60;, &#x60;booking_reference&#x60;, &#x60;applied_to_item_id&#x60;, &#x60;price_id&#x60;, &#x60;discount_item&#x60;, &#x60;deferred_revenue_account&#x60;, &#x60;description&#x60;, &#x60;invoice_id&#x60;, &#x60;sku&#x60;, &#x60;name&#x60;, &#x60;purchase_order_number&#x60;, &#x60;quantity&#x60;, &#x60;recognized_revenue_account&#x60;, &#x60;remaining_balance&#x60;, &#x60;revenue_recognition_rule_name&#x60;, &#x60;accounting_code&#x60;, &#x60;service_end&#x60;, &#x60;service_start&#x60;, &#x60;accounts_receivable_account&#x60;, &#x60;subscription_id&#x60;, &#x60;subscription_item_id&#x60;, &#x60;tax&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_amount&#x60;, &#x60;unit_of_measure&#x60;, &#x60;document_item_date&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <returns>OrderLineItem</returns>
        public OrderLineItem PatchOrderLineItem (LineItemPatchRequest body, string orderLineItemId, string zuoraTrackId, bool? async, string zuoraEntityIds, string idempotencyKey, string acceptEncoding, string contentEncoding, List<string> fields, List<string> lineItemFields, List<string> invoiceItemsFields, List<string> expand, List<string> filter, int? pageSize)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchOrderLineItem");
            // verify the required parameter 'orderLineItemId' is set
            if (orderLineItemId == null) throw new ApiException(400, "Missing required parameter 'orderLineItemId' when calling PatchOrderLineItem");
    
            var path = "/order_line_items/{order_line_item_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "order_line_item_id" + "}", ApiClient.ParameterToString(orderLineItemId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
 if (lineItemFields != null) queryParams.Add("line_item.fields[]", ApiClient.ParameterToString(lineItemFields)); // query parameter
 if (invoiceItemsFields != null) queryParams.Add("invoice_items.fields[]", ApiClient.ParameterToString(invoiceItemsFields)); // query parameter
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
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchOrderLineItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchOrderLineItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OrderLineItem) ApiClient.Deserialize(response.Content, typeof(OrderLineItem));
        }
    
    }
}
