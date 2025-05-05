using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class CreditMemoItemPreviewResponse
    {
        /// <summary>
        /// The total amount of this credit memo item.
        /// </summary>
        /// <value>The total amount of this credit memo item.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Identifier of an invoice item that this credit memo item is applied to.
        /// </summary>
        /// <value>Identifier of an invoice item that this credit memo item is applied to.</value>
        [DataMember(Name = "applied_to_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applied_to_item_id")]
        public string AppliedToItemId { get; set; }

        /// <summary>
        /// Type of the charge. It can be one of the following types: one-time, recurring, or usage.
        /// </summary>
        /// <value>Type of the charge. It can be one of the following types: one-time, recurring, or usage.</value>
        [DataMember(Name = "charge_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The date when the credit memo item takes effect.
        /// </summary>
        /// <value>The date when the credit memo item takes effect.</value>
        [DataMember(Name = "document_item_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_item_date")]
        public DateTime? DocumentItemDate { get; set; }

        /// <summary>
        /// Gets or Sets DocumentItemNumber
        /// </summary>
        [DataMember(Name = "document_item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_item_number")]
        public string DocumentItemNumber { get; set; }

        /// <summary>
        /// Unique identifier of the object
        /// </summary>
        /// <value>Unique identifier of the object</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingType
        /// </summary>
        [DataMember(Name = "processing_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processing_type")]
        public string ProcessingType { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The end date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The end date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name = "service_end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_end_date")]
        public string ServiceEndDate { get; set; }

        /// <summary>
        /// The start date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The start date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name = "service_start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_start_date")]
        public string ServiceStartDate { get; set; }

        /// <summary>
        /// The unique SKU (stock keeping unit) of the product associated with this item.
        /// </summary>
        /// <value>The unique SKU (stock keeping unit) of the product associated with this item.</value>
        [DataMember(Name = "sku")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// The name of the SKU associated with this item
        /// </summary>
        /// <value>The name of the SKU associated with this item</value>
        [DataMember(Name = "sku_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// The identifier of the subscription associated with the credit memo item.
        /// </summary>
        /// <value>The identifier of the subscription associated with the credit memo item.</value>
        [DataMember(Name = "subscription_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The identifier the subscription item associated with this credit memo item.
        /// </summary>
        /// <value>The identifier the subscription item associated with this credit memo item.</value>
        [DataMember(Name = "subscription_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_id")]
        public string SubscriptionItemId { get; set; }

        /// <summary>
        /// Human-readable identifier of the subscription. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the subscription. It can be user-supplied.</value>
        [DataMember(Name = "subscription_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_number")]
        public string SubscriptionNumber { get; set; }

        /// <summary>
        /// The total amount of this credit memo item exclusive of tax.
        /// </summary>
        /// <value>The total amount of this credit memo item exclusive of tax.</value>
        [DataMember(Name = "subtotal")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subtotal")]
        public decimal? Subtotal { get; set; }

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
            sb.Append("class CreditMemoItemPreviewResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  AppliedToItemId: ").Append(AppliedToItemId).Append("\n");
            sb.Append("  DocumentItemDate: ").Append(DocumentItemDate).Append("\n");
            sb.Append("  DocumentItemNumber: ").Append(DocumentItemNumber).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessingType: ").Append(ProcessingType).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SubscriptionItemId: ").Append(SubscriptionItemId).Append("\n");
            sb.Append("  ServiceStartDate: ").Append(ServiceStartDate).Append("\n");
            sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  SkuName: ").Append(SkuName).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}