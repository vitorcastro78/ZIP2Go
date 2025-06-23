using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// The recurring components of a price such as interval and usage.
    /// </summary>
    [DataContract]
    public class Recurring
    {
        /// <summary>
        /// Specifies how to align billing for recurring (subscription) products that start on different days.
        /// </summary>
        /// <value>Specifies how to align billing for recurring (subscription) products that start on different days.</value>
        [DataMember(Name = "alignment_behavior")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alignment_behavior")]
        public string AlignmentBehavior { get; set; }

        /// <summary>
        /// Specifies the duration frequency. One of day, week, month or year.
        /// </summary>
        /// <value>Specifies the duration frequency. One of day, week, month or year.</value>
        [DataMember(Name = "duration_interval")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "duration_interval")]
        public string DurationInterval { get; set; }

        /// <summary>
        /// Specifies how long a customer shall be charged if this is less than the duration of the subscription
        /// </summary>
        /// <value>Specifies how long a customer shall be charged if this is less than the duration of the subscription</value>
        [DataMember(Name = "duration_interval_count")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "duration_interval_count")]
        public int? DurationIntervalCount { get; set; }

        /// <summary>
        /// You can choose to bill in_advance or in_arrears for recurring prices. The field is not used with one-time or usage-based prices.
        /// </summary>
        /// <value>You can choose to bill in_advance or in_arrears for recurring prices. The field is not used with one-time or usage-based prices.</value>
        [DataMember(Name = "formula")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "formula")]
        public string Formula { get; set; }

        /// <summary>
        /// Specifies the billing frequency. One of `week`, `month` or `year`.
        /// </summary>
        /// <value>Specifies the billing frequency. One of `week`, `month` or `year`.</value>
        [DataMember(Name = "interval")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals (specified in the interval attribute) between subscription billings. For example, interval=month and intervalCount=3 bills every 3 months.
        /// </summary>
        /// <value>The number of intervals (specified in the interval attribute) between subscription billings. For example, interval=month and intervalCount=3 bills every 3 months.</value>
        [DataMember(Name = "interval_count")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interval_count")]
        public int? IntervalCount { get; set; }

        /// <summary>
        /// Specifies on which day or the month or day of the week a customer shall be billed.
        /// </summary>
        /// <value>Specifies on which day or the month or day of the week a customer shall be billed.</value>
        [DataMember(Name = "on")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "on")]
        public string On { get; set; }

        /// <summary>
        /// A rating group based on which usage records are rated. Only applicable to usage prices.
        /// </summary>
        /// <value>A rating group based on which usage records are rated. Only applicable to usage prices.</value>
        [DataMember(Name = "rating_group")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rating_group")]
        public string RatingGroup { get; set; }

        /// <summary>
        /// Specifies on which day or the month or day of the week a customer shall be billed.
        /// </summary>
        /// <value>Specifies on which day or the month or day of the week a customer shall be billed.</value>
        [DataMember(Name = "recurring_on")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recurring_on")]
        public string RecurringOn { get; set; }

        /// <summary>
        /// You can choose to bill in_advance or in_arrears for recurring prices. The field is not used with one-time or usage-based prices.
        /// </summary>
        /// <value>You can choose to bill in_advance or in_arrears for recurring prices. The field is not used with one-time or usage-based prices.</value>
        [DataMember(Name = "timing")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timing")]
        public string Timing { get; set; }

        /// <summary>
        /// Indicates that this is a usage price.
        /// </summary>
        /// <value>Indicates that this is a usage price.</value>
        [DataMember(Name = "usage")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usage")]
        public bool? Usage { get; set; }

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
            sb.Append("class Recurring {\n");
            sb.Append("  RecurringOn: ").Append(RecurringOn).Append("\n");
            sb.Append("  On: ").Append(On).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  IntervalCount: ").Append(IntervalCount).Append("\n");
            sb.Append("  AlignmentBehavior: ").Append(AlignmentBehavior).Append("\n");
            sb.Append("  Timing: ").Append(Timing).Append("\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  DurationInterval: ").Append(DurationInterval).Append("\n");
            sb.Append("  DurationIntervalCount: ").Append(DurationIntervalCount).Append("\n");
            sb.Append("  RatingGroup: ").Append(RatingGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}