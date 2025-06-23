using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Specify this field if you want to resume a subscription.
    /// </summary>
    [DataContract]
    public class SubscriptionResumePatchResponse
    {
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// If this field is set to `true`, the subscription term is extended by the length of time the subscription is paused.
        /// </summary>
        /// <value>If this field is set to `true`, the subscription term is extended by the length of time the subscription is paused.</value>
        [DataMember(Name = "extend_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extend_term")]
        public bool? ExtendTerm { get; set; }

        /// <summary>
        /// You can use this field to resume a paused subscription from the pause date.
        /// </summary>
        /// <value>You can use this field to resume a paused subscription from the pause date.</value>
        [DataMember(Name = "resume_at")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resume_at")]
        public string ResumeAt { get; set; }

        /// <summary>
        /// Date on which the paused subscription is resumed.
        /// </summary>
        /// <value>Date on which the paused subscription is resumed.</value>
        [DataMember(Name = "resume_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resume_date")]
        public string ResumeDate { get; set; }

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
            sb.Append("class SubscriptionResumePatchResponse {\n");
            sb.Append("  ExtendTerm: ").Append(ExtendTerm).Append("\n");
            sb.Append("  ResumeDate: ").Append(ResumeDate).Append("\n");
            sb.Append("  ResumeAt: ").Append(ResumeAt).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}