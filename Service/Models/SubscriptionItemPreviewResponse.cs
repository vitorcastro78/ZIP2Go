using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionItemPreviewResponse
    {
        /// <summary>
        /// Date on which the subscription item expires.
        /// </summary>
        /// <value>Date on which the subscription item expires.</value>
        [DataMember(Name = "end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Mrr
        /// </summary>
        [DataMember(Name = "mrr")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mrr")]
        public LineItemsPreviewResponseMrr Mrr { get; set; }

        /// <summary>
        /// Identifier of the price.
        /// </summary>
        /// <value>Identifier of the price.</value>
        [DataMember(Name = "price_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// Date on which the subscription item starts to become effective.
        /// </summary>
        /// <value>Date on which the subscription item starts to become effective.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Identifier of the subscription item.
        /// </summary>
        /// <value>Identifier of the subscription item.</value>
        [DataMember(Name = "subscription_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_id")]
        public string SubscriptionItemId { get; set; }

        /// <summary>
        /// Gets or Sets Tcb
        /// </summary>
        [DataMember(Name = "tcb")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tcb")]
        public LineItemsPreviewResponseMrr Tcb { get; set; }

        /// <summary>
        /// Gets or Sets Tcv
        /// </summary>
        [DataMember(Name = "tcv")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tcv")]
        public LineItemsPreviewResponseMrr Tcv { get; set; }

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
            sb.Append("class SubscriptionItemPreviewResponse {\n");
            sb.Append("  SubscriptionItemId: ").Append(SubscriptionItemId).Append("\n");
            sb.Append("  PriceId: ").Append(PriceId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Mrr: ").Append(Mrr).Append("\n");
            sb.Append("  Tcb: ").Append(Tcb).Append("\n");
            sb.Append("  Tcv: ").Append(Tcv).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}