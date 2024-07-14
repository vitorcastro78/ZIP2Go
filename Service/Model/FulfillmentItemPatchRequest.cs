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
  public class FulfillmentItemPatchRequest {
    /// <summary>
    /// An arbitrary string attached to the object. Often useful for displaying to users.
    /// </summary>
    /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Human-readable identifier for the object. It can be user-supplied.
    /// </summary>
    /// <value>Human-readable identifier for the object. It can be user-supplied.</value>
    [DataMember(Name="fulfillment_item_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfillment_item_number")]
    public string FulfillmentItemNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public CustomFields CustomFields { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FulfillmentItemPatchRequest {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FulfillmentItemNumber: ").Append(FulfillmentItemNumber).Append("\n");
      sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
