using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Models {

  /// <summary>
  /// If the &#x60;type&#x60; of the payment method is &#x60;betalings_debit&#x60;, this hash contains details about the Betalingsservice bank account.
  /// </summary>
  [DataContract]
  public class BetalingsDebit {
    /// <summary>
    /// The bank account number of the account holder.
    /// </summary>
    /// <value>The bank account number of the account holder.</value>
    [DataMember(Name="account_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// The identity number used for Betalingsservice (Direct Debit DK).
    /// </summary>
    /// <value>The identity number used for Betalingsservice (Direct Debit DK).</value>
    [DataMember(Name="identity_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identity_number")]
    public string IdentityNumber { get; set; }

    /// <summary>
    /// Identifier of the bank associated with this bank account.
    /// </summary>
    /// <value>Identifier of the bank associated with this bank account.</value>
    [DataMember(Name="bank_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bank_code")]
    public string BankCode { get; set; }

    /// <summary>
    /// Gets or Sets Mandate
    /// </summary>
    [DataMember(Name="mandate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mandate")]
    public Mandate Mandate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BetalingsDebit {\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  IdentityNumber: ").Append(IdentityNumber).Append("\n");
      sb.Append("  BankCode: ").Append(BankCode).Append("\n");
      sb.Append("  Mandate: ").Append(Mandate).Append("\n");
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
