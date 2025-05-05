using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Billing document settings for an account
    /// </summary>
    [DataContract]
    public class BillingDocumentSettings
    {
        /// <summary>
        /// A list of additional email addresses to receive email notifications.
        /// </summary>
        /// <value>A list of additional email addresses to receive email notifications.</value>
        [DataMember(Name = "additional_email")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "additional_email")]
        public List<string> AdditionalEmail { get; set; }

        /// <summary>
        /// Identifier of the credit memo template associated with this customer.
        /// </summary>
        /// <value>Identifier of the credit memo template associated with this customer.</value>
        [DataMember(Name = "credit_memo_template_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo_template_id")]
        public string CreditMemoTemplateId { get; set; }

        /// <summary>
        /// Identifier of the debit memo template associated with this customer.
        /// </summary>
        /// <value>Identifier of the debit memo template associated with this customer.</value>
        [DataMember(Name = "debit_memo_template_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "debit_memo_template_id")]
        public string DebitMemoTemplateId { get; set; }

        /// <summary>
        /// Whether the customer wants to receive email invoices.
        /// </summary>
        /// <value>Whether the customer wants to receive email invoices.</value>
        [DataMember(Name = "email_documents")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email_documents")]
        public bool? EmailDocuments { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Identifier of the invoice template associated with this customer.
        /// </summary>
        /// <value>Identifier of the invoice template associated with this customer.</value>
        [DataMember(Name = "invoice_template_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_template_id")]
        public string InvoiceTemplateId { get; set; }

        /// <summary>
        /// Whether the customer wants to receive printed invoices.
        /// </summary>
        /// <value>Whether the customer wants to receive printed invoices.</value>
        [DataMember(Name = "print_documents")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "print_documents")]
        public bool? PrintDocuments { get; set; }

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
            sb.Append("class BillingDocumentSettings {\n");
            sb.Append("  CreditMemoTemplateId: ").Append(CreditMemoTemplateId).Append("\n");
            sb.Append("  DebitMemoTemplateId: ").Append(DebitMemoTemplateId).Append("\n");
            sb.Append("  EmailDocuments: ").Append(EmailDocuments).Append("\n");
            sb.Append("  PrintDocuments: ").Append(PrintDocuments).Append("\n");
            sb.Append("  InvoiceTemplateId: ").Append(InvoiceTemplateId).Append("\n");
            sb.Append("  AdditionalEmail: ").Append(AdditionalEmail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}