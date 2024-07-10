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
  public class ApplyUnapplyCreditMemo {
    /// <summary>
    /// The date when the credit memo is applied
    /// </summary>
    /// <value>The date when the credit memo is applied</value>
    [DataMember(Name="effective_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effective_date")]
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    /// Array of billing documents to apply this credit memo to.
    /// </summary>
    /// <value>Array of billing documents to apply this credit memo to.</value>
    [DataMember(Name="billing_documents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_documents")]
    public List<CreditMemoApplicationRequest> BillingDocuments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplyUnapplyCreditMemo {\n");
      sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
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
