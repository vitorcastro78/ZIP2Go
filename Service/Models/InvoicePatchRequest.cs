using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Zip2Go.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class InvoicePatchRequest
    {
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The date when the billing document takes effect.
        /// </summary>
        /// <value>The date when the billing document takes effect.</value>
        [DataMember(Name = "document_date", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_date")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// The date on which payment for the billing document is due.
        /// </summary>
        /// <value>The date on which payment for the billing document is due.</value>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "due_date")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Indicates whether the billing document is automatically picked up for processing in the corresponding payment run.
        /// </summary>
        /// <value>Indicates whether the billing document is automatically picked up for processing in the corresponding payment run.</value>
        [DataMember(Name = "pay", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pay")]
        public bool? Pay { get; set; }

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
            sb.Append("class InvoicePatchRequest {\n");
            sb.Append("  Pay: ").Append(Pay).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}