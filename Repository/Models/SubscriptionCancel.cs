using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Specify this field to cancel a subscription
    /// </summary>
    [DataContract]
    public class SubscriptionCancel
    {
        /// <summary>
        /// The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.
        /// </summary>
        /// <value>The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.</value>
        [DataMember(Name = "cancel_at")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancel_at")]
        public string CancelAt { get; set; }

        /// <summary>
        /// Date on which the subscription is canceled.
        /// </summary>
        /// <value>Date on which the subscription is canceled.</value>
        [DataMember(Name = "cancel_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancel_date")]
        public DateTime? CancelDate { get; set; }

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
            sb.Append("class SubscriptionCancelPatchResponse {\n");
            sb.Append("  CancelDate: ").Append(CancelDate).Append("\n");
            sb.Append("  CancelAt: ").Append(CancelAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}