using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentRunSummary
    {
        /// <summary>
        /// The total number of all receivables with payments not processed.
        /// </summary>
        /// <value>The total number of all receivables with payments not processed.</value>
        [DataMember(Name = "errors_total")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errors_total")]
        public int? ErrorsTotal { get; set; }

        /// <summary>
        /// The total number of all invoices.
        /// </summary>
        /// <value>The total number of all invoices.</value>
        [DataMember(Name = "invoices_total")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoices_total")]
        public int? InvoicesTotal { get; set; }

        /// <summary>
        /// The number of credit memos processed.
        /// </summary>
        /// <value>The number of credit memos processed.</value>
        [DataMember(Name = "number_of_credit_memos")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_credit_memos")]
        public int? NumberOfCreditMemos { get; set; }

        /// <summary>
        /// The number of debit memos processed.
        /// </summary>
        /// <value>The number of debit memos processed.</value>
        [DataMember(Name = "number_of_debit_memos")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_debit_memos")]
        public int? NumberOfDebitMemos { get; set; }

        /// <summary>
        /// The number of payments not processed.
        /// </summary>
        /// <value>The number of payments not processed.</value>
        [DataMember(Name = "number_of_errors")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_errors")]
        public int? NumberOfErrors { get; set; }

        /// <summary>
        /// The number of invoices processed.
        /// </summary>
        /// <value>The number of invoices processed.</value>
        [DataMember(Name = "number_of_invoices")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_invoices")]
        public int? NumberOfInvoices { get; set; }

        /// <summary>
        /// The number of payments processed.
        /// </summary>
        /// <value>The number of payments processed.</value>
        [DataMember(Name = "number_of_payments")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_payments")]
        public int? NumberOfPayments { get; set; }

        /// <summary>
        /// The number of unapplied payments.
        /// </summary>
        /// <value>The number of unapplied payments.</value>
        [DataMember(Name = "number_of_unapplied_payments")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_unapplied_payments")]
        public int? NumberOfUnappliedPayments { get; set; }

        /// <summary>
        /// The number of unprocessed debit memos.
        /// </summary>
        /// <value>The number of unprocessed debit memos.</value>
        [DataMember(Name = "number_of_unprocessed_debit_memos")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_unprocessed_debit_memos")]
        public int? NumberOfUnprocessedDebitMemos { get; set; }

        /// <summary>
        /// The number of receivables with positive remamining balances.
        /// </summary>
        /// <value>The number of receivables with positive remamining balances.</value>
        [DataMember(Name = "number_of_unprocessed_receivables")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_unprocessed_receivables")]
        public int? NumberOfUnprocessedReceivables { get; set; }

        /// <summary>
        /// The total number of all processed and unapplied payments.
        /// </summary>
        /// <value>The total number of all processed and unapplied payments.</value>
        [DataMember(Name = "payments_total")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payments_total")]
        public int? PaymentsTotal { get; set; }

        /// <summary>
        /// The total number of positive remaining balances of all receivables.
        /// </summary>
        /// <value>The total number of positive remaining balances of all receivables.</value>
        [DataMember(Name = "unprocessed_receivables_total")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unprocessed_receivables_total")]
        public int? UnprocessedReceivablesTotal { get; set; }

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
            sb.Append("class PaymentRunSummary {\n");
            sb.Append("  NumberOfErrors: ").Append(NumberOfErrors).Append("\n");
            sb.Append("  NumberOfInvoices: ").Append(NumberOfInvoices).Append("\n");
            sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
            sb.Append("  NumberOfCreditMemos: ").Append(NumberOfCreditMemos).Append("\n");
            sb.Append("  NumberOfDebitMemos: ").Append(NumberOfDebitMemos).Append("\n");
            sb.Append("  NumberOfUnprocessedDebitMemos: ").Append(NumberOfUnprocessedDebitMemos).Append("\n");
            sb.Append("  NumberOfUnappliedPayments: ").Append(NumberOfUnappliedPayments).Append("\n");
            sb.Append("  NumberOfUnprocessedReceivables: ").Append(NumberOfUnprocessedReceivables).Append("\n");
            sb.Append("  ErrorsTotal: ").Append(ErrorsTotal).Append("\n");
            sb.Append("  InvoicesTotal: ").Append(InvoicesTotal).Append("\n");
            sb.Append("  PaymentsTotal: ").Append(PaymentsTotal).Append("\n");
            sb.Append("  UnprocessedReceivablesTotal: ").Append(UnprocessedReceivablesTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}