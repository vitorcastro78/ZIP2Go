using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// The date and time when the payment run executed, in the &#x60;yyyy-mm-dd hh:mm:ss&#x60; format.
    /// </summary>
    [DataContract]
    public class PaymentRunStateTransitions
    {
        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name = "completed")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completed")]
        public string Completed { get; set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name = "failed")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failed")]
        public string Failed { get; set; }

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
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfpaymentRunStateTransitions {\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}