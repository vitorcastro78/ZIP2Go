using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Models {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SubscriptionRemovePlanPatchRequest {
    /// <summary>
    /// Identifier of the subscription plan.
    /// </summary>
    /// <value>Identifier of the subscription plan.</value>
    [DataMember(Name="subscription_plan_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_plan_id")]
    public string SubscriptionPlanId { get; set; }

    /// <summary>
    /// Gets or Sets StartOn
    /// </summary>
    [DataMember(Name="start_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_on")]
    public StartOn StartOn { get; set; }

    /// <summary>
    /// Unique identifier for the subscription plan. This identifier enables you to refer to the subscription plan before the subscription plan has an internal identifier in Zuora.
    /// </summary>
    /// <value>Unique identifier for the subscription plan. This identifier enables you to refer to the subscription plan before the subscription plan has an internal identifier in Zuora.</value>
    [DataMember(Name="unique_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_token")]
    public string UniqueToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionRemovePlanPatchRequest {\n");
      sb.Append("  SubscriptionPlanId: ").Append(SubscriptionPlanId).Append("\n");
      sb.Append("  StartOn: ").Append(StartOn).Append("\n");
      sb.Append("  UniqueToken: ").Append(UniqueToken).Append("\n");
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
