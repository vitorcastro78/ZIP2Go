using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Subscription plan information.
    /// </summary>
    [DataContract]
    public class SubscriptionPlanCreateRequest
    {
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Identifier of the plan associated with this subscription plan.
        /// </summary>
        /// <value>Identifier of the plan associated with this subscription plan.</value>
        [DataMember(Name = "plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// Human-readable identifier of the plan associated with this subscription plan.
        /// </summary>
        /// <value>Human-readable identifier of the plan associated with this subscription plan.</value>
        [DataMember(Name = "plan_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan_number")]
        public string PlanNumber { get; set; }

        /// <summary>
        /// Price information within the subscription plan.
        /// </summary>
        /// <value>Price information within the subscription plan.</value>
        [DataMember(Name = "prices")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prices")]
        public List<AllOfsubscriptionPlanCreateRequestPricesItems> Prices { get; set; }

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
            sb.Append("class SubscriptionPlanCreateRequest {\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  PlanNumber: ").Append(PlanNumber).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
            sb.Append("  UniqueToken: ").Append(UniqueToken).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}