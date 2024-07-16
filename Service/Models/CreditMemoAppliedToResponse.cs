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
  public class CreditMemoAppliedToResponse {
    /// <summary>
    /// Identifier of an invoice or a debit memo.
    /// </summary>
    /// <value>Identifier of an invoice or a debit memo.</value>
    [DataMember(Name="billing_document_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_document_id")]
    public string BillingDocumentId { get; set; }

    /// <summary>
    /// Identifier of the credit memo application
    /// </summary>
    /// <value>Identifier of the credit memo application</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The amount of the payment that is applied to the specific billing document item or taxation item.
    /// </summary>
    /// <value>The amount of the payment that is applied to the specific billing document item or taxation item.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// The related billing document.
    /// </summary>
    /// <value>The related billing document.</value>
    [DataMember(Name="billing_document", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_document")]
    public AllOfcreditMemoAppliedToResponseBillingDocument BillingDocument { get; set; }

    /// <summary>
    /// The type of billing document. Can be one of the debit memo or invoice.
    /// </summary>
    /// <value>The type of billing document. Can be one of the debit memo or invoice.</value>
    [DataMember(Name="billing_document_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_document_type")]
    public string BillingDocumentType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditMemoAppliedToResponse {\n");
      sb.Append("  BillingDocumentId: ").Append(BillingDocumentId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  BillingDocument: ").Append(BillingDocument).Append("\n");
      sb.Append("  BillingDocumentType: ").Append(BillingDocumentType).Append("\n");
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
