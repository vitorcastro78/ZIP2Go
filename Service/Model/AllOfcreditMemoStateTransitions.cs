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
  public class AllOfcreditMemoStateTransitions {
    /// <summary>
    /// Gets or Sets PostedTime
    /// </summary>
    [DataMember(Name="posted_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "posted_time")]
    public string PostedTime { get; set; }

    /// <summary>
    /// Gets or Sets CanceledTime
    /// </summary>
    [DataMember(Name="canceled_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canceled_time")]
    public string CanceledTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AllOfcreditMemoStateTransitions {\n");
      sb.Append("  PostedTime: ").Append(PostedTime).Append("\n");
      sb.Append("  CanceledTime: ").Append(CanceledTime).Append("\n");
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
