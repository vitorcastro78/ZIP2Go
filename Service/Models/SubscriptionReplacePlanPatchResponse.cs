using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionReplacePlanPatchResponse
    {
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The id of the subscription plan to be updated. It can be the latest version or any history version id.
        /// </summary>
        /// <value>The id of the subscription plan to be updated. It can be the latest version or any history version id.</value>
        [DataMember(Name = "plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// Identifier of the plan to be removed. Only provide one of `previous_plan_id` or `subscription_plan_id` in your request, not both.
        /// </summary>
        /// <value>Identifier of the plan to be removed. Only provide one of `previous_plan_id` or `subscription_plan_id` in your request, not both.</value>
        [DataMember(Name = "previous_plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previous_plan_id")]
        public string PreviousPlanId { get; set; }

        /// <summary>
        /// Identifier of the subscription plan.
        /// </summary>
        /// <value>Identifier of the subscription plan.</value>
        [DataMember(Name = "previous_subscription_plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previous_subscription_plan_id")]
        public string PreviousSubscriptionPlanId { get; set; }

        /// <summary>
        /// The date when the replacement occurs. It can be either the current date or the end of the current billing period.
        /// </summary>
        /// <value>The date when the replacement occurs. It can be either the current date or the end of the current billing period.</value>
        [DataMember(Name = "replace_at")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replace_at")]
        public string ReplaceAt { get; set; }

        /// <summary>
        /// The type of the replacement.
        /// </summary>
        /// <value>The type of the replacement.</value>
        [DataMember(Name = "replacement_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replacement_type")]
        public string ReplacementType { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionItems
        /// </summary>
        [DataMember(Name = "subscription_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_items")]
        public AllOfsubscriptionReplacePlanPatchResponseSubscriptionItems SubscriptionItems { get; set; }

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
            sb.Append("class SubscriptionReplacePlanPatchResponse {\n");
            sb.Append("  PreviousSubscriptionPlanId: ").Append(PreviousSubscriptionPlanId).Append("\n");
            sb.Append("  PreviousPlanId: ").Append(PreviousPlanId).Append("\n");
            sb.Append("  ReplaceAt: ").Append(ReplaceAt).Append("\n");
            sb.Append("  ReplacementType: ").Append(ReplacementType).Append("\n");
            sb.Append("  UniqueToken: ").Append(UniqueToken).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  SubscriptionItems: ").Append(SubscriptionItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}