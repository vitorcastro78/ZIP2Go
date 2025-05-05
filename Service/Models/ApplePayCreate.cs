using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// If the &#x60;type&#x60; of the payment method is &#x60;apple_pay&#x60;, this hash contains details about the Apple Pay payment method. See [Supported payment methods](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/L_Payment_Methods/A_Supported_Payment_Methods) for payment gateways that support this type of payment method.
    /// </summary>
    [DataContract]
    public class ApplePayCreate
    {
        /// <summary>
        /// A boolean flag to control whether a payment should be processed       after creating payment method. The payment amount will be equivalent to       the amount the merchant supplied in the ApplePay session. Default is false.        If this field is set to `true`, you must specify the `gateway_id`       field with the payment gateway instance name.  If this field is set       to `false`:   - The default payment gateway of your Zuora customer account       will be used no matter whether a payment gateway instance is specified       in the `gateway_id` field.    - You must select the **Verify new       credit card** check box on the gateway instance settings page. Otherwise,       the cryptogram will not be sent to the gateway.   - A separate subscribe       or payment API call is required after this payment method creation call.
        /// </summary>
        /// <value>A boolean flag to control whether a payment should be processed       after creating payment method. The payment amount will be equivalent to       the amount the merchant supplied in the ApplePay session. Default is false.        If this field is set to `true`, you must specify the `gateway_id`       field with the payment gateway instance name.  If this field is set       to `false`:   - The default payment gateway of your Zuora customer account       will be used no matter whether a payment gateway instance is specified       in the `gateway_id` field.    - You must select the **Verify new       credit card** check box on the gateway instance settings page. Otherwise,       the cryptogram will not be sent to the gateway.   - A separate subscribe       or payment API call is required after this payment method creation call. </value>
        [DataMember(Name = "collect_payment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "collect_payment")]
        public bool? CollectPayment { get; set; }

        /// <summary>
        /// The complete JSON Object representing the encrypted payment token payload returned in the response from the Apple Pay session.
        /// </summary>
        /// <value>The complete JSON Object representing the encrypted payment token payload returned in the response from the Apple Pay session.</value>
        [DataMember(Name = "customer_token")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customer_token")]
        public Dictionary<string, Object> CustomerToken { get; set; }

        /// <summary>
        /// The Merchant ID that was configured for use with Apple Pay in the Apple iOS Developer Center.
        /// </summary>
        /// <value>The Merchant ID that was configured for use with Apple Pay in the Apple iOS Developer Center.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The id of invoice this payment will apply to.      Note: When `collect_payment` is true, this field is required.      Only one invoice can be paid; for scenarios where you want to pay for multiple invoices, set collect_payment to false and use [Create Payment](#operation/createPayment) API separately.
        /// </summary>
        /// <value>The id of invoice this payment will apply to.      Note: When `collect_payment` is true, this field is required.      Only one invoice can be paid; for scenarios where you want to pay for multiple invoices, set collect_payment to false and use [Create Payment](#operation/createPayment) API separately.</value>
        [DataMember(Name = "invoice_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name = "mandate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mandate")]
        public Mandate Mandate { get; set; }

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
            sb.Append("class ApplePayCreate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomerToken: ").Append(CustomerToken).Append("\n");
            sb.Append("  CollectPayment: ").Append(CollectPayment).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}