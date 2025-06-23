using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class RefundCreateRequest
    {
        /// <summary>
        /// Refund amount.
        /// </summary>
        /// <value>Refund amount.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "bank_account_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_account_account")]
        public string BankAccountAccount { get; set; }

        /// <summary>
        /// Indicates to which billing documents (invoices or debit memos) is the refund applied.
        /// </summary>
        /// <value>Indicates to which billing documents (invoices or debit memos) is the refund applied.</value>
        [DataMember(Name = "billing_documents")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_documents")]
        public List<BillingDocumentPaymentApplicationRequest> BillingDocuments { get; set; }

        /// <summary>
        /// The related credit memo.
        /// </summary>
        /// <value>The related credit memo.</value>
        [DataMember(Name = "credit_memo")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo")]
        public AllOfrefundCreateRequestCreditMemo CreditMemo { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

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
        /// Gets or Sets GatewayOptions
        /// </summary>
        [DataMember(Name = "gateway_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_options")]
        public Dictionary<string, string> GatewayOptions { get; set; }

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
        /// Identifier of the payment method used to create this refund.
        /// </summary>
        /// <value>Identifier of the payment method used to create this refund.</value>
        [DataMember(Name = "payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_id")]
        public string PaymentMethodId { get; set; }

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
        /// A second transaction identifier returned by the payment gateway if there is an additional transaction for the refunds. You may use this field to reconcile payments between your payment gateway and Zuora Payments.
        /// </summary>
        /// <value>A second transaction identifier returned by the payment gateway if there is an additional transaction for the refunds. You may use this field to reconcile payments between your payment gateway and Zuora Payments.</value>
        [DataMember(Name = "second_reference_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "second_reference_id")]
        public string SecondReferenceId { get; set; }

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
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "unapplied_payment_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unapplied_payment_account")]
        public string UnappliedPaymentAccount { get; set; }

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
            sb.Append("class RefundCreateRequest {\n");
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
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  CreditMemo: ").Append(CreditMemo).Append("\n");
            sb.Append("  BillingDocuments: ").Append(BillingDocuments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}