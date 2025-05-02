using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionPlansService : ISubscriptionPlansService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlansService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionPlansService(ApiClient apiClient, IEasyCachingProvider cache)
        {
            if (apiClient == null) // use the default one in Configuration
           
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlansService"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionPlansService(string basePath)
        {
            this.ApiClient = new ApiClient(basePath, _cache);
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

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
        /// Retrieve a subscription plan Retrieves the subscription plan with the given ID.
        /// </summary>
        /// <param name="subscriptionPlanId">Suscription Plan Id</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;name&#x60;, &#x60;plan_id&#x60;, &#x60;subscription_id&#x60;, &#x60;product_id&#x60;          &lt;/details&gt;</param>
        /// <param name="subscriptionFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;subscription_number&#x60;, &#x60;state&#x60;, &#x60;account_id&#x60;, &#x60;invoice_owner_account_id&#x60;, &#x60;auto_renew&#x60;, &#x60;version&#x60;, &#x60;initial_term&#x60;, &#x60;current_term&#x60;, &#x60;renewal_term&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;description&#x60;, &#x60;contract_effective&#x60;, &#x60;service_activation&#x60;, &#x60;customer_acceptance&#x60;, &#x60;invoice_separately&#x60;, &#x60;latest_version&#x60;, &#x60;payment_terms&#x60;, &#x60;billing_document_settings&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;contracted_mrr&#x60;, &#x60;currency&#x60;, &#x60;cancel_reason&#x60;, &#x60;last_booking_date&#x60;, &#x60;order_number&#x60;          &lt;/details&gt;</param>
        /// <param name="subscriptionItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;tiers&#x60;, &#x60;subscription_item_number&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;charged_through_date&#x60;, &#x60;recurring&#x60;, &#x60;price_id&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;overage&#x60;, &#x60;subscription_plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;processed_through_date&#x60;, &#x60;active&#x60;, &#x60;state&#x60;, &#x60;unit_amount&#x60;, &#x60;amount&#x60;, &#x60;discount_amount&#x60;, &#x60;discount_percent&#x60;          &lt;/details&gt;</param>
        /// <param name="planFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;name&#x60;, &#x60;active&#x60;, &#x60;description&#x60;, &#x60;plan_number&#x60;, &#x60;product_id&#x60;, &#x60;active_currencies&#x60;          &lt;/details&gt;</param>
        /// <param name="productFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;active&#x60;, &#x60;name&#x60;, &#x60;type&#x60;, &#x60;sku&#x60;, &#x60;description&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="priceFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;tiers&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;revenue_recognition_rule&#x60;, &#x60;stacked_discount&#x60;, &#x60;recognized_revenue_accounting_code&#x60;, &#x60;deferred_revenue_accounting_code&#x60;, &#x60;accounting_code&#x60;, &#x60;recurring&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;taxable&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;min_quantity&#x60;, &#x60;max_quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;discount_level&#x60;, &#x60;overage&#x60;, &#x60;plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;apply_discount_to&#x60;, &#x60;prepayment&#x60;, &#x60;drawdown&#x60;, &#x60;discount_amounts&#x60;, &#x60;unit_amounts&#x60;, &#x60;discount_percent&#x60;, &#x60;amounts&#x60;          &lt;/details&gt;</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorial for detailed instructions.                         Note that the filters on this operation are only applicable to the related objects. For example, when you are calling the \&quot;Retrieve a billing document\&quot; operation, you can use the &#x60;filter[]&#x60; parameter on the related objects such as &#x60;filter[]&#x3D;items[account_id].EQ:8ad09e208858b5cf0188595208151c63&#x60;</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>SubscriptionPlan</returns>
        public SubscriptionPlan GetSubscriptionPlan(string subscriptionPlanId, List<string> fields, List<string> subscriptionFields, List<string> subscriptionItemsFields, List<string> planFields, List<string> productFields, List<string> accountFields, List<string> priceFields, List<string> expand, List<string> filter, int? pageSize, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'subscriptionPlanId' is set
            if (subscriptionPlanId == null) throw new ApiException(400, "Missing required parameter 'subscriptionPlanId' when calling GetSubscriptionPlan");

            var path = "/subscription_plans/{subscription_plan_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "subscription_plan_id" + "}", ApiClient.ParameterToString(subscriptionPlanId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (subscriptionFields != null) queryParams.Add("subscription.fields[]", ApiClient.ParameterToString(subscriptionFields)); // query parameter
            if (subscriptionItemsFields != null) queryParams.Add("subscription_items.fields[]", ApiClient.ParameterToString(subscriptionItemsFields)); // query parameter
            if (planFields != null) queryParams.Add("plan.fields[]", ApiClient.ParameterToString(planFields)); // query parameter
            if (productFields != null) queryParams.Add("product.fields[]", ApiClient.ParameterToString(productFields)); // query parameter
            // if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            if (priceFields != null) queryParams.Add("price.fields[]", ApiClient.ParameterToString(priceFields)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetSubscriptionPlan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetSubscriptionPlan: " + response.ErrorMessage, response.ErrorMessage);

            return (SubscriptionPlan)ApiClient.Deserialize(response.Content, typeof(SubscriptionPlan));
        }

        /// <summary>
        /// List subscription plans Returns a dictionary with a data property that contains an array of subscription plans, starting after cursor. Each entry in the array is a separate  object. If no more  are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <param name="cursor">A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list.</param>
        /// <param name="expand">Allows you to expand responses by including related object information in a single call. See the [Expand responses](https://developer.zuora.com/quickstart-api/tutorial/expand-responses/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="filter">A case-sensitive filter on the list. See the [Filter lists](https://developer.zuora.com/quickstart-api/tutorial/filter-lists/) section of the Quickstart API Tutorials for detailed instructions.</param>
        /// <param name="sort">A case-sensitive query parameter that specifies the sort order of the list, which can be either ascending (e.g. &#x60;account_number.asc&#x60;) or descending (e.g. &#x60;account_number.desc&#x60;). You cannot sort on properties that are arrays. If the array-type properties are specified for the &#x60;sort[]&#x60; parameter, they are ignored.</param>
        /// <param name="pageSize">The maximum number of results to return in a single page. If the specified &#x60;page_size&#x60; is less than 1 or greater than 99, Zuora will return a 400 error.</param>
        /// <param name="fields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;name&#x60;, &#x60;plan_id&#x60;, &#x60;subscription_id&#x60;, &#x60;product_id&#x60;          &lt;/details&gt;</param>
        /// <param name="subscriptionFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;subscription_number&#x60;, &#x60;state&#x60;, &#x60;account_id&#x60;, &#x60;invoice_owner_account_id&#x60;, &#x60;auto_renew&#x60;, &#x60;version&#x60;, &#x60;initial_term&#x60;, &#x60;current_term&#x60;, &#x60;renewal_term&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;description&#x60;, &#x60;contract_effective&#x60;, &#x60;service_activation&#x60;, &#x60;customer_acceptance&#x60;, &#x60;invoice_separately&#x60;, &#x60;latest_version&#x60;, &#x60;payment_terms&#x60;, &#x60;billing_document_settings&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;contracted_mrr&#x60;, &#x60;currency&#x60;, &#x60;cancel_reason&#x60;, &#x60;last_booking_date&#x60;, &#x60;order_number&#x60;          &lt;/details&gt;</param>
        /// <param name="subscriptionItemsFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;tiers&#x60;, &#x60;subscription_item_number&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;charged_through_date&#x60;, &#x60;recurring&#x60;, &#x60;price_id&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;overage&#x60;, &#x60;subscription_plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;processed_through_date&#x60;, &#x60;active&#x60;, &#x60;state&#x60;, &#x60;unit_amount&#x60;, &#x60;amount&#x60;, &#x60;discount_amount&#x60;, &#x60;discount_percent&#x60;          &lt;/details&gt;</param>
        /// <param name="planFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;name&#x60;, &#x60;active&#x60;, &#x60;description&#x60;, &#x60;plan_number&#x60;, &#x60;product_id&#x60;, &#x60;active_currencies&#x60;          &lt;/details&gt;</param>
        /// <param name="productFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;start_date&#x60;, &#x60;end_date&#x60;, &#x60;active&#x60;, &#x60;name&#x60;, &#x60;type&#x60;, &#x60;sku&#x60;, &#x60;description&#x60;          &lt;/details&gt;</param>
        /// <param name="accountFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;auto_pay&#x60;, &#x60;account_number&#x60;, &#x60;bill_to_id&#x60;, &#x60;sold_to_id&#x60;, &#x60;billing_document_settings&#x60;, &#x60;communication_profile_id&#x60;, &#x60;crm_id&#x60;, &#x60;sales_rep&#x60;, &#x60;parent_account_id&#x60;, &#x60;payment_gateway&#x60;, &#x60;payment_terms&#x60;, &#x60;remaining_credit_memo_balance&#x60;, &#x60;remaining_debit_memo_balance&#x60;, &#x60;remaining_invoice_balance&#x60;, &#x60;remaining_payment_balance&#x60;, &#x60;sequence_set_id&#x60;, &#x60;tax_certificate&#x60;, &#x60;batch&#x60;, &#x60;tax_identifier&#x60;, &#x60;bill_cycle_day&#x60;, &#x60;description&#x60;, &#x60;name&#x60;, &#x60;currency&#x60;, &#x60;default_payment_method_id&#x60;, &#x60;enabled&#x60;          &lt;/details&gt;</param>
        /// <param name="priceFields">Allows you to specify which fields are returned in the response.          &lt;details&gt;            &lt;summary&gt; Accepted values &lt;/summary&gt;              &#x60;custom_fields&#x60;, &#x60;created_by_id&#x60;, &#x60;updated_by_id&#x60;, &#x60;created_time&#x60;, &#x60;id&#x60;, &#x60;updated_time&#x60;, &#x60;tiers&#x60;, &#x60;charge_model&#x60;, &#x60;charge_type&#x60;, &#x60;name&#x60;, &#x60;description&#x60;, &#x60;revenue_recognition_rule&#x60;, &#x60;stacked_discount&#x60;, &#x60;recognized_revenue_accounting_code&#x60;, &#x60;deferred_revenue_accounting_code&#x60;, &#x60;accounting_code&#x60;, &#x60;recurring&#x60;, &#x60;start_event&#x60;, &#x60;tax_code&#x60;, &#x60;tax_inclusive&#x60;, &#x60;taxable&#x60;, &#x60;unit_of_measure&#x60;, &#x60;quantity&#x60;, &#x60;min_quantity&#x60;, &#x60;max_quantity&#x60;, &#x60;price_base_interval&#x60;, &#x60;discount_level&#x60;, &#x60;overage&#x60;, &#x60;plan_id&#x60;, &#x60;tiers_mode&#x60;, &#x60;apply_discount_to&#x60;, &#x60;prepayment&#x60;, &#x60;drawdown&#x60;, &#x60;discount_amounts&#x60;, &#x60;unit_amounts&#x60;, &#x60;discount_percent&#x60;, &#x60;amounts&#x60;          &lt;/details&gt;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="zuoraEntityIds">An entity ID. If you have Multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity or you do not have Multi-entity enabled, you do not need to set this header.</param>
        /// <param name="idempotencyKey">Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</param>
        /// <param name="acceptEncoding">Include a &#x60;accept-encoding: gzip&#x60; header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <param name="contentEncoding">Include a &#x60;content-encoding: gzip&#x60; header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</param>
        /// <returns>SubscriptionPlanListResponse</returns>
        public SubscriptionPlanListResponse GetSubscriptionPlans(string cursor, List<string> expand, List<string> filter, List<string> sort, int? pageSize, List<string> fields, List<string> subscriptionFields, List<string> subscriptionItemsFields, List<string> planFields, List<string> productFields, List<string> accountFields, List<string> priceFields, string zuoraTrackId, bool? async)
        {
            var path = "/subscription_plans";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, string>();
            var fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            // if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand)); // query parameter
            // if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter)); // query parameter
            // if (sort != null) queryParams.Add("sort[]", ApiClient.ParameterToString(sort)); // query parameter
            // if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
            // if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields)); // query parameter
            if (subscriptionFields != null) queryParams.Add("subscription.fields[]", ApiClient.ParameterToString(subscriptionFields)); // query parameter
            if (subscriptionItemsFields != null) queryParams.Add("subscription_items.fields[]", ApiClient.ParameterToString(subscriptionItemsFields)); // query parameter
            if (planFields != null) queryParams.Add("plan.fields[]", ApiClient.ParameterToString(planFields)); // query parameter
            if (productFields != null) queryParams.Add("product.fields[]", ApiClient.ParameterToString(productFields)); // query parameter
            // if (accountFields != null) queryParams.Add("account.fields[]", ApiClient.ParameterToString(accountFields)); // query parameter
            if (priceFields != null) queryParams.Add("price.fields[]", ApiClient.ParameterToString(priceFields)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetSubscriptionPlans: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetSubscriptionPlans: " + response.ErrorMessage, response.ErrorMessage);

            return (SubscriptionPlanListResponse)ApiClient.Deserialize(response.Content, typeof(SubscriptionPlanListResponse));
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
    }
}