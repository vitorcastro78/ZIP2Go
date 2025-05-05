using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Accounting configuration if you have Zuora Revenue enabled.
    /// </summary>
    [DataContract]
    public class Revenue
    {
        /// <summary>
        /// If set to `true`, any associated billing document items are excluded from the revenue accounting.
        /// </summary>
        /// <value>If set to `true`, any associated billing document items are excluded from the revenue accounting.</value>
        [DataMember(Name = "exclude_item_billing_from_revenue_accounting")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exclude_item_billing_from_revenue_accounting")]
        public bool? ExcludeItemBillingFromRevenueAccounting { get; set; }

        /// <summary>
        /// If set to `true`, any associated subscription items are excluded from the revenue accounting.
        /// </summary>
        /// <value>If set to `true`, any associated subscription items are excluded from the revenue accounting.</value>
        [DataMember(Name = "exclude_item_booking_from_revenue_accounting")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exclude_item_booking_from_revenue_accounting")]
        public bool? ExcludeItemBookingFromRevenueAccounting { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

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
            sb.Append("class Revenue {\n");
            sb.Append("  ExcludeItemBillingFromRevenueAccounting: ").Append(ExcludeItemBillingFromRevenueAccounting).Append("\n");
            sb.Append("  ExcludeItemBookingFromRevenueAccounting: ").Append(ExcludeItemBookingFromRevenueAccounting).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}