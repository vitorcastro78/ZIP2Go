using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionAddPlanPatchRequest
    {
        /// <summary>
        /// Gets or Sets StartOn
        /// </summary>
        [DataMember(Name = "start_on")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_on")]
        public StartOn StartOn { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionPlan
        /// </summary>
        [DataMember(Name = "subscription_plan")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plan")]
        public SubscriptionPlanCreateRequest SubscriptionPlan { get; set; }

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
            sb.Append("class SubscriptionAddPlanPatchRequest {\n");
            sb.Append("  SubscriptionPlan: ").Append(SubscriptionPlan).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}