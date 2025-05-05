using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// If the &#x60;type&#x60; of the payment method is &#x60;cc_ref&#x60;, this hash contains details about the Credit Card Reference Transactions payment method. See [Supported payment methods](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/L_Payment_Methods/A_Supported_Payment_Methods) for payment gateways that support this type of payment method.
    /// </summary>
    [DataContract]
    public class CcRef
    {
        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "card")]
        public CcRefCard Card { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name = "mandate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mandate")]
        public Mandate Mandate { get; set; }

        /// <summary>
        /// A gateway unique identifier that replaces sensitive payment method data. This field is conditionally required only when `token` is being used to represent a gateway customer profile.
        /// </summary>
        /// <value>A gateway unique identifier that replaces sensitive payment method data. This field is conditionally required only when `token` is being used to represent a gateway customer profile.</value>
        [DataMember(Name = "second_token")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "second_token")]
        public string SecondToken { get; set; }

        /// <summary>
        /// A gateway unique identifier that replaces sensitive payment method data or represents a gateway's unique customer profile. When `token` is used to represent a customer profile, `second_token` is conditionally required for representing the underlying tokenized payment method.
        /// </summary>
        /// <value>A gateway unique identifier that replaces sensitive payment method data or represents a gateway's unique customer profile. When `token` is used to represent a customer profile, `second_token` is conditionally required for representing the underlying tokenized payment method.</value>
        [DataMember(Name = "token")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "token")]
        public string Token { get; set; }

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
            sb.Append("class CcRef {\n");
            sb.Append("  SecondToken: ").Append(SecondToken).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}