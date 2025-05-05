using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FulfillmentPatchRequest
    {
        /// <summary>
        /// The name of the shipping carrier for this fulfillment.
        /// </summary>
        /// <value>The name of the shipping carrier for this fulfillment.</value>
        [DataMember(Name = "carrier")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// An external identifier for the fulfillment.
        /// </summary>
        /// <value>An external identifier for the fulfillment.</value>
        [DataMember(Name = "external_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// The date of the fulfillment.
        /// </summary>
        /// <value>The date of the fulfillment.</value>
        [DataMember(Name = "fulfillment_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fulfillment_date")]
        public DateTime? FulfillmentDate { get; set; }

        /// <summary>
        /// The fulfillment system for the fulfillment
        /// </summary>
        /// <value>The fulfillment system for the fulfillment</value>
        [DataMember(Name = "fulfillment_system")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fulfillment_system")]
        public string FulfillmentSystem { get; set; }

        /// <summary>
        /// The fulfillment location of the fulfillment
        /// </summary>
        /// <value>The fulfillment location of the fulfillment</value>
        [DataMember(Name = "location")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// The unique identifier of the associated order line item.
        /// </summary>
        /// <value>The unique identifier of the associated order line item.</value>
        [DataMember(Name = "order_line_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order_line_item_id")]
        public string OrderLineItemId { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name = "revenue")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revenue")]
        public AllOffulfillmentPatchRequestRevenue Revenue { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        /// <value>The status of the invoice.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// All order line items associated with this fulfillment that were unbilled on or before this date are included in future bill runs.
        /// </summary>
        /// <value>All order line items associated with this fulfillment that were unbilled on or before this date are included in future bill runs.</value>
        [DataMember(Name = "target_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target_date")]
        public DateTime? TargetDate { get; set; }

        /// <summary>
        /// The tracking number of the fulfillment.
        /// </summary>
        /// <value>The tracking number of the fulfillment.</value>
        [DataMember(Name = "tracking_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The type of fulfillment.
        /// </summary>
        /// <value>The type of fulfillment.</value>
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
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentPatchRequest {\n");
            sb.Append("  OrderLineItemId: ").Append(OrderLineItemId).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FulfillmentDate: ").Append(FulfillmentDate).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  FulfillmentSystem: ").Append(FulfillmentSystem).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}