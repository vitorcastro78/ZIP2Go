using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FlexibleBillingDocumentSettings
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// ID of the billing document sequence set.
        /// </summary>
        /// <value>ID of the billing document sequence set.</value>
        [DataMember(Name = "sequence_set_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sequence_set_id")]
        public string SequenceSetId { get; set; }

        /// <summary>
        /// Identifier of the invoice template associated with this customer. Not applicable for debit memos or credit memos.
        /// </summary>
        /// <value>Identifier of the invoice template associated with this customer. Not applicable for debit memos or credit memos.</value>
        [DataMember(Name = "template_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "template_id")]
        public string TemplateId { get; set; }

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
            sb.Append("class FlexibleBillingDocumentSettings {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  SequenceSetId: ").Append(SequenceSetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}