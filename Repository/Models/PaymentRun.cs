using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentRun
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
        public int? BillCycleDay { get; set; }

        /// <summary>
        /// The unique identifier of a bill run.
        /// </summary>
        /// <value>The unique identifier of a bill run.</value>
        [DataMember(Name = "bill_run_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_run_id")]
        public string BillRunId { get; set; }

        /// <summary>
        /// Indicates whether to process electronic payments during the execution of payment runs.
        /// </summary>
        /// <value>Indicates whether to process electronic payments during the execution of payment runs.</value>
        [DataMember(Name = "collect_payment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "collect_payment")]
        public bool? CollectPayment { get; set; }

        /// <summary>
        /// If true, a single payment will be collected for all receivables due on an account.
        /// </summary>
        /// <value>If true, a single payment will be collected for all receivables due on an account.</value>
        [DataMember(Name = "consolidate_payment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "consolidate_payment")]
        public bool? ConsolidatePayment { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public string CreatedById { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Three-letter ISO currency code.
        /// </summary>
        /// <value>Three-letter ISO currency code.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public CustomObject CustomObjects { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets PaymentCollectionDate
        /// </summary>
        [DataMember(Name = "payment_collection_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_collection_date")]
        public DateTime? PaymentCollectionDate { get; set; }

        /// <summary>
        /// Unique identifier for the payment gateway.
        /// </summary>
        /// <value>Unique identifier for the payment gateway.</value>
        [DataMember(Name = "payment_gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_gateway_id")]
        public string PaymentGatewayId { get; set; }

        /// <summary>
        /// The date and time when the scheduled payment run is to be executed, in `yyyy-mm-dd hh:mm:ss` format.
        /// </summary>
        /// <value>The date and time when the scheduled payment run is to be executed, in `yyyy-mm-dd hh:mm:ss` format.</value>
        [DataMember(Name = "payment_run_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_run_date")]
        public DateTime? PaymentRunDate { get; set; }

        /// <summary>
        /// Human-readable identifier for this object.
        /// </summary>
        /// <value>Human-readable identifier for this object.</value>
        [DataMember(Name = "payment_run_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_run_number")]
        public string PaymentRunNumber { get; set; }

        /// <summary>
        /// Status of the payment run.
        /// </summary>
        /// <value>Status of the payment run.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// The date and time when the payment run executed, in the `yyyy-mm-dd hh:mm:ss` format.
        /// </summary>
        /// <value>The date and time when the payment run executed, in the `yyyy-mm-dd hh:mm:ss` format.</value>
        [DataMember(Name = "state_transitions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state_transitions")]
        public PaymentRunStateTransitions StateTransitions { get; set; }

        /// <summary>
        /// Summary of the payment run.
        /// </summary>
        /// <value>Summary of the payment run.</value>
        [DataMember(Name = "summary")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "summary")]
        public PaymentRunSummary Summary { get; set; }

        /// <summary>
        /// The target date used to determine which receivables to be paid in the payment run.       The payments are collected for all receivables with the due date no later than the target date.
        /// </summary>
        /// <value>The target date used to determine which receivables to be paid in the payment run.       The payments are collected for all receivables with the due date no later than the target date.</value>
        [DataMember(Name = "target_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target_date")]
        public DateTime? TargetDate { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public string UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

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
            sb.Append("class PaymentRun {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  ApplyCreditMemos: ").Append(ApplyCreditMemos).Append("\n");
            sb.Append("  ApplyUnappliedPayments: ").Append(ApplyUnappliedPayments).Append("\n");
            sb.Append("  Batch: ").Append(Batch).Append("\n");
            sb.Append("  ConsolidatePayment: ").Append(ConsolidatePayment).Append("\n");
            sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
            sb.Append("  BillRunId: ").Append(BillRunId).Append("\n");
            sb.Append("  CollectPayment: ").Append(CollectPayment).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  StateTransitions: ").Append(StateTransitions).Append("\n");
            sb.Append("  PaymentGatewayId: ").Append(PaymentGatewayId).Append("\n");
            sb.Append("  PaymentCollectionDate: ").Append(PaymentCollectionDate).Append("\n");
            sb.Append("  PaymentRunNumber: ").Append(PaymentRunNumber).Append("\n");
            sb.Append("  PaymentRunDate: ").Append(PaymentRunDate).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}