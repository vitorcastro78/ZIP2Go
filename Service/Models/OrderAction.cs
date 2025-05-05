using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class OrderAction
    {
        /// <summary>
        /// Identifier of the action.
        /// </summary>
        /// <value>Identifier of the action.</value>
        [DataMember(Name = "action_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action_id")]
        public string ActionId { get; set; }

        /// <summary>
        /// Specify this field to add subscription plans to existing subscriptions.
        /// </summary>
        /// <value>Specify this field to add subscription plans to existing subscriptions.</value>
        [DataMember(Name = "add_subscription_plan")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "add_subscription_plan")]
        public AllOforderActionAddSubscriptionPlan AddSubscriptionPlan { get; set; }

        /// <summary>
        /// Specify this field to cancel an existing subscription.
        /// </summary>
        /// <value>Specify this field to cancel an existing subscription.</value>
        [DataMember(Name = "cancel")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancel")]
        public AllOforderActionCancel Cancel { get; set; }

        /// <summary>
        /// Specify this field to pause an existing subscription.
        /// </summary>
        /// <value>Specify this field to pause an existing subscription.</value>
        [DataMember(Name = "pause")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pause")]
        public AllOforderActionPause Pause { get; set; }

        /// <summary>
        /// Specify this field to remove subscription plans from existing subscriptions.
        /// </summary>
        /// <value>Specify this field to remove subscription plans from existing subscriptions.</value>
        [DataMember(Name = "remove_subscription_plan")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remove_subscription_plan")]
        public AllOforderActionRemoveSubscriptionPlan RemoveSubscriptionPlan { get; set; }

        /// <summary>
        /// Specify this field to renew an existing subscription.
        /// </summary>
        /// <value>Specify this field to renew an existing subscription.</value>
        [DataMember(Name = "renew")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renew")]
        public AllOforderActionRenew Renew { get; set; }

        /// <summary>
        /// Specify this field to replace existing subscription plans with new plans.
        /// </summary>
        /// <value>Specify this field to replace existing subscription plans with new plans.</value>
        [DataMember(Name = "replace_subscription_plan")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replace_subscription_plan")]
        public AllOforderActionReplaceSubscriptionPlan ReplaceSubscriptionPlan { get; set; }

        /// <summary>
        /// Specify this field to resume a paused subscription.
        /// </summary>
        /// <value>Specify this field to resume a paused subscription.</value>
        [DataMember(Name = "resume")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resume")]
        public AllOforderActionResume Resume { get; set; }

        /// <summary>
        /// The sequence number of the action.
        /// </summary>
        /// <value>The sequence number of the action.</value>
        [DataMember(Name = "sequence")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// Gets or Sets StartOn
        /// </summary>
        [DataMember(Name = "start_on")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_on")]
        public StartOnResponse StartOn { get; set; }

        /// <summary>
        /// Specify this field to add new plans to the new subscription.
        /// </summary>
        /// <value>Specify this field to add new plans to the new subscription.</value>
        [DataMember(Name = "subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plans")]
        public AllOforderActionSubscriptionPlans SubscriptionPlans { get; set; }

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name = "terms")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "terms")]
        public AllOforderActionTerms Terms { get; set; }

        /// <summary>
        /// The action associated with this metric.
        /// </summary>
        /// <value>The action associated with this metric.</value>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Specify this field to update subscription plans on the existing subscriptions.
        /// </summary>
        /// <value>Specify this field to update subscription plans on the existing subscriptions.</value>
        [DataMember(Name = "update_subscription_plan")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "update_subscription_plan")]
        public AllOforderActionUpdateSubscriptionPlan UpdateSubscriptionPlan { get; set; }

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
            sb.Append("class OrderAction {\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("  SubscriptionPlans: ").Append(SubscriptionPlans).Append("\n");
            sb.Append("  AddSubscriptionPlan: ").Append(AddSubscriptionPlan).Append("\n");
            sb.Append("  RemoveSubscriptionPlan: ").Append(RemoveSubscriptionPlan).Append("\n");
            sb.Append("  UpdateSubscriptionPlan: ").Append(UpdateSubscriptionPlan).Append("\n");
            sb.Append("  ReplaceSubscriptionPlan: ").Append(ReplaceSubscriptionPlan).Append("\n");
            sb.Append("  Renew: ").Append(Renew).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  Cancel: ").Append(Cancel).Append("\n");
            sb.Append("  Pause: ").Append(Pause).Append("\n");
            sb.Append("  Resume: ").Append(Resume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}