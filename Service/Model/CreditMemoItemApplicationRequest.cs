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
  public class CreditMemoItemApplicationRequest {
    /// <summary>
    /// The identifier of the credit memo item to apply.
    /// </summary>
    /// <value>The identifier of the credit memo item to apply.</value>
    [DataMember(Name="credit_memo_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credit_memo_item_id")]
    public string CreditMemoItemId { get; set; }

    /// <summary>
    /// The credit memo amount applied to this billing document item or taxation item.
    /// </summary>
    /// <value>The credit memo amount applied to this billing document item or taxation item.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// The identifier of the credit memo taxation item to apply.
    /// </summary>
    /// <value>The identifier of the credit memo taxation item to apply.</value>
    [DataMember(Name="credit_memo_taxation_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credit_memo_taxation_item_id")]
    public string CreditMemoTaxationItemId { get; set; }

    /// <summary>
    /// The identifier of a taxation item.
    /// </summary>
    /// <value>The identifier of a taxation item.</value>
    [DataMember(Name="taxation_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxation_item_id")]
    public string TaxationItemId { get; set; }

    /// <summary>
    /// The identifier of an invoice item or debit memo item.
    /// </summary>
    /// <value>The identifier of an invoice item or debit memo item.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditMemoItemApplicationRequest {\n");
      sb.Append("  CreditMemoItemId: ").Append(CreditMemoItemId).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CreditMemoTaxationItemId: ").Append(CreditMemoTaxationItemId).Append("\n");
      sb.Append("  TaxationItemId: ").Append(TaxationItemId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
