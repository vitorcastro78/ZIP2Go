using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Invoice
    {
        /// <summary>
        /// The account that owns the invoice. EXPANDABLE
        /// </summary>
        /// <value>The account that owns the invoice. EXPANDABLE</value>
        [DataMember(Name = "account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account")]
        public AllOfinvoiceAccount Account { get; set; }

        /// <summary>
        /// Identifier of the account that owns the invoice.
        /// </summary>
        /// <value>Identifier of the account that owns the invoice.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Human-readable identifier of the account that owns the invoice.
        /// </summary>
        /// <value>Human-readable identifier of the account that owns the invoice.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The total balance remaining.  This field is deprecated. Use `remaining_balance` field.
        /// </summary>
        /// <value>The total balance remaining.  This field is deprecated. Use `remaining_balance` field.</value>
        [DataMember(Name = "balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "balance")]
        public decimal? Balance { get; set; }

        /// <summary>
        /// The billing document settings for the customer.
        /// </summary>
        /// <value>The billing document settings for the customer.</value>
        [DataMember(Name = "billing_document_settings")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_settings")]
        public AllOfinvoiceBillingDocumentSettings BillingDocumentSettings { get; set; }

        /// <summary>
        /// The billing address for the customer.
        /// </summary>
        /// <value>The billing address for the customer.</value>
        [DataMember(Name = "bill_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_to")]
        public AllOfinvoiceBillTo BillTo { get; set; }

        /// <summary>
        /// ID of the bill-to contact.
        /// </summary>
        /// <value>ID of the bill-to contact.</value>
        [DataMember(Name = "bill_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_to_id")]
        public string BillToId { get; set; }

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
        /// 3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.
        /// </summary>
        /// <value>3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.</value>
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
        public OneOfinvoiceCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The date when the invoice takes effect.
        /// </summary>
        /// <value>The date when the invoice takes effect.</value>
        [DataMember(Name = "document_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_date")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// The date on which payment for the invoice is due.
        /// </summary>
        /// <value>The date on which payment for the invoice is due.</value>
        [DataMember(Name = "due_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "due_date")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// A human-readable identifier for the invoice; may be user-supplied.
        /// </summary>
        /// <value>A human-readable identifier for the invoice; may be user-supplied.</value>
        [DataMember(Name = "invoice_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// List of invoice items.
        /// </summary>
        /// <value>List of invoice items.</value>
        [DataMember(Name = "items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items")]
        public AllOfinvoiceItems Items { get; set; }

        /// <summary>
        /// Whether payment was successfully collected for this invoice. An invoice can be paid with a payment or a credit memo.
        /// </summary>
        /// <value>Whether payment was successfully collected for this invoice. An invoice can be paid with a payment or a credit memo.</value>
        [DataMember(Name = "paid")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paid")]
        public bool? Paid { get; set; }

        /// <summary>
        /// Whether payment is past due.
        /// </summary>
        /// <value>Whether payment is past due.</value>
        [DataMember(Name = "past_due")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "past_due")]
        public bool? PastDue { get; set; }

        /// <summary>
        /// Indicates whether the invoice is automatically picked up for processing in the corresponding payment run.
        /// </summary>
        /// <value>Indicates whether the invoice is automatically picked up for processing in the corresponding payment run.</value>
        [DataMember(Name = "pay")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pay")]
        public bool? Pay { get; set; }

        /// <summary>
        /// The name of payment term associated with the invoice.
        /// </summary>
        /// <value>The name of payment term associated with the invoice.</value>
        [DataMember(Name = "payment_terms")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_terms")]
        public string PaymentTerms { get; set; }

        /// <summary>
        /// Identifier of the Zuora user who posted the invoice.
        /// </summary>
        /// <value>Identifier of the Zuora user who posted the invoice.</value>
        [DataMember(Name = "posted_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "posted_by_id")]
        public string PostedById { get; set; }

        /// <summary>
        /// The total balance remaining.
        /// </summary>
        /// <value>The total balance remaining.</value>
        [DataMember(Name = "remaining_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_balance")]
        public decimal? RemainingBalance { get; set; }

        /// <summary>
        /// The selling address for the customer.
        /// </summary>
        /// <value>The selling address for the customer.</value>
        [DataMember(Name = "sold_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sold_to")]
        public AllOfinvoiceSoldTo SoldTo { get; set; }

        /// <summary>
        /// ID of the sold-to contact.
        /// </summary>
        /// <value>ID of the sold-to contact.</value>
        [DataMember(Name = "sold_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sold_to_id")]
        public string SoldToId { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        /// <value>The status of the invoice.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StateTransitions
        /// </summary>
        [DataMember(Name = "state_transitions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state_transitions")]
        public AllOfinvoiceStateTransitions StateTransitions { get; set; }

        /// <summary>
        /// The total amount exclusive of tax.
        /// </summary>
        /// <value>The total amount exclusive of tax.</value>
        [DataMember(Name = "subtotal")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// The total tax amount.
        /// </summary>
        /// <value>The total tax amount.</value>
        [DataMember(Name = "tax")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax")]
        public decimal? Tax { get; set; }

        /// <summary>
        /// The total amount.
        /// </summary>
        /// <value>The total amount.</value>
        [DataMember(Name = "total")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Whether to transfer to an external accounting system.
        /// </summary>
        /// <value>Whether to transfer to an external accounting system.</value>
        [DataMember(Name = "transfer_to_accounting")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transfer_to_accounting")]
        public bool? TransferToAccounting { get; set; }

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
            sb.Append("class Invoice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  TransferToAccounting: ").Append(TransferToAccounting).Append("\n");
            sb.Append("  Pay: ").Append(Pay).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  StateTransitions: ").Append(StateTransitions).Append("\n");
            sb.Append("  PostedById: ").Append(PostedById).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  PastDue: ").Append(PastDue).Append("\n");
            sb.Append("  BillToId: ").Append(BillToId).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  BillingDocumentSettings: ").Append(BillingDocumentSettings).Append("\n");
            sb.Append("  SoldToId: ").Append(SoldToId).Append("\n");
            sb.Append("  SoldTo: ").Append(SoldTo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}