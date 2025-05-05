using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentMethodAuthorizationRequest
    {
        /// <summary>
        /// A customer account identifier. Either `account_id` or `account_number` is required.
        /// </summary>
        /// <value>A customer account identifier. Either `account_id` or `account_number` is required.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// A Human-readable customer account identifier. Either `account_id` or `account_number` is required.
        /// </summary>
        /// <value>A Human-readable customer account identifier. Either `account_id` or `account_number` is required.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Amount to be authorized.
        /// </summary>
        /// <value>Amount to be authorized.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Identifier of the payment gateway that Zuora will use to authorize the payments that are made with this payment method. If you do not set this field, Zuora will use one of the following payment gateways instead: The default payment gateway of the customer account that owns the payment method, if the payment method is associated with a customer account or the default payment gateway of your Zuora tenant.
        /// </summary>
        /// <value>Identifier of the payment gateway that Zuora will use to authorize the payments that are made with this payment method. If you do not set this field, Zuora will use one of the following payment gateways instead: The default payment gateway of the customer account that owns the payment method, if the payment method is associated with a customer account or the default payment gateway of your Zuora tenant.</value>
        [DataMember(Name = "gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_id")]
        public string GatewayId { get; set; }

        /// <summary>
        /// A hash containing gateway-specific parameters.
        /// </summary>
        /// <value>A hash containing gateway-specific parameters.</value>
        [DataMember(Name = "gateway_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_options")]
        public Dictionary<string, string> GatewayOptions { get; set; }

        /// <summary>
        /// A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the payment number will be passed in instead. Gateways check duplicates on the gateway order ID to ensure that the merchant do not accidentally enter the same transaction twice. This ID can also be used to do reconciliation and tie the payment to a natural key in external systems. The source of this ID varies by merchant. Some merchants use their shopping cart order IDs, and others use something different. Merchants use this ID to track transactions in their eCommerce systems. When you create a payment for capturing the authorized funds, it is highly recommended to pass in the `gateway_order_id` that you used when authorizing the funds by using the Create authorization operation, together with the `authorization_id` field.
        /// </summary>
        /// <value>A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the payment number will be passed in instead. Gateways check duplicates on the gateway order ID to ensure that the merchant do not accidentally enter the same transaction twice. This ID can also be used to do reconciliation and tie the payment to a natural key in external systems. The source of this ID varies by merchant. Some merchants use their shopping cart order IDs, and others use something different. Merchants use this ID to track transactions in their eCommerce systems. When you create a payment for capturing the authorized funds, it is highly recommended to pass in the `gateway_order_id` that you used when authorizing the funds by using the Create authorization operation, together with the `authorization_id` field.</value>
        [DataMember(Name = "gateway_order_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_order_id")]
        public string GatewayOrderId { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name = "mandate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mandate")]
        public AuthorizationMandate Mandate { get; set; }

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
            sb.Append("class PaymentMethodAuthorizationRequest {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  GatewayOptions: ").Append(GatewayOptions).Append("\n");
            sb.Append("  GatewayOrderId: ").Append(GatewayOrderId).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  StatementDescriptorPhone: ").Append(StatementDescriptorPhone).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}