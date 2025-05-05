using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentScheduleBillingDocumentRequest
    {
        /// <summary>
        /// Document number of an invoice or debit memo billing document.
        /// </summary>
        /// <value>Document number of an invoice or debit memo billing document.</value>
        [DataMember(Name = "billing_document_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document_number")]
        public string BillingDocumentNumber { get; set; }

        /// <summary>
        /// Unique identifier of an invoice or debit memo billing document.
        /// </summary>
        /// <value>Unique identifier of an invoice or debit memo billing document.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of billing document. The default is `invoice`.
        /// </summary>
        /// <value>The type of billing document. The default is `invoice`.</value>
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
            sb.Append("class PaymentScheduleBillingDocumentRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BillingDocumentNumber: ").Append(BillingDocumentNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}