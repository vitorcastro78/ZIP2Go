using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionPreviewBillingDocumentItemResponse
    {
        /// <summary>
        /// The identifier of the price this billing document item is associated with.
        /// </summary>
        /// <value>The identifier of the price this billing document item is associated with.</value>
        [DataMember(Name = "price_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingType
        /// </summary>
        [DataMember(Name = "processing_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processing_type")]
        public string ProcessingType { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name = "product_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The end date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The end date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name = "service_end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_end_date")]
        public string ServiceEndDate { get; set; }

        /// <summary>
        /// The start date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The start date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name = "service_start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_start_date")]
        public string ServiceStartDate { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionItemDescription
        /// </summary>
        [DataMember(Name = "subscription_item_description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_description")]
        public string SubscriptionItemDescription { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionItemName
        /// </summary>
        [DataMember(Name = "subscription_item_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_name")]
        public string SubscriptionItemName { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionItemNumber
        /// </summary>
        [DataMember(Name = "subscription_item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_number")]
        public string SubscriptionItemNumber { get; set; }

        /// <summary>
        /// The total amount of this billing document item exclusive of tax.
        /// </summary>
        /// <value>The total amount of this billing document item exclusive of tax.</value>
        [DataMember(Name = "subtotal")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// The amount of tax applied to the billing document item.
        /// </summary>
        /// <value>The amount of tax applied to the billing document item.</value>
        [DataMember(Name = "tax")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax")]
        public decimal? Tax { get; set; }

        /// <summary>
        /// Gets or Sets TaxationItems
        /// </summary>
        [DataMember(Name = "taxation_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxation_items")]
        public List<AllOfsubscriptionPreviewBillingDocumentItemResponseTaxationItemsItems> TaxationItems { get; set; }

        /// <summary>
        /// The total amount of this billing document item.
        /// </summary>
        /// <value>The total amount of this billing document item.</value>
        [DataMember(Name = "total")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Specifies the units used to measure usage.
        /// </summary>
        /// <value>Specifies the units used to measure usage.</value>
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
            sb.Append("class SubscriptionPreviewBillingDocumentItemResponse {\n");
            sb.Append("  SubscriptionItemDescription: ").Append(SubscriptionItemDescription).Append("\n");
            sb.Append("  SubscriptionItemName: ").Append(SubscriptionItemName).Append("\n");
            sb.Append("  SubscriptionItemNumber: ").Append(SubscriptionItemNumber).Append("\n");
            sb.Append("  ProcessingType: ").Append(ProcessingType).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  PriceId: ").Append(PriceId).Append("\n");
            sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
            sb.Append("  ServiceStartDate: ").Append(ServiceStartDate).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TaxationItems: ").Append(TaxationItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}