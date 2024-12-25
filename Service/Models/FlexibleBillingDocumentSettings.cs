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
  public class FlexibleBillingDocumentSettings {
    /// <summary>
    /// Identifier of the invoice template associated with this customer. Not applicable for debit memos or credit memos.
    /// </summary>
    /// <value>Identifier of the invoice template associated with this customer. Not applicable for debit memos or credit memos.</value>
    [DataMember(Name="template_id", EmitDefaultValue=false)]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "template_id")]
    public string TemplateId { get; set; }

    /// <summary>
    /// ID of the billing document sequence set.
    /// </summary>
    /// <value>ID of the billing document sequence set.</value>
    [DataMember(Name="sequence_set_id", EmitDefaultValue=false)]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sequence_set_id")]
    public string SequenceSetId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlexibleBillingDocumentSettings {\n");
      sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
      sb.Append("  SequenceSetId: ").Append(SequenceSetId).Append("\n");
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
