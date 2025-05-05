using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// If it is a &#x60;paypal_adaptive&#x60; payment method, this hash contains details about the PayPal Adaptive payment method.
    /// </summary>
    [DataContract]
    public class PaypalAdaptive
    {
        /// <summary>
        /// Email address associated with the payment method.
        /// </summary>
        /// <value>Email address associated with the payment method.</value>
        [DataMember(Name = "email")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// PayPal preapproval key.
        /// </summary>
        /// <value>PayPal preapproval key.</value>
        [DataMember(Name = "preapproval_key")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preapproval_key")]
        public string PreapprovalKey { get; set; }

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
            sb.Append("class PaypalAdaptive {\n");
            sb.Append("  PreapprovalKey: ").Append(PreapprovalKey).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}