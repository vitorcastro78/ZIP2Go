using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Models {

  /// <summary>
  /// Specify this field to renew a subscription
  /// </summary>
  [DataContract]
  public class SubscriptionRenewPatchResponse {
    /// <summary>
    /// Gets or Sets Terms
    /// </summary>
    [DataMember(Name="terms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terms")]
    public AllOfsubscriptionRenewPatchResponseTerms Terms { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionRenewPatchResponse {\n");
      sb.Append("  Terms: ").Append(Terms).Append("\n");
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
