using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class LineItemsPreviewResponse
    {
        /// <summary>
        /// Gets or Sets Mrr
        /// </summary>
        [DataMember(Name = "mrr", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mrr")]
        public LineItemsPreviewResponseMrr Mrr { get; set; }

        /// <summary>
        /// Gets or Sets Tcb
        /// </summary>
        [DataMember(Name = "tcb", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tcb")]
        public LineItemsPreviewResponseMrr Tcb { get; set; }

        /// <summary>
        /// Gets or Sets Tcv
        /// </summary>
        [DataMember(Name = "tcv", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tcv")]
        public LineItemsPreviewResponseMrr Tcv { get; set; }

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
            sb.Append("class LineItemsPreviewResponse {\n");
            sb.Append("  Mrr: ").Append(Mrr).Append("\n");
            sb.Append("  Tcb: ").Append(Tcb).Append("\n");
            sb.Append("  Tcv: ").Append(Tcv).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}