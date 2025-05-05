using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// The account data.
    /// </summary>
    [DataContract]
    public class Account
    {
        /// <summary>
        /// Human-readable identifier of the account. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the account. It can be user-supplied.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Controls whether future payments are automatically billed when they are due.
        /// </summary>
        /// <value>Controls whether future payments are automatically billed when they are due.</value>
        [DataMember(Name = "auto_pay")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auto_pay")]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The identifier of a bill run batch.
        /// </summary>
        /// <value>The identifier of a bill run batch.</value>
        [DataMember(Name = "batch")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "batch")]
        public string Batch { get; set; }

        /// <summary>
        /// The day of the month on which your customer will be invoiced. For month-end specify 31.
        /// </summary>
        /// <value>The day of the month on which your customer will be invoiced. For month-end specify 31.</value>
        [DataMember(Name = "bill_cycle_day")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_cycle_day")]
        public int? BillCycleDay { get; set; }

        /// <summary>
        /// List of customer billing documents.
        /// </summary>
        /// <value>List of customer billing documents.</value>
        [DataMember(Name = "billing_documents")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_documents")]
        public AllOfaccountBillingDocuments BillingDocuments { get; set; }

        /// <summary>
        /// Gets or Sets BillingDocumentSettings
        /// </summary>
        [DataMember(Name = "billing_document_settings")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_settings")]
        public BillingDocumentSettings BillingDocumentSettings { get; set; }

        /// <summary>
        /// Customer billing address.
        /// </summary>
        /// <value>Customer billing address.</value>
        [DataMember(Name = "bill_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_to")]
        public AllOfaccountBillTo BillTo { get; set; }

        /// <summary>
        /// Customer billing address.
        /// </summary>
        /// <value>Customer billing address.</value>
        [DataMember(Name = "bill_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_to_id")]
        public string BillToId { get; set; }

        /// <summary>
        /// Identifier of the communication profile associated with this customer.
        /// </summary>
        /// <value>Identifier of the communication profile associated with this customer.</value>
        [DataMember(Name = "communication_profile_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "communication_profile_id")]
        public string CommunicationProfileId { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public string CreatedById { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// List of credit memo
        /// </summary>
        /// <value>List of credit memo</value>
        [DataMember(Name = "credit_memos")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memos")]
        public AllOfaccountCreditMemos CreditMemos { get; set; }

        /// <summary>
        /// CRM account identifier.
        /// </summary>
        /// <value>CRM account identifier.</value>
        [DataMember(Name = "crm_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "crm_id")]
        public string CrmId { get; set; }

        /// <summary>
        /// Three-letter ISO currency code. Once the currency is set for an account, it cannot be updated.
        /// </summary>
        /// <value>Three-letter ISO currency code. Once the currency is set for an account, it cannot be updated.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public OneOfaccountCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// List of debit memo
        /// </summary>
        /// <value>List of debit memo</value>
        [DataMember(Name = "debit_memos")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "debit_memos")]
        public AllOfaccountDebitMemos DebitMemos { get; set; }

        /// <summary>
        /// The default payment method for the customer.
        /// </summary>
        /// <value>The default payment method for the customer.</value>
        [DataMember(Name = "default_payment_method")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "default_payment_method")]
        public AllOfaccountDefaultPaymentMethod DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Identifier of the default payment method on the customer account.
        /// </summary>
        /// <value>Identifier of the default payment method on the customer account.</value>
        [DataMember(Name = "default_payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "default_payment_method_id")]
        public string DefaultPaymentMethodId { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Usually used to disable the customer account. The default is true. If false, attempts to create subscriptions for the customer account will fail.
        /// </summary>
        /// <value>Usually used to disable the customer account. The default is true. If false, attempts to create subscriptions for the customer account will fail.</value>
        [DataMember(Name = "enabled")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// List of invoices
        /// </summary>
        /// <value>List of invoices</value>
        [DataMember(Name = "invoices")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoices")]
        public AllOfaccountInvoices Invoices { get; set; }

        /// <summary>
        /// The name of the customer account.
        /// </summary>
        /// <value>The name of the customer account.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Identifier of this customer's parent account, if any.
        /// </summary>
        /// <value>Identifier of this customer's parent account, if any.</value>
        [DataMember(Name = "parent_account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parent_account_id")]
        public string ParentAccountId { get; set; }

        /// <summary>
        /// Payment gateway name.
        /// </summary>
        /// <value>Payment gateway name.</value>
        [DataMember(Name = "payment_gateway")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_gateway")]
        public string PaymentGateway { get; set; }

        /// <summary>
        /// List of customer payment methods.
        /// </summary>
        /// <value>List of customer payment methods.</value>
        [DataMember(Name = "payment_methods")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_methods")]
        public AllOfaccountPaymentMethods PaymentMethods { get; set; }

        /// <summary>
        /// List of customer payments.
        /// </summary>
        /// <value>List of customer payments.</value>
        [DataMember(Name = "payments")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payments")]
        public AllOfaccountPayments Payments { get; set; }

        /// <summary>
        /// Payment terms configured in **Billing Settings > Payment Terms** of your Zuora tenant.
        /// </summary>
        /// <value>Payment terms configured in **Billing Settings > Payment Terms** of your Zuora tenant.</value>
        [DataMember(Name = "payment_terms")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_terms")]
        public string PaymentTerms { get; set; }

        /// <summary>
        /// Total remaining balance of all posted credit memos.
        /// </summary>
        /// <value>Total remaining balance of all posted credit memos.</value>
        [DataMember(Name = "remaining_credit_memo_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_credit_memo_balance")]
        public decimal? RemainingCreditMemoBalance { get; set; }

        /// <summary>
        /// Total remaining balance of all posted debit memos.
        /// </summary>
        /// <value>Total remaining balance of all posted debit memos.</value>
        [DataMember(Name = "remaining_debit_memo_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_debit_memo_balance")]
        public decimal? RemainingDebitMemoBalance { get; set; }

        /// <summary>
        /// Total remaining balance of all posted invoices.
        /// </summary>
        /// <value>Total remaining balance of all posted invoices.</value>
        [DataMember(Name = "remaining_invoice_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_invoice_balance")]
        public decimal? RemainingInvoiceBalance { get; set; }

        /// <summary>
        /// Total remaining balance of all posted payments.
        /// </summary>
        /// <value>Total remaining balance of all posted payments.</value>
        [DataMember(Name = "remaining_payment_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_payment_balance")]
        public decimal? RemainingPaymentBalance { get; set; }

        /// <summary>
        /// The name of the sales representative associated with this account
        /// </summary>
        /// <value>The name of the sales representative associated with this account</value>
        [DataMember(Name = "sales_rep")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sales_rep")]
        public string SalesRep { get; set; }

        /// <summary>
        /// The identifier or the billing document sequence set that is assigned to the customer account.
        /// </summary>
        /// <value>The identifier or the billing document sequence set that is assigned to the customer account.</value>
        [DataMember(Name = "sequence_set_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sequence_set_id")]
        public string SequenceSetId { get; set; }

        /// <summary>
        /// Customer address used for calculating tax.
        /// </summary>
        /// <value>Customer address used for calculating tax.</value>
        [DataMember(Name = "sold_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sold_to")]
        public AllOfaccountSoldTo SoldTo { get; set; }

        /// <summary>
        /// Customer address used for calculating tax.
        /// </summary>
        /// <value>Customer address used for calculating tax.</value>
        [DataMember(Name = "sold_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sold_to_id")]
        public string SoldToId { get; set; }

        /// <summary>
        /// List of customer subscriptions.
        /// </summary>
        /// <value>List of customer subscriptions.</value>
        [DataMember(Name = "subscriptions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptions")]
        public AllOfaccountSubscriptions Subscriptions { get; set; }

        /// <summary>
        /// Gets or Sets TaxCertificate
        /// </summary>
        [DataMember(Name = "tax_certificate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_certificate")]
        public TaxCertificate TaxCertificate { get; set; }

        /// <summary>
        /// Gets or Sets TaxIdentifier
        /// </summary>
        [DataMember(Name = "tax_identifier")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_identifier")]
        public TaxIdentifier TaxIdentifier { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public string UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// List of customer usages.
        /// </summary>
        /// <value>List of customer usages.</value>
        [DataMember(Name = "usage_records")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usage_records")]
        public AllOfaccountUsageRecords UsageRecords { get; set; }

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
            sb.Append("class Account {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  BillingDocumentSettings: ").Append(BillingDocumentSettings).Append("\n");
            sb.Append("  Batch: ").Append(Batch).Append("\n");
            sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  SoldTo: ").Append(SoldTo).Append("\n");
            sb.Append("  CommunicationProfileId: ").Append(CommunicationProfileId).Append("\n");
            sb.Append("  CrmId: ").Append(CrmId).Append("\n");
            sb.Append("  DefaultPaymentMethodId: ").Append(DefaultPaymentMethodId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
            sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
            sb.Append("  SequenceSetId: ").Append(SequenceSetId).Append("\n");
            sb.Append("  AutoPay: ").Append(AutoPay).Append("\n");
            sb.Append("  TaxCertificate: ").Append(TaxCertificate).Append("\n");
            sb.Append("  TaxIdentifier: ").Append(TaxIdentifier).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SalesRep: ").Append(SalesRep).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  RemainingDebitMemoBalance: ").Append(RemainingDebitMemoBalance).Append("\n");
            sb.Append("  RemainingInvoiceBalance: ").Append(RemainingInvoiceBalance).Append("\n");
            sb.Append("  RemainingCreditMemoBalance: ").Append(RemainingCreditMemoBalance).Append("\n");
            sb.Append("  RemainingPaymentBalance: ").Append(RemainingPaymentBalance).Append("\n");
            sb.Append("  BillToId: ").Append(BillToId).Append("\n");
            sb.Append("  SoldToId: ").Append(SoldToId).Append("\n");
            sb.Append("  DefaultPaymentMethod: ").Append(DefaultPaymentMethod).Append("\n");
            sb.Append("  BillingDocuments: ").Append(BillingDocuments).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  UsageRecords: ").Append(UsageRecords).Append("\n");
            sb.Append("  CreditMemos: ").Append(CreditMemos).Append("\n");
            sb.Append("  DebitMemos: ").Append(DebitMemos).Append("\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}