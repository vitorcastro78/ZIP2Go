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
  public class FinanceInformation {
    /// <summary>
    /// An active accounting code defined in **Finance Settings > Configure Accounting Codes** in your Zuora tenant.
    /// </summary>
    /// <value>An active accounting code defined in **Finance Settings > Configure Accounting Codes** in your Zuora tenant.</value>
    [DataMember(Name="accounting_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accounting_code")]
    public string AccountingCode { get; set; }

    /// <summary>
    /// An active account in your Zuora Chart of Accounts.
    /// </summary>
    /// <value>An active account in your Zuora Chart of Accounts.</value>
    [DataMember(Name="account_receivable_accounting_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_receivable_accounting_code")]
    public string AccountReceivableAccountingCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FinanceInformation {\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  AccountReceivableAccountingCode: ").Append(AccountReceivableAccountingCode).Append("\n");
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
