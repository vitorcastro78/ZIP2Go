using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class InvoiceReverseRequest
    {
        /// <summary>
        /// Gets or Sets ApplyDate
        /// </summary>
        [DataMember(Name = "apply_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apply_date")]
        public DateTime? ApplyDate { get; set; }

        /// <summary>
        /// The date that appears on the credit memo.
        /// </summary>
        /// <value>The date that appears on the credit memo.</value>
        [DataMember(Name = "document_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_date")]
        public DateTime? DocumentDate { get; set; }

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
            sb.Append("class InvoiceReverseRequest {\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  ApplyDate: ").Append(ApplyDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}