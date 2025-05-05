using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ArTransactionsOrders
    {
        /// <summary>
        /// The numbers of related credit memos.
        /// </summary>
        /// <value>The numbers of related credit memos.</value>
        [DataMember(Name = "credit_memo_numbers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo_numbers")]
        public List<string> CreditMemoNumbers { get; set; }

        /// <summary>
        /// The related credit memos.
        /// </summary>
        /// <value>The related credit memos.</value>
        [DataMember(Name = "credit_memos")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memos")]
        public List<CreditMemo> CreditMemos { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The numbers of related invoices
        /// </summary>
        /// <value>The numbers of related invoices</value>
        [DataMember(Name = "invoice_numbers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_numbers")]
        public List<string> InvoiceNumbers { get; set; }

        /// <summary>
        /// The related invoices.
        /// </summary>
        /// <value>The related invoices.</value>
        [DataMember(Name = "invoices")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoices")]
        public List<Invoice> Invoices { get; set; }

        /// <summary>
        /// The related payments.
        /// </summary>
        /// <value>The related payments.</value>
        [DataMember(Name = "payments")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payments")]
        public List<PaymentTransactions> Payments { get; set; }

        /// <summary>
        /// The related refunds.
        /// </summary>
        /// <value>The related refunds.</value>
        [DataMember(Name = "refunds")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refunds")]
        public List<RefundOrderTransactions> Refunds { get; set; }

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
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArTransactionsOrders {\n");
            sb.Append("  CreditMemoNumbers: ").Append(CreditMemoNumbers).Append("\n");
            sb.Append("  CreditMemos: ").Append(CreditMemos).Append("\n");
            sb.Append("  InvoiceNumbers: ").Append(InvoiceNumbers).Append("\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}