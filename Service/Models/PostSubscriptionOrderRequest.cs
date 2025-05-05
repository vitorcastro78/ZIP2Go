using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PostSubscriptionOrderRequest
    {
        /// <summary>
        /// The information of the new account that owns the subscription. The subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_id`.
        /// </summary>
        /// <value>The information of the new account that owns the subscription. The subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_id`.</value>
        [DataMember(Name = "account_data")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_data")]
        public AllOfpostSubscriptionOrderRequestAccountData AccountData { get; set; }

        /// <summary>
        /// Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_data`.
        /// </summary>
        /// <value>Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_data`.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_data`.
        /// </summary>
        /// <value>Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_data`.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Specify this field if you want to add one or multiple subscription plans to this subscription.
        /// </summary>
        /// <value>Specify this field if you want to add one or multiple subscription plans to this subscription.</value>
        [DataMember(Name = "add_subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "add_subscription_plans")]
        public List<SubscriptionAddPlanPatchRequest> AddSubscriptionPlans { get; set; }

        /// <summary>
        /// If true, the subscription automatically renews at the end of the current term.
        /// </summary>
        /// <value>If true, the subscription automatically renews at the end of the current term.</value>
        [DataMember(Name = "auto_renew")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auto_renew")]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The billing document settings for the customer.
        /// </summary>
        /// <value>The billing document settings for the customer.</value>
        [DataMember(Name = "billing_document_settings")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_settings")]
        public AllOfpostSubscriptionOrderRequestBillingDocumentSettings BillingDocumentSettings { get; set; }

        /// <summary>
        /// ID of the bill-to contact.
        /// </summary>
        /// <value>ID of the bill-to contact.</value>
        [DataMember(Name = "bill_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_to_id")]
        public string BillToId { get; set; }

        /// <summary>
        /// Gets or Sets Cancel
        /// </summary>
        [DataMember(Name = "cancel")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancel")]
        public CancelSubscriptionRequest Cancel { get; set; }

        /// <summary>
        /// 3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.
        /// </summary>
        /// <value>3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Description of the subscription. Often useful for displaying to users.
        /// </summary>
        /// <value>Description of the subscription. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Initial term information for the subscription.
        /// </summary>
        /// <value>Initial term information for the subscription.</value>
        [DataMember(Name = "initial_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initial_term")]
        public AllOfpostSubscriptionOrderRequestInitialTerm InitialTerm { get; set; }

        /// <summary>
        /// Identifier of the account that owns the invoice associated with this subscription. If you specify this field, do not specify `invoice_owner_account_data`.
        /// </summary>
        /// <value>Identifier of the account that owns the invoice associated with this subscription. If you specify this field, do not specify `invoice_owner_account_data`.</value>
        [DataMember(Name = "invoice_owner_account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_owner_account_number")]
        public string InvoiceOwnerAccountNumber { get; set; }

        /// <summary>
        /// Separates a single subscription from other subscriptions and creates an invoice for this subscription. If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice.
        /// </summary>
        /// <value>Separates a single subscription from other subscriptions and creates an invoice for this subscription. If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice.</value>
        [DataMember(Name = "invoice_separately")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_separately")]
        public bool? InvoiceSeparately { get; set; }

        /// <summary>
        /// Gets or Sets Pause
        /// </summary>
        [DataMember(Name = "pause")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pause")]
        public PauseSubscriptionRequest Pause { get; set; }

        /// <summary>
        /// The name of payment term associated with the invoice.
        /// </summary>
        /// <value>The name of payment term associated with the invoice.</value>
        [DataMember(Name = "payment_terms")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_terms")]
        public string PaymentTerms { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingOptions
        /// </summary>
        [DataMember(Name = "processing_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processing_options")]
        public ProcessingOptions ProcessingOptions { get; set; }

        /// <summary>
        /// Specify this field if you want to remove one or multiple subscription plans from this subscription.
        /// </summary>
        /// <value>Specify this field if you want to remove one or multiple subscription plans from this subscription.</value>
        [DataMember(Name = "remove_subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remove_subscription_plans")]
        public List<SubscriptionRemovePlanPatchRequest> RemoveSubscriptionPlans { get; set; }

        /// <summary>
        /// Gets or Sets Renew
        /// </summary>
        [DataMember(Name = "renew")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renew")]
        public SubscriptionRenewPatchRequest Renew { get; set; }

        /// <summary>
        /// Specify this field when renewing a subscription.
        /// </summary>
        /// <value>Specify this field when renewing a subscription.</value>
        [DataMember(Name = "renewals")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewals")]
        public List<SubscriptionRenewPatchRequest> Renewals { get; set; }

        /// <summary>
        /// Renewal term information for the subscription
        /// </summary>
        /// <value>Renewal term information for the subscription</value>
        [DataMember(Name = "renewal_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewal_term")]
        public AllOfpostSubscriptionOrderRequestRenewalTerm RenewalTerm { get; set; }

        /// <summary>
        /// Specify this field if you want to replace one or multiple subscription plans to this subscription. <br />            **Note**: This field is currently not supported if you have Billing - Revenue Integration enabled. When Billing - Revenue Integration is enabled, the replace subscription plan type of order action will no longer be applicable in Zuora Billing.
        /// </summary>
        /// <value>Specify this field if you want to replace one or multiple subscription plans to this subscription. <br />            **Note**: This field is currently not supported if you have Billing - Revenue Integration enabled. When Billing - Revenue Integration is enabled, the replace subscription plan type of order action will no longer be applicable in Zuora Billing. </value>
        [DataMember(Name = "replace_subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replace_subscription_plans")]
        public List<SubscriptionReplacePlanPatchRequest> ReplaceSubscriptionPlans { get; set; }

        /// <summary>
        /// Gets or Sets Resume
        /// </summary>
        [DataMember(Name = "resume")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resume")]
        public ResumeSubscriptionRequest Resume { get; set; }

        /// <summary>
        /// ID of the sold-to contact.
        /// </summary>
        /// <value>ID of the sold-to contact.</value>
        [DataMember(Name = "sold_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sold_to_id")]
        public string SoldToId { get; set; }

        /// <summary>
        /// Gets or Sets StartOn
        /// </summary>
        [DataMember(Name = "start_on")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_on")]
        public StartOn StartOn { get; set; }

        /// <summary>
        /// Human-readable identifier of the subscription. If an existing `subscription_number` is supplied, the order will update that subscription. Meanwhile, if the specified `subscription_number` does not exist in the tenant, it will instead create a new one
        /// </summary>
        /// <value>Human-readable identifier of the subscription. If an existing `subscription_number` is supplied, the order will update that subscription. Meanwhile, if the specified `subscription_number` does not exist in the tenant, it will instead create a new one</value>
        [DataMember(Name = "subscription_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_number")]
        public string SubscriptionNumber { get; set; }

        /// <summary>
        /// The plans associated with the new subscription.
        /// </summary>
        /// <value>The plans associated with the new subscription.</value>
        [DataMember(Name = "subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plans")]
        public List<SubscriptionPlanCreateRequest> SubscriptionPlans { get; set; }

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name = "terms")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "terms")]
        public SubscriptionTermPatchRequest Terms { get; set; }

        /// <summary>
        /// Gets or Sets UpdateSubscriptionPlans
        /// </summary>
        [DataMember(Name = "update_subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "update_subscription_plans")]
        public List<SubscriptionUpdatePlanPatchRequest> UpdateSubscriptionPlans { get; set; }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostSubscriptionOrderRequest {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountData: ").Append(AccountData).Append("\n");
            sb.Append("  InvoiceOwnerAccountNumber: ").Append(InvoiceOwnerAccountNumber).Append("\n");
            sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
            sb.Append("  InitialTerm: ").Append(InitialTerm).Append("\n");
            sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InvoiceSeparately: ").Append(InvoiceSeparately).Append("\n");
            sb.Append("  ProcessingOptions: ").Append(ProcessingOptions).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  SubscriptionPlans: ").Append(SubscriptionPlans).Append("\n");
            sb.Append("  AddSubscriptionPlans: ").Append(AddSubscriptionPlans).Append("\n");
            sb.Append("  RemoveSubscriptionPlans: ").Append(RemoveSubscriptionPlans).Append("\n");
            sb.Append("  UpdateSubscriptionPlans: ").Append(UpdateSubscriptionPlans).Append("\n");
            sb.Append("  Renew: ").Append(Renew).Append("\n");
            sb.Append("  Renewals: ").Append(Renewals).Append("\n");
            sb.Append("  Cancel: ").Append(Cancel).Append("\n");
            sb.Append("  Pause: ").Append(Pause).Append("\n");
            sb.Append("  Resume: ").Append(Resume).Append("\n");
            sb.Append("  ReplaceSubscriptionPlans: ").Append(ReplaceSubscriptionPlans).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  BillToId: ").Append(BillToId).Append("\n");
            sb.Append("  SoldToId: ").Append(SoldToId).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
            sb.Append("  BillingDocumentSettings: ").Append(BillingDocumentSettings).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}