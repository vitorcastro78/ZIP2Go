using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Subscription plan information.
    /// </summary>
    [DataContract]
    public class SubscriptionPlan
    {
        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public string CreatedById { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public OneOfSubscriptionPlanCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the subscription plan.
        /// </summary>
        /// <value>The name of the subscription plan.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The plan object associated with this subscription plan.
        /// </summary>
        /// <value>The plan object associated with this subscription plan.</value>
        [DataMember(Name = "plan")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan")]
        public AllOfSubscriptionPlanPlan Plan { get; set; }

        /// <summary>
        /// Identifier of the plan associated with this subscription plan.
        /// </summary>
        /// <value>Identifier of the plan associated with this subscription plan.</value>
        [DataMember(Name = "plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// The product associated with the subscription plan.
        /// </summary>
        /// <value>The product associated with the subscription plan.</value>
        [DataMember(Name = "product")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "product")]
        public AllOfSubscriptionPlanProduct Product { get; set; }

        /// <summary>
        /// Identifier of the product associated with this subscription plan.
        /// </summary>
        /// <value>Identifier of the product associated with this subscription plan.</value>
        [DataMember(Name = "product_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// The subscription to which this subscription plan belongs.
        /// </summary>
        /// <value>The subscription to which this subscription plan belongs.</value>
        [DataMember(Name = "subscription")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription")]
        public AllOfSubscriptionPlanSubscription Subscription { get; set; }

        /// <summary>
        /// Identifier of the subscription this subscription plan belongs to.
        /// </summary>
        /// <value>Identifier of the subscription this subscription plan belongs to.</value>
        [DataMember(Name = "subscription_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// List of subscription items.
        /// </summary>
        /// <value>List of subscription items.</value>
        [DataMember(Name = "subscription_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_items")]
        public AllOfSubscriptionPlanSubscriptionItems SubscriptionItems { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public string UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

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
            sb.Append("class SubscriptionPlan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubscriptionItems: ").Append(SubscriptionItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}