using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Specify this field to renew a subscription
    /// </summary>
    [DataContract]
    public class SubscriptionRenew
    {
        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name = "terms", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "terms")]
        public SubscriptionTerm Terms { get; set; }

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
            sb.Append("class SubscriptionRenewPatchResponse {\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}