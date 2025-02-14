using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Zip2Go.Models
{
    /// <summary>
    /// The state of the payment.
    /// </summary>
    [DataContract]
    public class AllOfpaymentTransactionsState
    {
        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name = "failed", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failed")]
        public string Failed { get; set; }

        /// <summary>
        /// Gets or Sets Succeeded
        /// </summary>
        [DataMember(Name = "succeeded", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "succeeded")]
        public string Succeeded { get; set; }

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
            sb.Append("class AllOfpaymentTransactionsState {\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}