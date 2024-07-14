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
  public class CancelSubscriptionRequest {
    /// <summary>
    /// Date on which the subscription is canceled.
    /// </summary>
    /// <value>Date on which the subscription is canceled.</value>
    [DataMember(Name="cancel_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancel_date")]
    public string CancelDate { get; set; }

    /// <summary>
    /// The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.
    /// </summary>
    /// <value>The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.</value>
    [DataMember(Name="cancel_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancel_at")]
    public string CancelAt { get; set; }

    /// <summary>
    /// Processing options for the invoice or payment.
    /// </summary>
    /// <value>Processing options for the invoice or payment.</value>
    [DataMember(Name="processing_options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processing_options")]
    public AllOfcancelSubscriptionRequestProcessingOptions ProcessingOptions { get; set; }

    /// <summary>
    /// Amount to be refunded
    /// </summary>
    /// <value>Amount to be refunded</value>
    [DataMember(Name="refund_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refund_amount")]
    public decimal? RefundAmount { get; set; }

    /// <summary>
    /// Indicates whether to write off the outstanding balance on the invoice after canceling the subscription.
    /// </summary>
    /// <value>Indicates whether to write off the outstanding balance on the invoice after canceling the subscription.</value>
    [DataMember(Name="write_off", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "write_off")]
    public bool? WriteOff { get; set; }

    /// <summary>
    /// Gets or Sets WriteOffBehavior
    /// </summary>
    [DataMember(Name="write_off_behavior", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "write_off_behavior")]
    public WriteOffSuscriptionRequest WriteOffBehavior { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public CustomFields CustomFields { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CancelSubscriptionRequest {\n");
      sb.Append("  CancelDate: ").Append(CancelDate).Append("\n");
      sb.Append("  CancelAt: ").Append(CancelAt).Append("\n");
      sb.Append("  ProcessingOptions: ").Append(ProcessingOptions).Append("\n");
      sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
      sb.Append("  WriteOff: ").Append(WriteOff).Append("\n");
      sb.Append("  WriteOffBehavior: ").Append(WriteOffBehavior).Append("\n");
      sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
