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
  public class WriteOffRequest {
    /// <summary>
    /// An arbitrary string associated with the object. Often useful for displaying to users.
    /// </summary>
    /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The date when the invoice takes effect.
    /// </summary>
    /// <value>The date when the invoice takes effect.</value>
    [DataMember(Name="document_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document_date")]
    public DateTime? DocumentDate { get; set; }

    /// <summary>
    /// Reason for issuing this credit memo
    /// </summary>
    /// <value>Reason for issuing this credit memo</value>
    [DataMember(Name="reason_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason_code")]
    public string ReasonCode { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public CustomFields CustomFields { get; set; }

    /// <summary>
    /// Information of all invoice items.
    /// </summary>
    /// <value>Information of all invoice items.</value>
    [DataMember(Name="invoice_items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_items")]
    public List<WriteOffItemsRequest> InvoiceItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WriteOffRequest {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
      sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
      sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
      sb.Append("  InvoiceItems: ").Append(InvoiceItems).Append("\n");
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
