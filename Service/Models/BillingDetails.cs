using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Billing information associated with the payment method that may be used or required by specific payment method types.
    /// </summary>
    [DataContract]
    public class BillingDetails
    {
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address")]
        public AddressFieldDefinitions Address { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        /// <value>Customer email address.</value>
        [DataMember(Name = "email")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Customer full name or business name.
        /// </summary>
        /// <value>Customer full name or business name.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Customer phone (including extension).
        /// </summary>
        /// <value>Customer phone (including extension).</value>
        [DataMember(Name = "phone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phone")]
        public string Phone { get; set; }

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
            sb.Append("class BillingDetails {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}