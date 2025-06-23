using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentMethodAuthorizationResponse
    {
        /// <summary>
        /// Identifier of the authorization transaction from the payment gateway.
        /// </summary>
        /// <value>Identifier of the authorization transaction from the payment gateway.</value>
        [DataMember(Name = "auth_transaction_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auth_transaction_id")]
        public string AuthTransactionId { get; set; }

        /// <summary>
        /// A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the payment number will be passed in instead. Gateways check duplicates on the gateway order ID to ensure that the merchant do not accidentally enter the same transaction twice. This ID can also be used to do reconciliation and tie the payment to a natural key in external systems. The source of this ID varies by merchant. Some merchants use their shopping cart order IDs, and others use something different. Merchants use this ID to track transactions in their eCommerce systems. When you create a payment for capturing the authorized funds, it is highly recommended to pass in the `gateway_order_id` that you used when authorizing the funds by using the Create authorization operation, together with the `authorization_id` field.
        /// </summary>
        /// <value>A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the payment number will be passed in instead. Gateways check duplicates on the gateway order ID to ensure that the merchant do not accidentally enter the same transaction twice. This ID can also be used to do reconciliation and tie the payment to a natural key in external systems. The source of this ID varies by merchant. Some merchants use their shopping cart order IDs, and others use something different. Merchants use this ID to track transactions in their eCommerce systems. When you create a payment for capturing the authorized funds, it is highly recommended to pass in the `gateway_order_id` that you used when authorizing the funds by using the Create authorization operation, together with the `authorization_id` field.</value>
        [DataMember(Name = "gateway_order_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_order_id")]
        public string GatewayOrderId { get; set; }

        /// <summary>
        /// The status of the payment authorization.
        /// </summary>
        /// <value>The status of the payment authorization.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

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
            sb.Append("class PaymentMethodAuthorizationResponse {\n");
            sb.Append("  AuthTransactionId: ").Append(AuthTransactionId).Append("\n");
            sb.Append("  GatewayOrderId: ").Append(GatewayOrderId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}