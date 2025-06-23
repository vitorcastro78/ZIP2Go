using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class InvoiceItemPreviewResponse
    {
        /// <summary>
        /// The total amount of this invoice item.
        /// </summary>
        /// <value>The total amount of this invoice item.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Identifier of an invoice item or a debit memo item that this discount item or credit memo item is applied to.
        /// </summary>
        /// <value>Identifier of an invoice item or a debit memo item that this discount item or credit memo item is applied to.</value>
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
        /// Gets or Sets DocumentDate
        /// </summary>
        [DataMember(Name = "document_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_date")]
        public DateTime? DocumentDate { get; set; }

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
        /// The end date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The end date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name = "service_end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_end_date")]
        public string ServiceEndDate { get; set; }

        /// <summary>
        /// The start date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The start date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name = "service_start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_start_date")]
        public string ServiceStartDate { get; set; }

        /// <summary>
        /// The identifier of the subscription associated with the invoice item.
        /// </summary>
        /// <value>The identifier of the subscription associated with the invoice item.</value>
        [DataMember(Name = "subscription_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionItemDescription
        /// </summary>
        [DataMember(Name = "subscription_item_description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_description")]
        public string SubscriptionItemDescription { get; set; }

        /// <summary>
        /// The identifier the subscription item associated with this invoice item.
        /// </summary>
        /// <value>The identifier the subscription item associated with this invoice item.</value>
        [DataMember(Name = "subscription_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_id")]
        public string SubscriptionItemId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionItemName
        /// </summary>
        [DataMember(Name = "subscription_item_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_name")]
        public string SubscriptionItemName { get; set; }

        /// <summary>
        /// Human-readable identifier of the subscription item. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the subscription item. It can be user-supplied.</value>
        [DataMember(Name = "subscription_item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_number")]
        public string SubscriptionItemNumber { get; set; }

        /// <summary>
        /// The name of the subscription associated with this item.
        /// </summary>
        /// <value>The name of the subscription associated with this item.</value>
        [DataMember(Name = "subscription_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_name")]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// The subscription number of the subscription associated with this item.
        /// </summary>
        /// <value>The subscription number of the subscription associated with this item.</value>
        [DataMember(Name = "subscription_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_number")]
        public string SubscriptionNumber { get; set; }

        /// <summary>
        /// The amount of tax applied to the invoice item.
        /// </summary>
        /// <value>The amount of tax applied to the invoice item.</value>
        [DataMember(Name = "tax")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax")]
        public decimal? Tax { get; set; }

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
            sb.Append("class InvoiceItemPreviewResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AppliedToItemId: ").Append(AppliedToItemId).Append("\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  SubscriptionItemDescription: ").Append(SubscriptionItemDescription).Append("\n");
            sb.Append("  SubscriptionItemId: ").Append(SubscriptionItemId).Append("\n");
            sb.Append("  SubscriptionItemName: ").Append(SubscriptionItemName).Append("\n");
            sb.Append("  SubscriptionItemNumber: ").Append(SubscriptionItemNumber).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessingType: ").Append(ProcessingType).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ServiceStartDate: ").Append(ServiceStartDate).Append("\n");
            sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
            sb.Append("  SubscriptionName: ").Append(SubscriptionName).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}