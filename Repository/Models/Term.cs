using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Term information of the subscription.
    /// </summary>
    [DataContract]
    public class Term
    {
        /// <summary>
        /// Date when the subscription term ends.
        /// </summary>
        /// <value>Date when the subscription term ends.</value>
        [DataMember(Name = "end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Unit in which term duration is defined. One of day, week, month or year.
        /// </summary>
        /// <value>Unit in which term duration is defined. One of day, week, month or year.</value>
        [DataMember(Name = "interval")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals in a term. For example, interval=year and interval_count=1 represents a 1 year term.
        /// </summary>
        /// <value>The number of intervals in a term. For example, interval=year and interval_count=1 represents a 1 year term.</value>
        [DataMember(Name = "interval_count")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interval_count")]
        public int? IntervalCount { get; set; }

        /// <summary>
        /// Date when the subscription term starts.
        /// </summary>
        /// <value>Date when the subscription term starts.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Type of the subscription. Can be either `termed` or `evergreen`.
        /// </summary>
        /// <value>Type of the subscription. Can be either `termed` or `evergreen`.</value>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

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
            sb.Append("class Term {\n");
            sb.Append("  IntervalCount: ").Append(IntervalCount).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}