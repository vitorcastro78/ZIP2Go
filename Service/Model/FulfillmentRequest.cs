using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FulfillmentRequest {
    /// <summary>
    /// The unique identifier of the associated order line item.
    /// </summary>
    /// <value>The unique identifier of the associated order line item.</value>
    [DataMember(Name="order_line_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_line_item_id")]
    public string OrderLineItemId { get; set; }

    /// <summary>
    /// The name of the shipping carrier for this fulfillment.
    /// </summary>
    /// <value>The name of the shipping carrier for this fulfillment.</value>
    [DataMember(Name="carrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier")]
    public string Carrier { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public CustomFields CustomFields { get; set; }

    /// <summary>
    /// An arbitrary string attached to the object. Often useful for displaying to users.
    /// </summary>
    /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Revenue
    /// </summary>
    [DataMember(Name="revenue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenue")]
    public AllOffulfillmentRequestRevenue Revenue { get; set; }

    /// <summary>
    /// An external identifier for the fulfillment
    /// </summary>
    /// <value>An external identifier for the fulfillment</value>
    [DataMember(Name="external_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external_id")]
    public string ExternalId { get; set; }

    /// <summary>
    /// The date of the fulfillment.
    /// </summary>
    /// <value>The date of the fulfillment.</value>
    [DataMember(Name="fulfillment_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfillment_date")]
    public DateTime? FulfillmentDate { get; set; }

    /// <summary>
    /// The fulfillment location of the fulfillment.
    /// </summary>
    /// <value>The fulfillment location of the fulfillment.</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// The fulfillment system for the fulfillment.
    /// </summary>
    /// <value>The fulfillment system for the fulfillment.</value>
    [DataMember(Name="fulfillment_system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfillment_system")]
    public string FulfillmentSystem { get; set; }

    /// <summary>
    /// The type of fulfillment.
    /// </summary>
    /// <value>The type of fulfillment.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The number of units of this item.
    /// </summary>
    /// <value>The number of units of this item.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// The status of the invoice.
    /// </summary>
    /// <value>The status of the invoice.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The tracking number of the fulfillment.
    /// </summary>
    /// <value>The tracking number of the fulfillment.</value>
    [DataMember(Name="tracking_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_number")]
    public string TrackingNumber { get; set; }

    /// <summary>
    /// Information of all fulfillment items.
    /// </summary>
    /// <value>Information of all fulfillment items.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<FulfillmentItemCreateRequestForFulfillmentPost> Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FulfillmentRequest {\n");
      sb.Append("  OrderLineItemId: ").Append(OrderLineItemId).Append("\n");
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
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
