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
  public class PrepaidBalanceTransaction {
    /// <summary>
    /// Date on which the transaction occurs.
    /// </summary>
    /// <value>Date on which the transaction occurs.</value>
    [DataMember(Name="transaction_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction_date")]
    public string TransactionDate { get; set; }

    /// <summary>
    /// An action that increases or decreases its associated prepaid balance. 
    /// </summary>
    /// <value>An action that increases or decreases its associated prepaid balance. </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Quantity of the prepaid balance transaction.
    /// </summary>
    /// <value>Quantity of the prepaid balance transaction.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public decimal? Quantity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PrepaidBalanceTransaction {\n");
      sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
