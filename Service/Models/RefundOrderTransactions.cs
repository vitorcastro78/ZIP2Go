using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class RefundOrderTransactions
    {
        /// <summary>
        /// The numbers of the related invoices.
        /// </summary>
        /// <value>The numbers of the related invoices.</value>
        [DataMember(Name = "invoice_numbers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_numbers")]
        public List<string> InvoiceNumbers { get; set; }

        /// <summary>
        /// The number of the refund.
        /// </summary>
        /// <value>The number of the refund.</value>
        [DataMember(Name = "number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number")]
        public string Number { get; set; }

        /// <summary>
        /// The related invoices.
        /// </summary>
        /// <value>The related invoices.</value>
        [DataMember(Name = "refunds")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refunds")]
        public AllOfrefundOrderTransactionsRefunds Refunds { get; set; }

        /// <summary>
        /// The states of the refunds.
        /// </summary>
        /// <value>The states of the refunds.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public AllOfrefundOrderTransactionsState State { get; set; }

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
            sb.Append("class RefundOrderTransactions {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  InvoiceNumbers: ").Append(InvoiceNumbers).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}