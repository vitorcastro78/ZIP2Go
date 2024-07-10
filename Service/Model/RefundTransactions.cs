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
  public class RefundTransactions {
    /// <summary>
    /// Gets or Sets RefundNumber
    /// </summary>
    [DataMember(Name="refund_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refund_number")]
    public string RefundNumber { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceNumbers
    /// </summary>
    [DataMember(Name="invoice_numbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_numbers")]
    public List<string> InvoiceNumbers { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public AllOfrefundTransactionsState State { get; set; }

    /// <summary>
    /// The related invoices.
    /// </summary>
    /// <value>The related invoices.</value>
    [DataMember(Name="refunds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refunds")]
    public AllOfrefundTransactionsRefunds Refunds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RefundTransactions {\n");
      sb.Append("  RefundNumber: ").Append(RefundNumber).Append("\n");
      sb.Append("  InvoiceNumbers: ").Append(InvoiceNumbers).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Refunds: ").Append(Refunds).Append("\n");
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
