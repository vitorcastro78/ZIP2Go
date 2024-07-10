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
  public class SubscriptionRemovePlanPatchResponse {
    /// <summary>
    /// Identifier of the subscription plan.
    /// </summary>
    /// <value>Identifier of the subscription plan.</value>
    [DataMember(Name="subscription_plan_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_plan_id")]
    public string SubscriptionPlanId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionRemovePlanPatchResponse {\n");
      sb.Append("  SubscriptionPlanId: ").Append(SubscriptionPlanId).Append("\n");
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
