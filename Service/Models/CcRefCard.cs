using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class CcRefCard
    {
        /// <summary>
        /// Card brand.
        /// </summary>
        /// <value>Card brand.</value>
        [DataMember(Name = "brand")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "brand")]
        public string Brand { get; set; }

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

        /// <summary>
        /// The last four digits of the card number.
        /// </summary>
        /// <value>The last four digits of the card number.</value>
        [DataMember(Name = "last_4")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "last_4")]
        public string Last4 { get; set; }

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
            sb.Append("class CcRefCard {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}