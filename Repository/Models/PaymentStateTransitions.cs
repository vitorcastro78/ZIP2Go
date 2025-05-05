using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// The timestamps at which the object&#x27;s state was updated.
    /// </summary>
    [DataContract]
    public class PaymentStateTransitions
    {
        /// <summary>
        /// The date and time (ISO 8601 UTC format) when the payment was canceled.
        /// </summary>
        /// <value>The date and time (ISO 8601 UTC format) when the payment was canceled.</value>
        [DataMember(Name = "canceled_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "canceled_time")]
        public DateTime? CanceledTime { get; set; }

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
            sb.Append("class PaymentStateTransitions {\n");
            sb.Append("  CanceledTime: ").Append(CanceledTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}