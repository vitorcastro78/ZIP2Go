using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PauseSubscriptionRequest
    {
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Can be either the end of the current billing period or a specific date.
        /// </summary>
        /// <value>Can be either the end of the current billing period or a specific date.</value>
        [DataMember(Name = "pause_at")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pause_at")]
        public string PauseAt { get; set; }

        /// <summary>
        /// Date on which the subscription is paused.
        /// </summary>
        /// <value>Date on which the subscription is paused.</value>
        [DataMember(Name = "pause_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pause_date")]
        public string PauseDate { get; set; }

        /// <summary>
        /// Unit in which the pause duration is defined. One of day, week, month or year.
        /// </summary>
        /// <value>Unit in which the pause duration is defined. One of day, week, month or year.</value>
        [DataMember(Name = "pause_interval")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pause_interval")]
        public string PauseInterval { get; set; }

        /// <summary>
        /// The number of intervals in a duration where the subscription is paused. For example, pause_interval=year and pause_interval_count=1 represents a 1-year pause.
        /// </summary>
        /// <value>The number of intervals in a duration where the subscription is paused. For example, pause_interval=year and pause_interval_count=1 represents a 1-year pause.</value>
        [DataMember(Name = "pause_interval_count")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pause_interval_count")]
        public decimal? PauseIntervalCount { get; set; }

        /// <summary>
        /// Gets or Sets ResumeBehavior
        /// </summary>
        [DataMember(Name = "resume_behavior")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resume_behavior")]
        public ResumeSubscriptionRequest ResumeBehavior { get; set; }

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
            sb.Append("class PauseSubscriptionRequest {\n");
            sb.Append("  PauseDate: ").Append(PauseDate).Append("\n");
            sb.Append("  PauseAt: ").Append(PauseAt).Append("\n");
            sb.Append("  PauseIntervalCount: ").Append(PauseIntervalCount).Append("\n");
            sb.Append("  PauseInterval: ").Append(PauseInterval).Append("\n");
            sb.Append("  ResumeBehavior: ").Append(ResumeBehavior).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}