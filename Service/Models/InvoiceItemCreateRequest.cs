using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class InvoiceItemCreateRequest
    {
        /// <summary>
        /// Gets or Sets AccountingCode
        /// </summary>
        [DataMember(Name = "accounting_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accounting_code")]
        public string AccountingCode { get; set; }

        /// <summary>
        /// Amount (in the currency specified) of the invoice item. This should always be equal to unit_amount * quantity.
        /// </summary>
        /// <value>Amount (in the currency specified) of the invoice item. This should always be equal to unit_amount * quantity.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The booking reference for this invoice item.
        /// </summary>
        /// <value>The booking reference for this invoice item.</value>
        [DataMember(Name = "booking_reference")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "booking_reference")]
        public string BookingReference { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "deferred_revenue_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deferred_revenue_account")]
        public string DeferredRevenueAccount { get; set; }

        /// <summary>
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The date when the invoice item takes effect
        /// </summary>
        /// <value>The date when the invoice item takes effect</value>
        [DataMember(Name = "document_item_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_item_date")]
        public DateTime? DocumentItemDate { get; set; }

        /// <summary>
        /// Name of the invoice item displayed to customers on billing documents.
        /// </summary>
        /// <value>Name of the invoice item displayed to customers on billing documents.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "on_account_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "on_account_account")]
        public string OnAccountAccount { get; set; }

        /// <summary>
        /// The identifier of the price this invoice item is associated with.
        /// </summary>
        /// <value>The identifier of the price this invoice item is associated with.</value>
        [DataMember(Name = "price_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// The purchase order number associated with this invoice item.
        /// </summary>
        /// <value>The purchase order number associated with this invoice item.</value>
        [DataMember(Name = "purchase_order_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchase_order_number")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "recognized_revenue_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recognized_revenue_account")]
        public string RecognizedRevenueAccount { get; set; }

        /// <summary>
        /// The name of the revenue recognition rule governing the revenue schedule.
        /// </summary>
        /// <value>The name of the revenue recognition rule governing the revenue schedule.</value>
        [DataMember(Name = "revenue_recognition_rule_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revenue_recognition_rule_name")]
        public string RevenueRecognitionRuleName { get; set; }

        /// <summary>
        /// The end date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.
        /// </summary>
        /// <value>The end date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.</value>
        [DataMember(Name = "service_end")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_end")]
        public DateTime? ServiceEnd { get; set; }

        /// <summary>
        /// The start date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.
        /// </summary>
        /// <value>The start date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.</value>
        [DataMember(Name = "service_start")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_start")]
        public DateTime? ServiceStart { get; set; }

        /// <summary>
        /// The unique SKU (stock keeping unit) of the product associated with this item.
        /// </summary>
        /// <value>The unique SKU (stock keeping unit) of the product associated with this item.</value>
        [DataMember(Name = "sku")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// List of taxation items.
        /// </summary>
        /// <value>List of taxation items.</value>
        [DataMember(Name = "taxation_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxation_items")]
        public List<TaxationItemCreateRequest> TaxationItems { get; set; }

        /// <summary>
        /// The designated tax code.
        /// </summary>
        /// <value>The designated tax code.</value>
        [DataMember(Name = "tax_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// Indicates whether the invoice item amount is inclusive or exclusive of tax.
        /// </summary>
        /// <value>Indicates whether the invoice item amount is inclusive or exclusive of tax.</value>
        [DataMember(Name = "tax_inclusive")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_inclusive")]
        public bool? TaxInclusive { get; set; }

        /// <summary>
        /// Unit amount (in the currency specified) of the invoice item.
        /// </summary>
        /// <value>Unit amount (in the currency specified) of the invoice item.</value>
        [DataMember(Name = "unit_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_amount")]
        public decimal? UnitAmount { get; set; }

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
            sb.Append("class InvoiceItemCreateRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeferredRevenueAccount: ").Append(DeferredRevenueAccount).Append("\n");
            sb.Append("  OnAccountAccount: ").Append(OnAccountAccount).Append("\n");
            sb.Append("  RecognizedRevenueAccount: ").Append(RecognizedRevenueAccount).Append("\n");
            sb.Append("  RevenueRecognitionRuleName: ").Append(RevenueRecognitionRuleName).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ServiceEnd: ").Append(ServiceEnd).Append("\n");
            sb.Append("  ServiceStart: ").Append(ServiceStart).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  TaxationItems: ").Append(TaxationItems).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("  BookingReference: ").Append(BookingReference).Append("\n");
            sb.Append("  PriceId: ").Append(PriceId).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  DocumentItemDate: ").Append(DocumentItemDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}