using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Subscription Plan information.
    /// </summary>
    [DataContract]
    public class SubscriptionPlanPatchRequest
    {
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Subscription item information.
        /// </summary>
        /// <value>Subscription item information.</value>
        [DataMember(Name = "subscription_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_items")]
        public List<AllOfsubscriptionPlanPatchRequestSubscriptionItemsItems> SubscriptionItems { get; set; }

        /// <summary>
        /// Identifier of the subscription plan.
        /// </summary>
        /// <value>Identifier of the subscription plan.</value>
        [DataMember(Name = "subscription_plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plan_id")]
        public string SubscriptionPlanId { get; set; }

        /// <summary>
        /// Unique identifier for the subscription plan. This identifier enables you to refer to the subscription plan before the subscription plan has an internal identifier in Zuora.
        /// </summary>
        /// <value>Unique identifier for the subscription plan. This identifier enables you to refer to the subscription plan before the subscription plan has an internal identifier in Zuora.</value>
        [DataMember(Name = "unique_token")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unique_token")]
        public string UniqueToken { get; set; }

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
            sb.Append("class SubscriptionPlanPatchRequest {\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  SubscriptionPlanId: ").Append(SubscriptionPlanId).Append("\n");
            sb.Append("  UniqueToken: ").Append(UniqueToken).Append("\n");
            sb.Append("  SubscriptionItems: ").Append(SubscriptionItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}