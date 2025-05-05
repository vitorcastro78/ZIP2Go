using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Refund
    {
        /// <summary>
        /// The account that owns the refund
        /// </summary>
        /// <value>The account that owns the refund</value>
        [DataMember(Name = "account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account")]
        public Account Account { get; set; }

        /// <summary>
        /// Identifier of the customer this refund is for, if one exists.
        /// </summary>
        /// <value>Identifier of the customer this refund is for, if one exists.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Refund amount.
        /// </summary>
        /// <value>Refund amount.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets AppliedTo
        /// </summary>
        [DataMember(Name = "applied_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applied_to")]
        public List<RefundsAppliedTo> AppliedTo { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "bank_account_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_account_account")]
        public string BankAccountAccount { get; set; }

        /// <summary>
        /// Comments about the refund.
        /// </summary>
        /// <value>Comments about the refund.</value>
        [DataMember(Name = "comment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "comment")]
        public string Comment { get; set; }

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
        /// The related credit memo.
        /// </summary>
        /// <value>The related credit memo.</value>
        [DataMember(Name = "credit_memo")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo")]
        public CreditMemo CreditMemo { get; set; }

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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// If true, indicates that this refund is not handled by Zuora.
        /// </summary>
        /// <value>If true, indicates that this refund is not handled by Zuora.</value>
        [DataMember(Name = "external")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "external")]
        public bool? External { get; set; }

        /// <summary>
        /// Identifier of the payment gateway that Zuora will use to authorize the payments that are made with this payment method. If you do not set this field, Zuora will use one of the following payment gateways instead: The default payment gateway of the customer account that owns the payment method, if the payment method is associated with a customer account or the default payment gateway of your Zuora tenant.
        /// </summary>
        /// <value>Identifier of the payment gateway that Zuora will use to authorize the payments that are made with this payment method. If you do not set this field, Zuora will use one of the following payment gateways instead: The default payment gateway of the customer account that owns the payment method, if the payment method is associated with a customer account or the default payment gateway of your Zuora tenant.</value>
        [DataMember(Name = "gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_id")]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or Sets GatewayOptions
        /// </summary>
        [DataMember(Name = "gateway_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_options")]
        public GatewayOptions GatewayOptions { get; set; }

        /// <summary>
        /// Gateway reconciliation reason.
        /// </summary>
        /// <value>Gateway reconciliation reason.</value>
        [DataMember(Name = "gateway_reconciliation_reason")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_reconciliation_reason")]
        public string GatewayReconciliationReason { get; set; }

        /// <summary>
        /// Gateway reconciliation state.
        /// </summary>
        /// <value>Gateway reconciliation state.</value>
        [DataMember(Name = "gateway_reconciliation_status")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_reconciliation_status")]
        public string GatewayReconciliationStatus { get; set; }

        /// <summary>
        /// Message returned by the payment gateway for this refund.
        /// </summary>
        /// <value>Message returned by the payment gateway for this refund.</value>
        [DataMember(Name = "gateway_response")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_response")]
        public string GatewayResponse { get; set; }

        /// <summary>
        /// Code returned by the payment gateway for this refund.
        /// </summary>
        /// <value>Code returned by the payment gateway for this refund.</value>
        [DataMember(Name = "gateway_response_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_response_code")]
        public string GatewayResponseCode { get; set; }

        /// <summary>
        /// The payment gateway state of the refund.
        /// </summary>
        /// <value>The payment gateway state of the refund.</value>
        [DataMember(Name = "gateway_state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_state")]
        public string GatewayState { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "on_account_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "on_account_account")]
        public string OnAccountAccount { get; set; }

        /// <summary>
        /// Identifier for the payment, either `payment_number` or `payment_id.
        /// </summary>
        /// <value>Identifier for the payment, either `payment_number` or `payment_id.</value>
        [DataMember(Name = "payment_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Identifier of the payment method used to create this refund.
        /// </summary>
        /// <value>Identifier of the payment method used to create this refund.</value>
        [DataMember(Name = "payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_id")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// Identifier of the payout from the payment gateway.
        /// </summary>
        /// <value>Identifier of the payout from the payment gateway.</value>
        [DataMember(Name = "payout_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payout_id")]
        public string PayoutId { get; set; }

        /// <summary>
        /// User-provided reason for the refund.
        /// </summary>
        /// <value>User-provided reason for the refund.</value>
        [DataMember(Name = "reason_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Transaction identifier returned by the payment gateway. You may use this field to reconcile refunds between your payment gateway and Zuora Payments.
        /// </summary>
        /// <value>Transaction identifier returned by the payment gateway. You may use this field to reconcile refunds between your payment gateway and Zuora Payments.</value>
        [DataMember(Name = "reference_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reference_id")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The date when the refund takes effect.
        /// </summary>
        /// <value>The date when the refund takes effect.</value>
        [DataMember(Name = "refund_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refund_date")]
        public DateTime? RefundDate { get; set; }

        /// <summary>
        /// Gets or Sets RefundMethodType
        /// </summary>
        [DataMember(Name = "refund_method_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refund_method_type")]
        public string RefundMethodType { get; set; }

        /// <summary>
        /// Human-readable identifier for this object; may be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier for this object; may be user-supplied.</value>
        [DataMember(Name = "refund_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "refund_number")]
        public string RefundNumber { get; set; }

        /// <summary>
        /// A second transaction identifier returned by the payment gateway if there is an additional transaction for the refunds. You may use this field to reconcile payments between your payment gateway and Zuora Payments.
        /// </summary>
        /// <value>A second transaction identifier returned by the payment gateway if there is an additional transaction for the refunds. You may use this field to reconcile payments between your payment gateway and Zuora Payments.</value>
        [DataMember(Name = "second_reference_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "second_reference_id")]
        public string SecondReferenceId { get; set; }

        /// <summary>
        /// The state of the refund.
        /// </summary>
        /// <value>The state of the refund.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// A payment gateway-specific field used by Orbital, Vantiv and Verifi.
        /// </summary>
        /// <value>A payment gateway-specific field used by Orbital, Vantiv and Verifi.</value>
        [DataMember(Name = "statement_descriptor")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A payment gateway-specific field used by Orbital, Vantiv and Verifi.
        /// </summary>
        /// <value>A payment gateway-specific field used by Orbital, Vantiv and Verifi.</value>
        [DataMember(Name = "statement_descriptor_phone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statement_descriptor_phone")]
        public string StatementDescriptorPhone { get; set; }

        /// <summary>
        /// Gets or Sets StateTransitions
        /// </summary>
        [DataMember(Name = "state_transitions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state_transitions")]
        public RefundStateTransitions StateTransitions { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "unapplied_payment_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unapplied_payment_account")]
        public string UnappliedPaymentAccount { get; set; }

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
            sb.Append("class Refund {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GatewayOptions: ").Append(GatewayOptions).Append("\n");
            sb.Append("  RefundDate: ").Append(RefundDate).Append("\n");
            sb.Append("  RefundMethodType: ").Append(RefundMethodType).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  StatementDescriptorPhone: ").Append(StatementDescriptorPhone).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  SecondReferenceId: ").Append(SecondReferenceId).Append("\n");
            sb.Append("  BankAccountAccount: ").Append(BankAccountAccount).Append("\n");
            sb.Append("  OnAccountAccount: ").Append(OnAccountAccount).Append("\n");
            sb.Append("  UnappliedPaymentAccount: ").Append(UnappliedPaymentAccount).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  CreditMemo: ").Append(CreditMemo).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  GatewayResponse: ").Append(GatewayResponse).Append("\n");
            sb.Append("  GatewayResponseCode: ").Append(GatewayResponseCode).Append("\n");
            sb.Append("  GatewayState: ").Append(GatewayState).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  RefundNumber: ").Append(RefundNumber).Append("\n");
            sb.Append("  StateTransitions: ").Append(StateTransitions).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  GatewayReconciliationReason: ").Append(GatewayReconciliationReason).Append("\n");
            sb.Append("  GatewayReconciliationStatus: ").Append(GatewayReconciliationStatus).Append("\n");
            sb.Append("  PayoutId: ").Append(PayoutId).Append("\n");
            sb.Append("  AppliedTo: ").Append(AppliedTo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}