using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class DebitMemoCreateRequest
    {
        /// <summary>
        /// Identifier of the account that owns the debit memo.
        /// </summary>
        /// <value>Identifier of the account that owns the debit memo.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Human-readable identifier of the account that owns the debit memo.
        /// </summary>
        /// <value>Human-readable identifier of the account that owns the debit memo.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Whether to automatically apply the billing document upon posting.
        /// </summary>
        /// <value>Whether to automatically apply the billing document upon posting.</value>
        [DataMember(Name = "apply")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apply")]
        public bool? Apply { get; set; }

        /// <summary>
        /// 3-letter ISO 4217 currency code
        /// </summary>
        /// <value>3-letter ISO 4217 currency code</value>
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
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The date when the debit memo takes effect.
        /// </summary>
        /// <value>The date when the debit memo takes effect.</value>
        [DataMember(Name = "document_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_date")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// The date on which payment for the debit memo is due.
        /// </summary>
        /// <value>The date on which payment for the debit memo is due.</value>
        [DataMember(Name = "due_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "due_date")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices. This field is applicable only if the `type` field is set to `credit_memo`.
        /// </summary>
        /// <value>Indicates whether to exclude this credit memo from the rule of automatically applying it to invoices. This field is applicable only if the `type` field is set to `credit_memo`.</value>
        [DataMember(Name = "exclude_from_auto_apply_rules")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exclude_from_auto_apply_rules")]
        public bool? ExcludeFromAutoApplyRules { get; set; }

        /// <summary>
        /// The identifier of the invoice from which this credit memo or debit memo is created. This field is applicable only if the `type` field is set to `credit_memo` or `debit_memo`.
        /// </summary>
        /// <value>The identifier of the invoice from which this credit memo or debit memo is created. This field is applicable only if the `type` field is set to `credit_memo` or `debit_memo`.</value>
        [DataMember(Name = "invoice_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Information of all billing document items.
        /// </summary>
        /// <value>Information of all billing document items.</value>
        [DataMember(Name = "items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items")]
        public List<BillingDocumentItemCreateRequest> Items { get; set; }

        /// <summary>
        /// Indicates whether this billing document is automatically picked up for processing in the corresponding payment run.
        /// </summary>
        /// <value>Indicates whether this billing document is automatically picked up for processing in the corresponding payment run.</value>
        [DataMember(Name = "pay")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pay")]
        public bool? Pay { get; set; }

        /// <summary>
        /// Whether to automatically post a billing document after it is created.
        /// </summary>
        /// <value>Whether to automatically post a billing document after it is created.</value>
        [DataMember(Name = "post")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "post")]
        public bool? Post { get; set; }

        /// <summary>
        /// Reason for issuing this debit memo. This field is applicable only if the `type` field is set to `credit_memo` or `debit_memo`.
        /// </summary>
        /// <value>Reason for issuing this debit memo. This field is applicable only if the `type` field is set to `credit_memo` or `debit_memo`.</value>
        [DataMember(Name = "reason_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Whether to transfer to an external accounting system.
        /// </summary>
        /// <value>Whether to transfer to an external accounting system.</value>
        [DataMember(Name = "transfer_to_accounting")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transfer_to_accounting")]
        public bool? TransferToAccounting { get; set; }

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
            sb.Append("class DebitMemoCreateRequest {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  TransferToAccounting: ").Append(TransferToAccounting).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  ExcludeFromAutoApplyRules: ").Append(ExcludeFromAutoApplyRules).Append("\n");
            sb.Append("  Pay: ").Append(Pay).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Apply: ").Append(Apply).Append("\n");
            sb.Append("  Post: ").Append(Post).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}