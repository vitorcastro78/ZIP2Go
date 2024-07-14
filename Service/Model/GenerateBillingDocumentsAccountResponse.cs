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
  public class GenerateBillingDocumentsAccountResponse {
    /// <summary>
    /// Array of credit memos.
    /// </summary>
    /// <value>Array of credit memos.</value>
    [DataMember(Name="credit_memos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credit_memos")]
    public AllOfgenerateBillingDocumentsAccountResponseCreditMemos CreditMemos { get; set; }

    /// <summary>
    /// Array of invoices.
    /// </summary>
    /// <value>Array of invoices.</value>
    [DataMember(Name="invoices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoices")]
    public AllOfgenerateBillingDocumentsAccountResponseInvoices Invoices { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GenerateBillingDocumentsAccountResponse {\n");
      sb.Append("  CreditMemos: ").Append(CreditMemos).Append("\n");
      sb.Append("  Invoices: ").Append(Invoices).Append("\n");
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
