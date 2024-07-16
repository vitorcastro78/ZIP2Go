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
  public class FulfillmentCreateRequest : FulfillmentRequest {
    /// <summary>
    /// Gets or Sets ProcessingOptions
    /// </summary>
    [DataMember(Name="processing_options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processing_options")]
    public FulfillmentProcessingOption ProcessingOptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FulfillmentCreateRequest {\n");
      sb.Append("  ProcessingOptions: ").Append(ProcessingOptions).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
