using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Credit card information. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora&#x27;s [Payment Pages 2.0](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/LA_Hosted_Payment_Pages/B_Payment_Pages_2.0) instead of interacting with this API directly.
    /// </summary>
    [DataContract]
    public class Card
    {
        /// <summary>
        /// Card brand.
        /// </summary>
        /// <value>Card brand.</value>
        [DataMember(Name = "brand")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        /// <value>The card number, as a string without any separators.</value>
        [DataMember(Name = "card_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "card_number")]
        public string CardNumber { get; set; }

        /// <summary>
        /// One or two digit expiration month (1-12) of the credit card.
        /// </summary>
        /// <value>One or two digit expiration month (1-12) of the credit card.</value>
        [DataMember(Name = "expiry_month")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expiry_month")]
        public decimal? ExpiryMonth { get; set; }

        /// <summary>
        /// Two- or four-digit number representing the card's expiration year.
        /// </summary>
        /// <value>Two- or four-digit number representing the card's expiration year.</value>
        [DataMember(Name = "expiry_year")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expiry_year")]
        public decimal? ExpiryYear { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The last four digits of the card number.
        /// </summary>
        /// <value>The last four digits of the card number.</value>
        [DataMember(Name = "last_4")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "last_4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name = "mandate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mandate")]
        public CardMandate Mandate { get; set; }

        /// <summary>
        /// Card security code. It is highly recommended to always include this value.
        /// </summary>
        /// <value>Card security code. It is highly recommended to always include this value.</value>
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
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}