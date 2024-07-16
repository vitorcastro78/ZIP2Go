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
  public class OrderSubscriptionPreviewResponse {
    /// <summary>
    /// Human-readable identifier of the subscription. It can be user-supplied.
    /// </summary>
    /// <value>Human-readable identifier of the subscription. It can be user-supplied.</value>
    [DataMember(Name="subscription_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_number")]
    public string SubscriptionNumber { get; set; }

    /// <summary>
    /// Gets or Sets Actions
    /// </summary>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public List<AllOforderSubscriptionPreviewResponseActionsItems> Actions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderSubscriptionPreviewResponse {\n");
      sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
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
