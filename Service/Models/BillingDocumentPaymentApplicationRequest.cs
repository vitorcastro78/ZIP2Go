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
  public class BillingDocumentPaymentApplicationRequest {
    /// <summary>
    /// Identifier of the billing document to which the credit memo, payment, or refund is applied.
    /// </summary>
    /// <value>Identifier of the billing document to which the credit memo, payment, or refund is applied.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The type of billing document.
    /// </summary>
    /// <value>The type of billing document.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The amount applied to this billing document.
    /// </summary>
    /// <value>The amount applied to this billing document.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// A human-readable identifier for the billing document; may be user-supplied.
    /// </summary>
    /// <value>A human-readable identifier for the billing document; may be user-supplied.</value>
    [DataMember(Name="billing_document_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_document_number")]
    public string BillingDocumentNumber { get; set; }

    /// <summary>
    /// The billing document items (invoice items or debit memo items or taxation items) to which the payment is applied.
    /// </summary>
    /// <value>The billing document items (invoice items or debit memo items or taxation items) to which the payment is applied.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<BillingDocumentItemPaymentApplicationRequest> Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingDocumentPaymentApplicationRequest {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  BillingDocumentNumber: ").Append(BillingDocumentNumber).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
