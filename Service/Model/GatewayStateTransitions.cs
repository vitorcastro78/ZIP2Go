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
  public class GatewayStateTransitions {
    /// <summary>
    /// The date and time (ISO 8601 UTC format) when the payment was marked for submission.
    /// </summary>
    /// <value>The date and time (ISO 8601 UTC format) when the payment was marked for submission.</value>
    [DataMember(Name="marked_for_submission_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marked_for_submission_time")]
    public DateTime? MarkedForSubmissionTime { get; set; }

    /// <summary>
    /// The date and time (ISO 8601 UTC format) when the payment was settled.
    /// </summary>
    /// <value>The date and time (ISO 8601 UTC format) when the payment was settled.</value>
    [DataMember(Name="settled_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settled_time")]
    public DateTime? SettledTime { get; set; }

    /// <summary>
    /// The date and time (ISO 8601 UTC format) when the payment was submitted.
    /// </summary>
    /// <value>The date and time (ISO 8601 UTC format) when the payment was submitted.</value>
    [DataMember(Name="submitted_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "submitted_time")]
    public DateTime? SubmittedTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GatewayStateTransitions {\n");
      sb.Append("  MarkedForSubmissionTime: ").Append(MarkedForSubmissionTime).Append("\n");
      sb.Append("  SettledTime: ").Append(SettledTime).Append("\n");
      sb.Append("  SubmittedTime: ").Append(SubmittedTime).Append("\n");
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
