using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BillRun
    {
        /// <summary>
        /// Identifier of the customer account to bill.
        /// </summary>
        /// <value>Identifier of the customer account to bill.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Number of accounts billed from this bill run.
        /// </summary>
        /// <value>Number of accounts billed from this bill run.</value>
        [DataMember(Name = "accounts_processed")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accounts_processed")]
        public int? AccountsProcessed { get; set; }

        /// <summary>
        /// Identifier of the customer account batch to be included in this bill run.
        /// </summary>
        /// <value>Identifier of the customer account batch to be included in this bill run.</value>
        [DataMember(Name = "batches")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "batches")]
        public string Batches { get; set; }

        /// <summary>
        /// Human-readable identifier for this object.
        /// </summary>
        /// <value>Human-readable identifier for this object.</value>
        [DataMember(Name = "bill_run_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_run_number")]
        public string BillRunNumber { get; set; }

        /// <summary>
        /// The date and time on which this bill run starts.
        /// </summary>
        /// <value>The date and time on which this bill run starts.</value>
        [DataMember(Name = "bill_run_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_run_time")]
        public DateTime? BillRunTime { get; set; }

        /// <summary>
        /// Type of the charge to be excluded from the bill run.
        /// </summary>
        /// <value>Type of the charge to be excluded from the bill run.</value>
        [DataMember(Name = "charges_excluded")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "charges_excluded")]
        public string ChargesExcluded { get; set; }

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
        /// Number of credit memos generated from this bill run.
        /// </summary>
        /// <value>Number of credit memos generated from this bill run.</value>
        [DataMember(Name = "credit_memos_generated")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memos_generated")]
        public int? CreditMemosGenerated { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public CustomObject CustomObjects { get; set; }

        /// <summary>
        /// The day of the month to bill multiple customer accounts.
        /// </summary>
        /// <value>The day of the month to bill multiple customer accounts.</value>
        [DataMember(Name = "day_of_month")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "day_of_month")]
        public string DayOfMonth { get; set; }

        /// <summary>
        /// If set to `true`, invoices will be automatically emailed to customers.
        /// </summary>
        /// <value>If set to `true`, invoices will be automatically emailed to customers.</value>
        [DataMember(Name = "email")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public bool? Email { get; set; }

        /// <summary>
        /// If set to `false`, invoices for zero amounts will not be emailed to customers.
        /// </summary>
        /// <value>If set to `false`, invoices for zero amounts will not be emailed to customers.</value>
        [DataMember(Name = "email_zero_amount_invoices")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email_zero_amount_invoices")]
        public bool? EmailZeroAmountInvoices { get; set; }

        /// <summary>
        /// Unique identifier for this object.
        /// </summary>
        /// <value>Unique identifier for this object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The date displayed on the invoice.
        /// </summary>
        /// <value>The date displayed on the invoice.</value>
        [DataMember(Name = "invoice_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_date")]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// Number of invoices generated from this bill run.
        /// </summary>
        /// <value>Number of invoices generated from this bill run.</value>
        [DataMember(Name = "invoices_generated")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoices_generated")]
        public int? InvoicesGenerated { get; set; }

        /// <summary>
        /// Indicates whether the invoices have been automatically sent to customers.
        /// </summary>
        /// <value>Indicates whether the invoices have been automatically sent to customers.</value>
        [DataMember(Name = "invoices_sent")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoices_sent")]
        public bool? InvoicesSent { get; set; }

        /// <summary>
        /// The date when the last invoice was sent.
        /// </summary>
        /// <value>The date when the last invoice was sent.</value>
        [DataMember(Name = "last_invoice_sent_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "last_invoice_sent_time")]
        public DateTime? LastInvoiceSentTime { get; set; }

        /// <summary>
        /// The name of the bill run.
        /// </summary>
        /// <value>The name of the bill run.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether to automatically post a billing document after it is created.
        /// </summary>
        /// <value>Indicates whether to automatically post a billing document after it is created.</value>
        [DataMember(Name = "post")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "post")]
        public bool? Post { get; set; }

        /// <summary>
        /// If set to `true`, subscriptions will be automatically renewed.
        /// </summary>
        /// <value>If set to `true`, subscriptions will be automatically renewed.</value>
        [DataMember(Name = "renew")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renew")]
        public bool? Renew { get; set; }

        /// <summary>
        /// Status of the bill run.
        /// </summary>
        /// <value>Status of the bill run.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// All unbilled items on or before this date are included in this bill run.
        /// </summary>
        /// <value>All unbilled items on or before this date are included in this bill run.</value>
        [DataMember(Name = "target_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target_date")]
        public DateTime? TargetDate { get; set; }

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
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillRun {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Post: ").Append(Post).Append("\n");
            sb.Append("  Renew: ").Append(Renew).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  BillRunNumber: ").Append(BillRunNumber).Append("\n");
            sb.Append("  BillRunTime: ").Append(BillRunTime).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Batches: ").Append(Batches).Append("\n");
            sb.Append("  ChargesExcluded: ").Append(ChargesExcluded).Append("\n");
            sb.Append("  EmailZeroAmountInvoices: ").Append(EmailZeroAmountInvoices).Append("\n");
            sb.Append("  InvoicesSent: ").Append(InvoicesSent).Append("\n");
            sb.Append("  LastInvoiceSentTime: ").Append(LastInvoiceSentTime).Append("\n");
            sb.Append("  AccountsProcessed: ").Append(AccountsProcessed).Append("\n");
            sb.Append("  InvoicesGenerated: ").Append(InvoicesGenerated).Append("\n");
            sb.Append("  CreditMemosGenerated: ").Append(CreditMemosGenerated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}