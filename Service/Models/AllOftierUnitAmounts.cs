using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Per unit prices for units in the tier. Only set if &#x60;charge_model&#x60; is &#x60;tiered&#x60;, &#x60;tiered_overage&#x60;, or &#x60;highwatermark_tiered&#x60;.
    /// </summary>
    [DataContract]
    public class AllOftierUnitAmounts : Money
    {
        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
            sb.Append("class AllOftierUnitAmounts {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}