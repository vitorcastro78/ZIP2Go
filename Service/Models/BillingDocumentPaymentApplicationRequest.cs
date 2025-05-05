using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BillingDocumentPaymentApplicationRequest
    {
        /// <summary>
        /// The amount applied to this billing document.
        /// </summary>
        /// <value>The amount applied to this billing document.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// A human-readable identifier for the billing document; may be user-supplied.
        /// </summary>
        /// <value>A human-readable identifier for the billing document; may be user-supplied.</value>
        [DataMember(Name = "billing_document_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_number")]
        public string BillingDocumentNumber { get; set; }

        /// <summary>
        /// Identifier of the billing document to which the credit memo, payment, or refund is applied.
        /// </summary>
        /// <value>Identifier of the billing document to which the credit memo, payment, or refund is applied.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The billing document items (invoice items or debit memo items or taxation items) to which the payment is applied.
        /// </summary>
        /// <value>The billing document items (invoice items or debit memo items or taxation items) to which the payment is applied.</value>
        [DataMember(Name = "items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items")]
        public List<BillingDocumentItemPaymentApplicationRequest> Items { get; set; }

        /// <summary>
        /// The type of billing document.
        /// </summary>
        /// <value>The type of billing document.</value>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

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
            sb.Append("class BillingDocumentPaymentApplicationRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillingDocumentNumber: ").Append(BillingDocumentNumber).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}