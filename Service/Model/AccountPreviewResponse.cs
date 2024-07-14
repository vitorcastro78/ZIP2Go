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
  public class AccountPreviewResponse {
    /// <summary>
    /// The unique identifier of the customer account associated with these items.
    /// </summary>
    /// <value>The unique identifier of the customer account associated with these items.</value>
    [DataMember(Name="account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_id")]
    public string AccountId { get; set; }

    /// <summary>
    /// Gets or Sets CreditMemoItems
    /// </summary>
    [DataMember(Name="credit_memo_items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credit_memo_items")]
    public List<AllOfaccountPreviewResponseCreditMemoItemsItems> CreditMemoItems { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceItems
    /// </summary>
    [DataMember(Name="invoice_items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_items")]
    public List<AllOfaccountPreviewResponseInvoiceItemsItems> InvoiceItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountPreviewResponse {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  CreditMemoItems: ").Append(CreditMemoItems).Append("\n");
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
