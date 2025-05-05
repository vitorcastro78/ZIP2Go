using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// An object defining how overage charges are calculated.
    /// </summary>
    [DataContract]
    public class Overage
    {
        /// <summary>
        /// Indicates if the overage price is calculated at the end of the smoothing period.
        /// </summary>
        /// <value>Indicates if the overage price is calculated at the end of the smoothing period.</value>
        [DataMember(Name = "apply_at_end_of_smoothing_period")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apply_at_end_of_smoothing_period")]
        public bool? ApplyAtEndOfSmoothingPeriod { get; set; }

        /// <summary>
        /// Specifies whether or not to credit unused units.
        /// </summary>
        /// <value>Specifies whether or not to credit unused units.</value>
        [DataMember(Name = "credit_unused_units")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_unused_units")]
        public bool? CreditUnusedUnits { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Specifies the included units to which overage charges do not apply.
        /// </summary>
        /// <value>Specifies the included units to which overage charges do not apply.</value>
        [DataMember(Name = "included_units")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "included_units")]
        public decimal? IncludedUnits { get; set; }

        /// <summary>
        /// Specifies the number of intervals used to calculate smoothed overage charges.
        /// </summary>
        /// <value>Specifies the number of intervals used to calculate smoothed overage charges.</value>
        [DataMember(Name = "interval_count")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interval_count")]
        public int? IntervalCount { get; set; }

        /// <summary>
        /// Represents the overage type: one of rolling_window or rollover.
        /// </summary>
        /// <value>Represents the overage type: one of rolling_window or rollover.</value>
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
            sb.Append("class Overage {\n");
            sb.Append("  IntervalCount: ").Append(IntervalCount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IncludedUnits: ").Append(IncludedUnits).Append("\n");
            sb.Append("  CreditUnusedUnits: ").Append(CreditUnusedUnits).Append("\n");
            sb.Append("  ApplyAtEndOfSmoothingPeriod: ").Append(ApplyAtEndOfSmoothingPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}