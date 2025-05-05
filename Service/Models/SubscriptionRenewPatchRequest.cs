using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Specify this field when renewing a subscription.
    /// </summary>
    [DataContract]
    public class SubscriptionRenewPatchRequest
    {
        /// <summary>
        /// Gets or Sets StartOn
        /// </summary>
        [DataMember(Name = "start_on")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_on")]
        public StartOn StartOn { get; set; }

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
            sb.Append("class SubscriptionRenewPatchRequest {\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}