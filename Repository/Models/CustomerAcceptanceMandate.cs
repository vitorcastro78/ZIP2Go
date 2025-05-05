using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Details about the customer’s acceptance of the mandate.
    /// </summary>
    [DataContract]
    public class CustomerAcceptanceMandate
    {
        /// <summary>
        /// The date on which the customer accepted the mandate.
        /// </summary>
        /// <value>The date on which the customer accepted the mandate.</value>
        [DataMember(Name = "date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// A reference to the consent agreement you have with your customer.
        /// </summary>
        /// <value>A reference to the consent agreement you have with your customer.</value>
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
            sb.Append("class CustomerAcceptanceMandate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}