using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentScheduleCancel
    {
        /// <summary>
        /// The date on which the payment schdule is canceled.
        /// </summary>
        /// <value>The date on which the payment schdule is canceled.</value>
        [DataMember(Name = "cancel_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancel_date")]
        public DateTime? CancelDate { get; set; }

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
            sb.Append("class PaymentScheduleCancel {\n");
            sb.Append("  CancelDate: ").Append(CancelDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}