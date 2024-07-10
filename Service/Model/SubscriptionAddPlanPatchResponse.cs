using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SubscriptionAddPlanPatchResponse {
    /// <summary>
    /// A unique string to represent the subscription plan in the order. The unique token is used to perform multiple actions against a newly added subscription plan. For example, if you want to add and update a product in the same order, assign a unique token to the newly added subscription plan and use that token in future order actions.
    /// </summary>
    /// <value>A unique string to represent the subscription plan in the order. The unique token is used to perform multiple actions against a newly added subscription plan. For example, if you want to add and update a product in the same order, assign a unique token to the newly added subscription plan and use that token in future order actions.</value>
    [DataMember(Name="unique_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_token")]
    public string UniqueToken { get; set; }

    /// <summary>
    /// The id of the subscription plan to be updated. It can be the latest version or any history version id.
    /// </summary>
    /// <value>The id of the subscription plan to be updated. It can be the latest version or any history version id.</value>
    [DataMember(Name="plan_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plan_id")]
    public string PlanId { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public CustomFields CustomFields { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionItems
    /// </summary>
    [DataMember(Name="subscription_items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_items")]
    public AllOfsubscriptionAddPlanPatchResponseSubscriptionItems SubscriptionItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionAddPlanPatchResponse {\n");
      sb.Append("  UniqueToken: ").Append(UniqueToken).Append("\n");
      sb.Append("  PlanId: ").Append(PlanId).Append("\n");
      sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
      sb.Append("  SubscriptionItems: ").Append(SubscriptionItems).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
