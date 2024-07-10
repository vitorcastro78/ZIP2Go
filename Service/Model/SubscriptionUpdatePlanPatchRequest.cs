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
  public class SubscriptionUpdatePlanPatchRequest {
    /// <summary>
    /// Gets or Sets SubscriptionPlan
    /// </summary>
    [DataMember(Name="subscription_plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_plan")]
    public SubscriptionPlanPatchRequest SubscriptionPlan { get; set; }

    /// <summary>
    /// Gets or Sets StartOn
    /// </summary>
    [DataMember(Name="start_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_on")]
    public StartOn StartOn { get; set; }

    /// <summary>
    /// The start date from which this order action becomes effective.
    /// </summary>
    /// <value>The start date from which this order action becomes effective.</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public DateTime? StartDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionUpdatePlanPatchRequest {\n");
      sb.Append("  SubscriptionPlan: ").Append(SubscriptionPlan).Append("\n");
      sb.Append("  StartOn: ").Append(StartOn).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
