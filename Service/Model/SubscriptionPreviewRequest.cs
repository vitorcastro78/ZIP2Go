using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SubscriptionPreviewRequest {
    /// <summary>
    /// Identifier of the account that owns the invoice associated with this subscription. If you specify this field, do not specify `invoice_owner_account_data`.
    /// </summary>
    /// <value>Identifier of the account that owns the invoice associated with this subscription. If you specify this field, do not specify `invoice_owner_account_data`.</value>
    [DataMember(Name="invoice_owner_account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_owner_account_id")]
    public string InvoiceOwnerAccountId { get; set; }

    /// <summary>
    /// Identifier of the account that owns the invoice associated with this subscription. If you specify this field, do not specify `invoice_owner_account_data`.
    /// </summary>
    /// <value>Identifier of the account that owns the invoice associated with this subscription. If you specify this field, do not specify `invoice_owner_account_data`.</value>
    [DataMember(Name="invoice_owner_account_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_owner_account_number")]
    public string InvoiceOwnerAccountNumber { get; set; }

    /// <summary>
    /// The information of the new account that owns the invoice associated with this subscription. If you specify this field, do not specify `invoice_owner_account_id`.
    /// </summary>
    /// <value>The information of the new account that owns the invoice associated with this subscription. If you specify this field, do not specify `invoice_owner_account_id`.</value>
    [DataMember(Name="invoice_owner_account_data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_owner_account_data")]
    public AllOfsubscriptionPreviewRequestInvoiceOwnerAccountData InvoiceOwnerAccountData { get; set; }

    /// <summary>
    /// Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_data`.
    /// </summary>
    /// <value>Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_data`.</value>
    [DataMember(Name="account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_id")]
    public string AccountId { get; set; }

    /// <summary>
    /// Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_data`.
    /// </summary>
    /// <value>Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_data`.</value>
    [DataMember(Name="account_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or Sets AccountData
    /// </summary>
    [DataMember(Name="account_data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_data")]
    public SubscriptionPreviewAccountRequest AccountData { get; set; }

    /// <summary>
    /// If true, the subscription automatically renews at the end of the current term.
    /// </summary>
    /// <value>If true, the subscription automatically renews at the end of the current term.</value>
    [DataMember(Name="auto_renew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_renew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// Human-readable identifier of the subscription; maybe user-supplied.
    /// </summary>
    /// <value>Human-readable identifier of the subscription; maybe user-supplied.</value>
    [DataMember(Name="subscription_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_number")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// Initial term information for the subscription.
    /// </summary>
    /// <value>Initial term information for the subscription.</value>
    [DataMember(Name="initial_term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initial_term")]
    public AllOfsubscriptionPreviewRequestInitialTerm InitialTerm { get; set; }

    /// <summary>
    /// Renewal term information for the subscription
    /// </summary>
    /// <value>Renewal term information for the subscription</value>
    [DataMember(Name="renewal_term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewal_term")]
    public AllOfsubscriptionPreviewRequestRenewalTerm RenewalTerm { get; set; }

    /// <summary>
    /// Gets or Sets StartOn
    /// </summary>
    [DataMember(Name="start_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_on")]
    public StartOn StartOn { get; set; }

    /// <summary>
    /// Description of the subscription. Often useful for displaying to users.
    /// </summary>
    /// <value>Description of the subscription. Often useful for displaying to users.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Separates a single subscription from other subscriptions and creates an invoice for this subscription. If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice.
    /// </summary>
    /// <value>Separates a single subscription from other subscriptions and creates an invoice for this subscription. If the value is `true`, the subscription is billed separately from other subscriptions. If the value is `false`, the subscription is included with other subscriptions in the account invoice.</value>
    [DataMember(Name="invoice_separately", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_separately")]
    public bool? InvoiceSeparately { get; set; }

    /// <summary>
    /// Gets or Sets ProcessingOptions
    /// </summary>
    [DataMember(Name="processing_options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processing_options")]
    public ProcessingOptions ProcessingOptions { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public CustomFields CustomFields { get; set; }

    /// <summary>
    /// The plans associated with the new subscription.
    /// </summary>
    /// <value>The plans associated with the new subscription.</value>
    [DataMember(Name="subscription_plans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_plans")]
    public List<SubscriptionPlanCreateRequest> SubscriptionPlans { get; set; }

    /// <summary>
    /// ID of the bill-to contact.
    /// </summary>
    /// <value>ID of the bill-to contact.</value>
    [DataMember(Name="bill_to_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bill_to_id")]
    public string BillToId { get; set; }

    /// <summary>
    /// The name of payment term associated with the invoice.
    /// </summary>
    /// <value>The name of payment term associated with the invoice.</value>
    [DataMember(Name="payment_terms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_terms")]
    public string PaymentTerms { get; set; }

    /// <summary>
    /// The billing address for the customer.
    /// </summary>
    /// <value>The billing address for the customer.</value>
    [DataMember(Name="bill_to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bill_to")]
    public AllOfsubscriptionPreviewRequestBillTo BillTo { get; set; }

    /// <summary>
    /// The billing document settings for the customer.
    /// </summary>
    /// <value>The billing document settings for the customer.</value>
    [DataMember(Name="billing_document_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_document_settings")]
    public AllOfsubscriptionPreviewRequestBillingDocumentSettings BillingDocumentSettings { get; set; }

    /// <summary>
    /// ID of the sold-to contact.
    /// </summary>
    /// <value>ID of the sold-to contact.</value>
    [DataMember(Name="sold_to_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sold_to_id")]
    public string SoldToId { get; set; }

    /// <summary>
    /// The selling address for the customer.
    /// </summary>
    /// <value>The selling address for the customer.</value>
    [DataMember(Name="sold_to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sold_to")]
    public AllOfsubscriptionPreviewRequestSoldTo SoldTo { get; set; }

    /// <summary>
    /// 3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.
    /// </summary>
    /// <value>3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Specifies how many billing periods you want to preview.
    /// </summary>
    /// <value>Specifies how many billing periods you want to preview.</value>
    [DataMember(Name="number_of_periods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_periods")]
    public int? NumberOfPeriods { get; set; }

    /// <summary>
    /// Indicates whether to preview the subscription till the end of the current term.
    /// </summary>
    /// <value>Indicates whether to preview the subscription till the end of the current term.</value>
    [DataMember(Name="term_end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "term_end")]
    public bool? TermEnd { get; set; }

    /// <summary>
    /// Specifies the metrics you want to preview.    You can preivew metrics of billing documents, the order delta metrics, or both.
    /// </summary>
    /// <value>Specifies the metrics you want to preview.    You can preivew metrics of billing documents, the order delta metrics, or both.</value>
    [DataMember(Name="metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metrics")]
    public List<string> Metrics { get; set; }

    /// <summary>
    /// End date of the period for which you want to preview the subscription
    /// </summary>
    /// <value>End date of the period for which you want to preview the subscription</value>
    [DataMember(Name="end_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_date")]
    public DateTime? EndDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionPreviewRequest {\n");
      sb.Append("  InvoiceOwnerAccountId: ").Append(InvoiceOwnerAccountId).Append("\n");
      sb.Append("  InvoiceOwnerAccountNumber: ").Append(InvoiceOwnerAccountNumber).Append("\n");
      sb.Append("  InvoiceOwnerAccountData: ").Append(InvoiceOwnerAccountData).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  AccountData: ").Append(AccountData).Append("\n");
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
      sb.Append("  BillToId: ").Append(BillToId).Append("\n");
      sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
      sb.Append("  BillTo: ").Append(BillTo).Append("\n");
      sb.Append("  BillingDocumentSettings: ").Append(BillingDocumentSettings).Append("\n");
      sb.Append("  SoldToId: ").Append(SoldToId).Append("\n");
      sb.Append("  SoldTo: ").Append(SoldTo).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
      sb.Append("  TermEnd: ").Append(TermEnd).Append("\n");
      sb.Append("  Metrics: ").Append(Metrics).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
