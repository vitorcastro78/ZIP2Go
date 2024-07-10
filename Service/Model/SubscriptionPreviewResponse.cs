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
  public class SubscriptionPreviewResponse {
    /// <summary>
    /// Gets or Sets Actions
    /// </summary>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public List<AllOfsubscriptionPreviewResponseActionsItems> Actions { get; set; }

    /// <summary>
    /// Gets or Sets BillingDocuments
    /// </summary>
    [DataMember(Name="billing_documents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_documents")]
    public List<AllOfsubscriptionPreviewResponseBillingDocumentsItems> BillingDocuments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionPreviewResponse {\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
      sb.Append("  BillingDocuments: ").Append(BillingDocuments).Append("\n");
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
