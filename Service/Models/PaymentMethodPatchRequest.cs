using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentMethodPatchRequest
    {
        /// <summary>
        /// A customer account identifier.
        /// </summary>
        /// <value>A customer account identifier.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// A human-readable customer account identifier. It can be user-supplied.
        /// </summary>
        /// <value>A human-readable customer account identifier. It can be user-supplied.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// If this is an ach_debit payment method, this hash contains details about the ACH debit bank account.
        /// </summary>
        /// <value>If this is an ach_debit payment method, this hash contains details about the ACH debit bank account.</value>
        [DataMember(Name = "ach_debit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ach_debit")]
        public AllOfpaymentMethodPatchRequestAchDebit AchDebit { get; set; }

        /// <summary>
        /// Gets or Sets BillingDetails
        /// </summary>
        [DataMember(Name = "billing_details")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_details")]
        public BillingDetails BillingDetails { get; set; }

        /// <summary>
        /// Credit card information. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora.js instead of interacting with this API directly.
        /// </summary>
        /// <value>Credit card information. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora.js instead of interacting with this API directly.</value>
        [DataMember(Name = "card")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "card")]
        public AllOfpaymentMethodPatchRequestCard Card { get; set; }

        /// <summary>
        /// Credit Card Reference Transaction. See Supported payment methods for payment gateways that support this type of payment method.
        /// </summary>
        /// <value>Credit Card Reference Transaction. See Supported payment methods for payment gateways that support this type of payment method.</value>
        [DataMember(Name = "cc_ref")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cc_ref")]
        public AllOfpaymentMethodPatchRequestCcRef CcRef { get; set; }

        /// <summary>
        /// 3-letter ISO 4217 currency code.
        /// </summary>
        /// <value>3-letter ISO 4217 currency code.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Identifier of the device browser session.
        /// </summary>
        /// <value>Identifier of the device browser session.</value>
        [DataMember(Name = "device_session_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "device_session_id")]
        public string DeviceSessionId { get; set; }

        /// <summary>
        /// Identifier of the payment gateway Zuora will use to authorize the payments that are made with this payment method.
        /// </summary>
        /// <value>Identifier of the payment gateway Zuora will use to authorize the payments that are made with this payment method.</value>
        [DataMember(Name = "gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_id")]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or Sets GatewayOptions
        /// </summary>
        [DataMember(Name = "gateway_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_options")]
        public Dictionary<string, string> GatewayOptions { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name = "mandate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mandate")]
        public AllOfpaymentMethodPatchRequestMandate Mandate { get; set; }

        /// <summary>
        /// Maximum number of consecutive failed retry payment attempts using this payment method before retries are stopped.
        /// </summary>
        /// <value>Maximum number of consecutive failed retry payment attempts using this payment method before retries are stopped.</value>
        [DataMember(Name = "maximum_payment_attempts")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximum_payment_attempts")]
        public decimal? MaximumPaymentAttempts { get; set; }

        /// <summary>
        /// The retry interval in hours.
        /// </summary>
        /// <value>The retry interval in hours.</value>
        [DataMember(Name = "payment_retry_interval")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_retry_interval")]
        public int? PaymentRetryInterval { get; set; }

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
            sb.Append("class PaymentMethodPatchRequest {\n");
            sb.Append("  BillingDetails: ").Append(BillingDetails).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  CcRef: ").Append(CcRef).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("  AchDebit: ").Append(AchDebit).Append("\n");
            sb.Append("  MaximumPaymentAttempts: ").Append(MaximumPaymentAttempts).Append("\n");
            sb.Append("  PaymentRetryInterval: ").Append(PaymentRetryInterval).Append("\n");
            sb.Append("  DeviceSessionId: ").Append(DeviceSessionId).Append("\n");
            sb.Append("  GatewayOptions: ").Append(GatewayOptions).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}