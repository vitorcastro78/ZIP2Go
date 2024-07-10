using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Term information of the subscription.
  /// </summary>
  [DataContract]
  public class SubscriptionTermPatchResponse {
    /// <summary>
    /// Current term information for the subscription.
    /// </summary>
    /// <value>Current term information for the subscription.</value>
    [DataMember(Name="current_term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_term")]
    public AllOfsubscriptionTermPatchResponseCurrentTerm CurrentTerm { get; set; }

    /// <summary>
    /// Renewal term information for the subscription.
    /// </summary>
    /// <value>Renewal term information for the subscription.</value>
    [DataMember(Name="renewal_term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewal_term")]
    public AllOfsubscriptionTermPatchResponseRenewalTerm RenewalTerm { get; set; }

    /// <summary>
    /// If true, the subscription automatically renews at the end of the current term.
    /// </summary>
    /// <value>If true, the subscription automatically renews at the end of the current term.</value>
    [DataMember(Name="auto_renew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_renew")]
    public bool? AutoRenew { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionTermPatchResponse {\n");
      sb.Append("  CurrentTerm: ").Append(CurrentTerm).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
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
