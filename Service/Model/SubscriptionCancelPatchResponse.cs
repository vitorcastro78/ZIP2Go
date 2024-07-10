using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Specify this field to cancel a subscription
  /// </summary>
  [DataContract]
  public class SubscriptionCancelPatchResponse {
    /// <summary>
    /// Date on which the subscription is canceled.
    /// </summary>
    /// <value>Date on which the subscription is canceled.</value>
    [DataMember(Name="cancel_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancel_date")]
    public DateTime? CancelDate { get; set; }

    /// <summary>
    /// The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.
    /// </summary>
    /// <value>The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.</value>
    [DataMember(Name="cancel_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancel_at")]
    public string CancelAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionCancelPatchResponse {\n");
      sb.Append("  CancelDate: ").Append(CancelDate).Append("\n");
      sb.Append("  CancelAt: ").Append(CancelAt).Append("\n");
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
