using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Tier information for tiered prices.
    /// </summary>
    [DataContract]
    public class Tier
    {
        /// <summary>
        /// Prices for the tier. Only set if `charge_model` is `tiered`, `tiered_overage`, or `highwatermark_tiered`.
        /// </summary>
        /// <value>Prices for the tier. Only set if `charge_model` is `tiered`, `tiered_overage`, or `highwatermark_tiered`.</value>
        [DataMember(Name = "amounts")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amounts")]
        public Money Amounts { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Per unit prices for units in the tier. Only set if `charge_model` is `tiered`, `tiered_overage`, or `highwatermark_tiered`.
        /// </summary>
        /// <value>Per unit prices for units in the tier. Only set if `charge_model` is `tiered`, `tiered_overage`, or `highwatermark_tiered`.</value>
        [DataMember(Name = "unit_amounts")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_amounts")]
        public Money UnitAmounts { get; set; }

        /// <summary>
        /// The upper bound of a tier. The lower bound of a tier is the upper bound of the previous tier plus one or some fraction of one, depending on the precision of the unit of measure.
        /// </summary>
        /// <value>The upper bound of a tier. The lower bound of a tier is the upper bound of the previous tier plus one or some fraction of one, depending on the precision of the unit of measure.</value>
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
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tier {\n");
            sb.Append("  UpTo: ").Append(UpTo).Append("\n");
            sb.Append("  Amounts: ").Append(Amounts).Append("\n");
            sb.Append("  UnitAmounts: ").Append(UnitAmounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}