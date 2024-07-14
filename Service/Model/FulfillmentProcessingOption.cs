using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FulfillmentProcessingOption {
    /// <summary>
    /// Date on which the billing document is created or paid.
    /// </summary>
    /// <value>Date on which the billing document is created or paid.</value>
    [DataMember(Name="document_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document_date")]
    public DateTime? DocumentDate { get; set; }

    /// <summary>
    /// The target date for the order to be picked up by bill run for billing.
    /// </summary>
    /// <value>The target date for the order to be picked up by bill run for billing.</value>
    [DataMember(Name="target_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_date")]
    public DateTime? TargetDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FulfillmentProcessingOption {\n");
      sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
      sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
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
