using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ArTransactions
    {
        /// <summary>
        /// Credit memo numbers.
        /// </summary>
        /// <value>Credit memo numbers.</value>
        [DataMember(Name = "credit_memo_numbers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo_numbers")]
        public List<string> CreditMemoNumbers { get; set; }

        /// <summary>
        /// The related credit memos.
        /// </summary>
        /// <value>The related credit memos.</value>
        [DataMember(Name = "credit_memos")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memos")]
        public AllOfarTransactionsCreditMemos CreditMemos { get; set; }

        /// <summary>
        /// The related invoice numbers.
        /// </summary>
        /// <value>The related invoice numbers.</value>
        [DataMember(Name = "invoice_numbers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_numbers")]
        public List<string> InvoiceNumbers { get; set; }

        /// <summary>
        /// The related invoices.
        /// </summary>
        /// <value>The related invoices.</value>
        [DataMember(Name = "invoices")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoices")]
        public AllOfarTransactionsInvoices Invoices { get; set; }

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
        public List<RefundTransactions> Refunds { get; set; }

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
            sb.Append("class ArTransactions {\n");
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