using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class UsagePatchRequest
    {
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The end time for which usage is recorded.
        /// </summary>
        /// <value>The end time for which usage is recorded.</value>
        [DataMember(Name = "end_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The start time for which usage is recorded.
        /// </summary>
        /// <value>The start time for which usage is recorded.</value>
        [DataMember(Name = "start_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_time")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Specifies the units to measure usage. Units of measure are configured in Zuora Central. Your values depend on your configuration in Billing Settings.
        /// </summary>
        /// <value>Specifies the units to measure usage. Units of measure are configured in Zuora Central. Your values depend on your configuration in Billing Settings.</value>
        [DataMember(Name = "unit_of_measure")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_of_measure")]
        public string UnitOfMeasure { get; set; }

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
            sb.Append("class UsagePatchRequest {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}