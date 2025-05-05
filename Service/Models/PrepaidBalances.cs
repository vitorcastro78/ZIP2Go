using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PrepaidBalances
    {
        /// <summary>
        /// An array of prepaid balance validity periods
        /// </summary>
        /// <value>An array of prepaid balance validity periods</value>
        [DataMember(Name = "validity_periods")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "validity_periods")]
        public List<ValidityPeriod> ValidityPeriods { get; set; }

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
            sb.Append("class PrepaidBalances {\n");
            sb.Append("  ValidityPeriods: ").Append(ValidityPeriods).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}