using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentMethodVerificationRequest
    {
        /// <summary>
        /// Three-letter ISO currency code.
        /// </summary>
        /// <value>Three-letter ISO currency code.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A hash containing gateway-specific parameters.
        /// </summary>
        /// <value>A hash containing gateway-specific parameters.</value>
        [DataMember(Name = "gateway_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gateway_options")]
        public Dictionary<string, string> GatewayOptions { get; set; }

        /// <summary>
        /// The name of the payment gateway instance. If no value is specified for this field, the default payment gateway of your Zuora tenant will be used.
        /// </summary>
        /// <value>The name of the payment gateway instance. If no value is specified for this field, the default payment gateway of your Zuora tenant will be used.</value>
        [DataMember(Name = "payment_gateway")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_gateway")]
        public string PaymentGateway { get; set; }

        /// <summary>
        /// Card security code.
        /// </summary>
        /// <value>Card security code.</value>
        [DataMember(Name = "security_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "security_code")]
        public string SecurityCode { get; set; }

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
            sb.Append("class PaymentMethodVerificationRequest {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
            sb.Append("  GatewayOptions: ").Append(GatewayOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}