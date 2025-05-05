using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class CancelSubscriptionRequest
    {
        /// <summary>
        /// The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.
        /// </summary>
        /// <value>The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.</value>
        [DataMember(Name = "cancel_at")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancel_at")]
        public string CancelAt { get; set; }

        /// <summary>
        /// Date on which the subscription is canceled.
        /// </summary>
        /// <value>Date on which the subscription is canceled.</value>
        [DataMember(Name = "cancel_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancel_date")]
        public string CancelDate { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Processing options for the invoice or payment.
        /// </summary>
        /// <value>Processing options for the invoice or payment.</value>
        [DataMember(Name = "processing_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processing_options")]
        public AllOfcancelSubscriptionRequestProcessingOptions ProcessingOptions { get; set; }

        /// <summary>
        /// Amount to be refunded
        /// </summary>
        /// <value>Amount to be refunded</value>
        [DataMember(Name = "refund_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refund_amount")]
        public decimal? RefundAmount { get; set; }

        /// <summary>
        /// Indicates whether to write off the outstanding balance on the invoice after canceling the subscription.
        /// </summary>
        /// <value>Indicates whether to write off the outstanding balance on the invoice after canceling the subscription.</value>
        [DataMember(Name = "write_off")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "write_off")]
        public bool? WriteOff { get; set; }

        /// <summary>
        /// Gets or Sets WriteOffBehavior
        /// </summary>
        [DataMember(Name = "write_off_behavior")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "write_off_behavior")]
        public WriteOffSuscriptionRequest WriteOffBehavior { get; set; }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
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
    }
}