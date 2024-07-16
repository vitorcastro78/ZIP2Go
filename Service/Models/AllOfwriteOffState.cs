using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Models {

  /// <summary>
  /// The states of the transactions.
  /// </summary>
  [DataContract]
  public class AllOfwriteOffState {
    /// <summary>
    /// Gets or Sets Succeeded
    /// </summary>
    [DataMember(Name="succeeded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "succeeded")]
    public string Succeeded { get; set; }

    /// <summary>
    /// Gets or Sets Failed
    /// </summary>
    [DataMember(Name="failed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed")]
    public string Failed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AllOfwriteOffState {\n");
      sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
      sb.Append("  Failed: ").Append(Failed).Append("\n");
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
