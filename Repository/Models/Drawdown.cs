using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Drawdown
    {
        /// <summary>
        /// The conversion rate between usage unit of measure (UOM) and drawdown unit of measure for a drawdown charge.        **Note**:    <ul>    <li>Must be a positive number (>0).</li>    <li>Must be `1` when usage UOM and drawdown UOM are the same.</li>     <li>If both `conversion_rate` and `unit_of_measure` for the drawdown are empty, the system will set default values respectively: <ul>      <li> `conversion_rate`: 1 </li>      <li> `unit_of_measure`: Same as the usage UOM of this drawdown charge. </li></ul></li></ul>        The `conversion_rate` and `unit_of_measure` fields need to have values or be empty at the same time.
        /// </summary>
        /// <value>The conversion rate between usage unit of measure (UOM) and drawdown unit of measure for a drawdown charge.        **Note**:    <ul>    <li>Must be a positive number (>0).</li>    <li>Must be `1` when usage UOM and drawdown UOM are the same.</li>     <li>If both `conversion_rate` and `unit_of_measure` for the drawdown are empty, the system will set default values respectively: <ul>      <li> `conversion_rate`: 1 </li>      <li> `unit_of_measure`: Same as the usage UOM of this drawdown charge. </li></ul></li></ul>        The `conversion_rate` and `unit_of_measure` fields need to have values or be empty at the same time.     </value>
        [DataMember(Name = "conversion_rate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conversion_rate")]
        public decimal? ConversionRate { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Unit of measurement for a drawdown charge.
        /// </summary>
        /// <value>Unit of measurement for a drawdown charge.</value>
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
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Drawdown {\n");
            sb.Append("  ConversionRate: ").Append(ConversionRate).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}