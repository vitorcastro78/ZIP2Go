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
  public class OrderCancellationRequest {
    /// <summary>
    /// The reason for cancelling the order.
    /// </summary>
    /// <value>The reason for cancelling the order.</value>
    [DataMember(Name="cancel_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancel_reason")]
    public string CancelReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderCancellationRequest {\n");
      sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
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
