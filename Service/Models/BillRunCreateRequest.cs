using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BillRunCreateRequest
    {
        /// <summary>
        /// Identifier of the customer account to bill. Specify this field or `account_number` if you want to create a bill run for a single customer.
        /// </summary>
        /// <value>Identifier of the customer account to bill. Specify this field or `account_number` if you want to create a bill run for a single customer.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Human-readable identifier of the account to bill. Specify this field or `account_id` if you want to create a bill run for a single customer.
        /// </summary>
        /// <value>Human-readable identifier of the account to bill. Specify this field or `account_id` if you want to create a bill run for a single customer.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Identifier of the customer account batch to be included in this bill run.
        /// </summary>
        /// <value>Identifier of the customer account batch to be included in this bill run.</value>
        [DataMember(Name = "batches")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "batches")]
        public List<string> Batches { get; set; }

        /// <summary>
        /// Type of the charge to be excluded from the bill run.
        /// </summary>
        /// <value>Type of the charge to be excluded from the bill run.</value>
        [DataMember(Name = "charges_excluded")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "charges_excluded")]
        public List<string> ChargesExcluded { get; set; }

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
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public OneOfBillRunCreateRequestCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// The day of the month on which the multiple customer accounts are billed.
        /// </summary>
        /// <value>The day of the month on which the multiple customer accounts are billed.</value>
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
        /// If it is set to `false`, invoices for zero amounts will not be emailed to customers.
        /// </summary>
        /// <value>If it is set to `false`, invoices for zero amounts will not be emailed to customers. </value>
        [DataMember(Name = "email_zero_amount_invoices")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email_zero_amount_invoices")]
        public bool? EmailZeroAmountInvoices { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The date displayed on the invoice.
        /// </summary>
        /// <value>The date displayed on the invoice.</value>
        [DataMember(Name = "invoice_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_date")]
        public DateTime? InvoiceDate { get; set; }

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
        /// The target subscriptions for this bill run. Note that all these subscriptions must belong to the same account.
        /// </summary>
        /// <value>The target subscriptions for this bill run. Note that all these subscriptions must belong to the same account.</value>
        [DataMember(Name = "subscription_ids")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_ids")]
        public List<string> SubscriptionIds { get; set; }

        /// <summary>
        /// All unbilled items on or before this date are included in this bill run.
        /// </summary>
        /// <value>All unbilled items on or before this date are included in this bill run.</value>
        [DataMember(Name = "target_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target_date")]
        public DateTime? TargetDate { get; set; }

        /// <summary>
        /// The type of the bill run. This field is only available if you have the <a href=”https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Automate_billing_document_generation/Bill_runs/Z_Catch-Up_Bill_Run” target=”_blank”>Catch-Up Bill Run</a> feature enabled in your tenant.
        /// </summary>
        /// <value>The type of the bill run. This field is only available if you have the <a href=”https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Automate_billing_document_generation/Bill_runs/Z_Catch-Up_Bill_Run” target=”_blank”>Catch-Up Bill Run</a> feature enabled in your tenant.</value>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

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
            sb.Append("class BillRunCreateRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Post: ").Append(Post).Append("\n");
            sb.Append("  Renew: ").Append(Renew).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  Batches: ").Append(Batches).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  EmailZeroAmountInvoices: ").Append(EmailZeroAmountInvoices).Append("\n");
            sb.Append("  ChargesExcluded: ").Append(ChargesExcluded).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubscriptionIds: ").Append(SubscriptionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}