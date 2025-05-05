using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// If the &#x60;type&#x60; of the payment method is &#x60;google_pay&#x60;, this hash contains details about the Google Pay payment method. See [Supported payment methods](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/L_Payment_Methods/A_Supported_Payment_Methods) for payment gateways that support this type of payment method.
    /// </summary>
    [DataContract]
    public class GooglePayCreate
    {
        /// <summary>
        /// The complete JSON Object representing the encrypted payment token payload returned in the response from the Google Pay session.
        /// </summary>
        /// <value>The complete JSON Object representing the encrypted payment token payload returned in the response from the Google Pay session.</value>
        [DataMember(Name = "customer_token")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customer_token")]
        public CustomerToken CustomerToken { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

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
            sb.Append("class GooglePayCreate {\n");
            sb.Append("  CustomerToken: ").Append(CustomerToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}