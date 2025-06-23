using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Tiers information of the billing document items.
    /// </summary>
    [DataContract]
    public class ItemTier
    {
        /// <summary>
        /// The amount of the price. Specify this field if you want to override the original price with a flat-fee price.
        /// </summary>
        /// <value>The amount of the price. Specify this field if you want to override the original price with a flat-fee price.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.
        /// </summary>
        /// <value>The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.</value>
        [DataMember(Name = "unit_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_amount")]
        public decimal? UnitAmount { get; set; }

        /// <summary>
        /// Specifies the upper bound of the tier. The lower bound of a tier is the upper bound of the previous tier plus one.
        /// </summary>
        /// <value>Specifies the upper bound of the tier. The lower bound of a tier is the upper bound of the previous tier plus one.</value>
        [DataMember(Name = "up_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "up_to")]
        public decimal? UpTo { get; set; }

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
            sb.Append("class ItemTier {\n");
            sb.Append("  UpTo: ").Append(UpTo).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}