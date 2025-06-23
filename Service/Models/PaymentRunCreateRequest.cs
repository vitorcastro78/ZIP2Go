using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentRunCreateRequest
    {
        /// <summary>
        /// If true, any posted credit memos are applied first.
        /// </summary>
        /// <value>If true, any posted credit memos are applied first.</value>
        [DataMember(Name = "apply_credit_memos")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apply_credit_memos")]
        public bool? ApplyCreditMemos { get; set; }

        /// <summary>
        /// If true, any unapplied payments are applied first.
        /// </summary>
        /// <value>If true, any unapplied payments are applied first.</value>
        [DataMember(Name = "apply_unapplied_payments")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apply_unapplied_payments")]
        public bool? ApplyUnappliedPayments { get; set; }

        /// <summary>
        /// Identifier of the customer account batch to be included in this payment run.
        /// </summary>
        /// <value>Identifier of the customer account batch to be included in this payment run.</value>
        [DataMember(Name = "batch")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "batch")]
        public string Batch { get; set; }

        /// <summary>
        /// The day of the month to bill multiple customer accounts.
        /// </summary>
        /// <value>The day of the month to bill multiple customer accounts.</value>
        [DataMember(Name = "bill_cycle_day")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_cycle_day")]
        public string BillCycleDay { get; set; }

        /// <summary>
        /// The unique identifier of a bill run.
        /// </summary>
        /// <value>The unique identifier of a bill run.</value>
        [DataMember(Name = "bill_run_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_run_id")]
        public string BillRunId { get; set; }

        /// <summary>
        /// Indicates whether to process electronic payments during the execution of payment runs.       If the Payment user permission \"Process Electronic Payment\" is disabled, this field will be ignored.
        /// </summary>
        /// <value>Indicates whether to process electronic payments during the execution of payment runs.       If the Payment user permission \"Process Electronic Payment\" is disabled, this field will be ignored.</value>
        [DataMember(Name = "collect_payment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "collect_payment")]
        public bool? CollectPayment { get; set; }

        /// <summary>
        /// If true, a single payment will be collected for all receivables due on an account.
        /// </summary>
        /// <value>If true, a single payment will be collected for all receivables due on an account.</value>
        [DataMember(Name = "consolidated_payment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "consolidated_payment")]
        public bool? ConsolidatedPayment { get; set; }

        /// <summary>
        /// Three-letter ISO currency code.
        /// </summary>
        /// <value>Three-letter ISO currency code.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Unique identifier for the payment gateway.
        /// </summary>
        /// <value>Unique identifier for the payment gateway.</value>
        [DataMember(Name = "gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_id")]
        public string GatewayId { get; set; }

        /// <summary>
        /// The date and time when the scheduled payment run is to be executed, in `yyyy-mm-dd hh:mm:ss` format. The backend will ignore minutes and seconds in the field value. For example, if you specify `2017-03-01 11:30:37` for this value, this payment run will be run at 2017-03-01 11:00:00.      <br />       You must specify either the `payment_run_date` field or the `target_date` field in the request body.      If you specify the `payment_run_date` field, the scheduced payment run is to be executed on the specified payment run date. If you specify the `target_date` field, the payment run is executed immediately after it is created.
        /// </summary>
        /// <value>The date and time when the scheduled payment run is to be executed, in `yyyy-mm-dd hh:mm:ss` format. The backend will ignore minutes and seconds in the field value. For example, if you specify `2017-03-01 11:30:37` for this value, this payment run will be run at 2017-03-01 11:00:00.      <br />       You must specify either the `payment_run_date` field or the `target_date` field in the request body.      If you specify the `payment_run_date` field, the scheduced payment run is to be executed on the specified payment run date. If you specify the `target_date` field, the payment run is executed immediately after it is created.</value>
        [DataMember(Name = "payment_run_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_run_date")]
        public DateTime? PaymentRunDate { get; set; }

        /// <summary>
        /// The target date used to determine which receivables to be paid in the payment run.       The payments are collected for all receivables with the due date no later than the target date.
        /// </summary>
        /// <value>The target date used to determine which receivables to be paid in the payment run.       The payments are collected for all receivables with the due date no later than the target date.</value>
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
            sb.Append("class PaymentRunCreateRequest {\n");
            sb.Append("  ApplyCreditMemos: ").Append(ApplyCreditMemos).Append("\n");
            sb.Append("  ApplyUnappliedPayments: ").Append(ApplyUnappliedPayments).Append("\n");
            sb.Append("  Batch: ").Append(Batch).Append("\n");
            sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
            sb.Append("  BillRunId: ").Append(BillRunId).Append("\n");
            sb.Append("  CollectPayment: ").Append(CollectPayment).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ConsolidatedPayment: ").Append(ConsolidatedPayment).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  PaymentRunDate: ").Append(PaymentRunDate).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}