using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Processing options for the invoice or payment.
    /// </summary>
    [DataContract]
    public class ProcessingOptions
    {
        /// <summary>
        /// Specifies whether to just create an invoice, or to create an invoice and collect payment.
        /// </summary>
        /// <value>Specifies whether to just create an invoice, or to create an invoice and collect payment.</value>
        [DataMember(Name = "collection_method")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// The date printed on billing documents.
        /// </summary>
        /// <value>The date printed on billing documents.</value>
        [DataMember(Name = "document_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_date")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// Gets or Sets DraftInvoice
        /// </summary>
        [DataMember(Name = "draft_invoice")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "draft_invoice")]
        public bool? DraftInvoice { get; set; }

        /// <summary>
        /// Gets or Sets PaymentGatewayId
        /// </summary>
        [DataMember(Name = "payment_gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_gateway_id")]
        public string PaymentGatewayId { get; set; }

        /// <summary>
        /// Payment method Id used to pay billing documents.
        /// </summary>
        /// <value>Payment method Id used to pay billing documents.</value>
        [DataMember(Name = "payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_id")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// Gets or Sets RefundReasonCode
        /// </summary>
        [DataMember(Name = "refund_reason_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refund_reason_code")]
        public string RefundReasonCode { get; set; }

        /// <summary>
        /// The target date for the order to be picked up by bill run for billing.
        /// </summary>
        /// <value>The target date for the order to be picked up by bill run for billing.</value>
        [DataMember(Name = "target_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target_date")]
        public DateTime? TargetDate { get; set; }

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
            sb.Append("class ProcessingOptions {\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  CollectionMethod: ").Append(CollectionMethod).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  DraftInvoice: ").Append(DraftInvoice).Append("\n");
            sb.Append("  PaymentGatewayId: ").Append(PaymentGatewayId).Append("\n");
            sb.Append("  RefundReasonCode: ").Append(RefundReasonCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}