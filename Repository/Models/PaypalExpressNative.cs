using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// If it is a &#x60;paypal_express_native&#x60; payment method, this hash contains details about the PayPal Express Native payment method.
    /// </summary>
    [DataContract]
    public class PaypalExpressNative
    {
        /// <summary>
        /// Identifier of a PayPal billing agreement. For example, I-1TJ3GAGG82Y9.
        /// </summary>
        /// <value>Identifier of a PayPal billing agreement. For example, I-1TJ3GAGG82Y9.</value>
        [DataMember(Name = "baid")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "baid")]
        public string Baid { get; set; }

        /// <summary>
        /// Email address associated with the payment method. This is required with a paypal_express_checkout or a paypal_adaptive payment method.
        /// </summary>
        /// <value>Email address associated with the payment method. This is required with a paypal_express_checkout or a paypal_adaptive payment method.</value>
        [DataMember(Name = "email")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string Email { get; set; }

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
            sb.Append("class PaypalExpressNative {\n");
            sb.Append("  Baid: ").Append(Baid).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}