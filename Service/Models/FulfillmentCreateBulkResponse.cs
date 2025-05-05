using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FulfillmentCreateBulkResponse
    {
        /// <summary>
        /// The total amount collected by this request.
        /// </summary>
        /// <value>The total amount collected by this request.</value>
        [DataMember(Name = "amount_paid")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_paid")]
        public decimal? AmountPaid { get; set; }

        /// <summary>
        /// Human-readable identifiers of any credit memos associated with this request.
        /// </summary>
        /// <value>Human-readable identifiers of any credit memos associated with this request.</value>
        [DataMember(Name = "credit_memo_numbers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo_numbers")]
        public List<string> CreditMemoNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "data")]
        public List<Fulfillment> Data { get; set; }

        /// <summary>
        /// Human-readable identifiers of any invoices associated with this request.
        /// </summary>
        /// <value>Human-readable identifiers of any invoices associated with this request.</value>
        [DataMember(Name = "invoice_numbers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_numbers")]
        public List<string> InvoiceNumbers { get; set; }

        /// <summary>
        /// Human-readable identifier of the payment associated with this fulfillment.
        /// </summary>
        /// <value>Human-readable identifier of the payment associated with this fulfillment.</value>
        [DataMember(Name = "payment_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_number")]
        public string PaymentNumber { get; set; }

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
            sb.Append("class FulfillmentCreateBulkResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
            sb.Append("  CreditMemoNumbers: ").Append(CreditMemoNumbers).Append("\n");
            sb.Append("  InvoiceNumbers: ").Append(InvoiceNumbers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}