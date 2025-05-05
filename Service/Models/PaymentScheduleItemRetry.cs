using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentScheduleItemRetry
    {
        /// <summary>
        /// ID of the payment gateway used to collect payments. The default value is the account's default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant's default payment gateway ID. This field will be ignored when `items` is specified.
        /// </summary>
        /// <value>ID of the payment gateway used to collect payments. The default value is the account's default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant's default payment gateway ID. This field will be ignored when `items` is specified.</value>
        [DataMember(Name = "payment_gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_gateway_id")]
        public string PaymentGatewayId { get; set; }

        /// <summary>
        /// ID of the payment method. The default value is the account's default payment method ID. This field will be ignored when `items` is specified.
        /// </summary>
        /// <value>ID of the payment method. The default value is the account's default payment method ID. This field will be ignored when `items` is specified.</value>
        [DataMember(Name = "payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_id")]
        public string PaymentMethodId { get; set; }

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
            sb.Append("class PaymentScheduleItemRetry {\n");
            sb.Append("  PaymentGatewayId: ").Append(PaymentGatewayId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}