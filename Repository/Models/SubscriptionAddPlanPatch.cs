using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionAddPlanPatch
    {
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The id of the subscription plan to be updated. It can be the latest version or any history version id.
        /// </summary>
        /// <value>The id of the subscription plan to be updated. It can be the latest version or any history version id.</value>
        [DataMember(Name = "plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionItems
        /// </summary>
        [DataMember(Name = "subscription_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_items")]
        public List<SubscriptionItem> SubscriptionItems { get; set; }

        /// <summary>
        /// A unique string to represent the subscription plan in the order. The unique token is used to perform multiple actions against a newly added subscription plan. For example, if you want to add and update a product in the same order, assign a unique token to the newly added subscription plan and use that token in future order actions.
        /// </summary>
        /// <value>A unique string to represent the subscription plan in the order. The unique token is used to perform multiple actions against a newly added subscription plan. For example, if you want to add and update a product in the same order, assign a unique token to the newly added subscription plan and use that token in future order actions.</value>
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
            sb.Append("class SubscriptionAddPlanPatchResponse {\n");
            sb.Append("  UniqueToken: ").Append(UniqueToken).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  SubscriptionItems: ").Append(SubscriptionItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}