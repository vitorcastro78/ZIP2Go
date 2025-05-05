using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Data of order line items.
    /// </summary>
    [DataContract]
    public class OrderItem
    {
        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "accounting_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accounting_code")]
        public string AccountingCode { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "adjustment_liability_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "adjustment_liability_account")]
        public string AdjustmentLiabilityAccount { get; set; }

        /// <summary>
        /// The billing rule for the order line item.
        /// </summary>
        /// <value>The billing rule for the order line item.</value>
        [DataMember(Name = "billing_rule")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_rule")]
        public string BillingRule { get; set; }

        /// <summary>
        /// The category for the order line item, to indicate a product sale or return.
        /// </summary>
        /// <value>The category for the order line item, to indicate a product sale or return.</value>
        [DataMember(Name = "category")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "contract_asset_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contract_asset_account")]
        public string ContractAssetAccount { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "contract_liability_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contract_liability_account")]
        public string ContractLiabilityAccount { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public string CreatedById { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public CustomObject CustomObjects { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Discount percent.
        /// </summary>
        /// <value>Discount percent.</value>
        [DataMember(Name = "discount_percent")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount_percent")]
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// Total discount amount.
        /// </summary>
        /// <value>Total discount amount.</value>
        [DataMember(Name = "discount_total")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount_total")]
        public decimal? DiscountTotal { get; set; }

        /// <summary>
        /// Discount amount per unit.
        /// </summary>
        /// <value>Discount amount per unit.</value>
        [DataMember(Name = "discount_unit_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount_unit_amount")]
        public decimal? DiscountUnitAmount { get; set; }

        /// <summary>
        /// The date the order line item transitions to complete.
        /// </summary>
        /// <value>The date the order line item transitions to complete.</value>
        [DataMember(Name = "end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// List of invoice items. EXPANDABLE
        /// </summary>
        /// <value>List of invoice items. EXPANDABLE</value>
        [DataMember(Name = "invoice_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_items")]
        public List<InvoiceItem> InvoiceItems { get; set; }

        /// <summary>
        /// Human-readable identifier of the order item. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the order item. It can be user-supplied.</value>
        [DataMember(Name = "item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "item_number")]
        public string ItemNumber { get; set; }

        /// <summary>
        /// The extended list price for an order line item, calculated by the formula: listPrice = listPricePerUnit * quantity
        /// </summary>
        /// <value>The extended list price for an order line item, calculated by the formula: listPrice = listPricePerUnit * quantity</value>
        [DataMember(Name = "list_price")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "list_price")]
        public decimal? ListPrice { get; set; }

        /// <summary>
        /// The list price per unit for the order line item.
        /// </summary>
        /// <value>The list price per unit for the order line item.</value>
        [DataMember(Name = "list_unit_price")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "list_unit_price")]
        public decimal? ListUnitPrice { get; set; }

        /// <summary>
        /// The name of the order line item.
        /// </summary>
        /// <value>The name of the order line item.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier for the order associated with this order line item.
        /// </summary>
        /// <value>The unique identifier for the order associated with this order line item.</value>
        [DataMember(Name = "order_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// The date when the subscription item is created through an order. This field is to standardize the booking date information to increase audit ability and traceability of data between Zuora Billing and Zuora Revenue. It is mapped as the booking date for a sales order line in Zuora Revenue.
        /// </summary>
        /// <value>The date when the subscription item is created through an order. This field is to standardize the booking date information to increase audit ability and traceability of data between Zuora Billing and Zuora Revenue. It is mapped as the booking date for a sales order line in Zuora Revenue.</value>
        [DataMember(Name = "original_order_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "original_order_date")]
        public DateTime? OriginalOrderDate { get; set; }

        /// <summary>
        /// The unique identifier of the original sales order for a return order line item.
        /// </summary>
        /// <value>The unique identifier of the original sales order for a return order line item.</value>
        [DataMember(Name = "original_order_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "original_order_id")]
        public string OriginalOrderId { get; set; }

        /// <summary>
        /// The unique identifier of the original sales order line item for a return order line item.
        /// </summary>
        /// <value>The unique identifier of the original sales order line item for a return order line item.</value>
        [DataMember(Name = "original_order_line_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "original_order_line_item_id")]
        public string OriginalOrderLineItemId { get; set; }

        /// <summary>
        /// The number of the original sales order line item for a return order line item.
        /// </summary>
        /// <value>The number of the original sales order line item for a return order line item.</value>
        [DataMember(Name = "original_order_line_item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "original_order_line_item_number")]
        public string OriginalOrderLineItemNumber { get; set; }

        /// <summary>
        /// The number of the original sales order for a return order line item.
        /// </summary>
        /// <value>The number of the original sales order for a return order line item.</value>
        [DataMember(Name = "original_order_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "original_order_number")]
        public string OriginalOrderNumber { get; set; }

        /// <summary>
        /// The unique identifier of a contact belonging to the billing account of the order line item that was the original sold to contact when the order line item was created.
        /// </summary>
        /// <value>The unique identifier of a contact belonging to the billing account of the order line item that was the original sold to contact when the order line item was created. </value>
        [DataMember(Name = "original_sold_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "original_sold_to_id")]
        public string OriginalSoldToId { get; set; }

        /// <summary>
        /// Identifier of the price.
        /// </summary>
        /// <value>Identifier of the price.</value>
        [DataMember(Name = "price_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// The product code for the order line item.
        /// </summary>
        /// <value>The product code for the order line item.</value>
        [DataMember(Name = "product_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// Used by customers to specify the Purchase Order Number provided by the buyer.
        /// </summary>
        /// <value>Used by customers to specify the Purchase Order Number provided by the buyer.</value>
        [DataMember(Name = "purchase_order_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchase_order_number")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The quantity of the product ordered.
        /// </summary>
        /// <value>The quantity of the product ordered.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The quantity of the product ordered available for return.
        /// </summary>
        /// <value>The quantity of the product ordered available for return.</value>
        [DataMember(Name = "quantity_available_for_return")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity_available_for_return")]
        public decimal? QuantityAvailableForReturn { get; set; }

        /// <summary>
        /// The quantity fulfilled.
        /// </summary>
        /// <value>The quantity fulfilled.</value>
        [DataMember(Name = "quantity_fulfilled")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity_fulfilled")]
        public decimal? QuantityFulfilled { get; set; }

        /// <summary>
        /// The quantity pending fulfillment.
        /// </summary>
        /// <value>The quantity pending fulfillment.</value>
        [DataMember(Name = "quantity_pending_fulfillment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity_pending_fulfillment")]
        public decimal? QuantityPendingFulfillment { get; set; }

        /// <summary>
        /// Use this field to relate an order line item to an subscription.
        /// </summary>
        /// <value>Use this field to relate an order line item to an subscription.</value>
        [DataMember(Name = "related_subscription_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "related_subscription_number")]
        public string RelatedSubscriptionNumber { get; set; }

        /// <summary>
        /// If true, a fulfillment is required to trigger billing.
        /// </summary>
        /// <value>If true, a fulfillment is required to trigger billing.</value>
        [DataMember(Name = "requires_fulfillment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requires_fulfillment")]
        public bool? RequiresFulfillment { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name = "revenue")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revenue")]
        public OrderLineItemRevenue Revenue { get; set; }

        /// <summary>
        /// The unique identifier of a contact belonging to the billing account of the order line item. Use this field to assign and existing contact as the sold to contact of an order line item.
        /// </summary>
        /// <value>The unique identifier of a contact belonging to the billing account of the order line item. Use this field to assign and existing contact as the sold to contact of an order line item.</value>
        [DataMember(Name = "sold_to_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sold_to_id")]
        public string SoldToId { get; set; }

        /// <summary>
        /// The date a transaction starts. The default value of this field is the order date.
        /// </summary>
        /// <value>The date a transaction starts. The default value of this field is the order date.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The state of an order line item. If you want to generate billing documents for order line items, you must set this field to `sent_to_billing`. For invoice preview, you do not need to set this field.
        /// </summary>
        /// <value>The state of an order line item. If you want to generate billing documents for order line items, you must set this field to `sent_to_billing`. For invoice preview, you do not need to set this field.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Total before discounts and taxes are applied.
        /// </summary>
        /// <value>Total before discounts and taxes are applied.</value>
        [DataMember(Name = "subtotal")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// All order line items that were unbilled on or before this date are included in future bill runs.
        /// </summary>
        /// <value>All order line items that were unbilled on or before this date are included in future bill runs.</value>
        [DataMember(Name = "target_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target_date")]
        public DateTime? TargetDate { get; set; }

        /// <summary>
        /// The tax code for the order line item.
        /// </summary>
        /// <value>The tax code for the order line item.</value>
        [DataMember(Name = "tax_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// If this field is set to `true`, it indicates that amounts are inclusive of tax.
        /// </summary>
        /// <value>If this field is set to `true`, it indicates that amounts are inclusive of tax.</value>
        [DataMember(Name = "tax_inclusive")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_inclusive")]
        public bool? TaxInclusive { get; set; }

        /// <summary>
        /// Total after discounts and taxes.
        /// </summary>
        /// <value>Total after discounts and taxes.</value>
        [DataMember(Name = "total")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// The type of the order line item.
        /// </summary>
        /// <value>The type of the order line item.</value>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts..
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts..</value>
        [DataMember(Name = "unbilled_receivables_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unbilled_receivables_account")]
        public string UnbilledReceivablesAccount { get; set; }

        /// <summary>
        /// The unit amount to be charged.
        /// </summary>
        /// <value>The unit amount to be charged.</value>
        [DataMember(Name = "unit_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_amount")]
        public decimal? UnitAmount { get; set; }

        /// <summary>
        /// A configured unit of measure.
        /// </summary>
        /// <value>A configured unit of measure.</value>
        [DataMember(Name = "unit_of_measure")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_of_measure")]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public string UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

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
            sb.Append("class OrderLineItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  AdjustmentLiabilityAccount: ").Append(AdjustmentLiabilityAccount).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  BillingRule: ").Append(BillingRule).Append("\n");
            sb.Append("  ContractAssetAccount: ").Append(ContractAssetAccount).Append("\n");
            sb.Append("  ContractLiabilityAccount: ").Append(ContractLiabilityAccount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DiscountUnitAmount: ").Append(DiscountUnitAmount).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ListUnitPrice: ").Append(ListUnitPrice).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RelatedSubscriptionNumber: ").Append(RelatedSubscriptionNumber).Append("\n");
            sb.Append("  SoldToId: ").Append(SoldToId).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  UnbilledReceivablesAccount: ").Append(UnbilledReceivablesAccount).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ItemNumber: ").Append(ItemNumber).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PriceId: ").Append(PriceId).Append("\n");
            sb.Append("  QuantityAvailableForReturn: ").Append(QuantityAvailableForReturn).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  InvoiceItems: ").Append(InvoiceItems).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  QuantityFulfilled: ").Append(QuantityFulfilled).Append("\n");
            sb.Append("  QuantityPendingFulfillment: ").Append(QuantityPendingFulfillment).Append("\n");
            sb.Append("  RequiresFulfillment: ").Append(RequiresFulfillment).Append("\n");
            sb.Append("  OriginalOrderDate: ").Append(OriginalOrderDate).Append("\n");
            sb.Append("  OriginalOrderId: ").Append(OriginalOrderId).Append("\n");
            sb.Append("  OriginalOrderLineItemId: ").Append(OriginalOrderLineItemId).Append("\n");
            sb.Append("  OriginalOrderLineItemNumber: ").Append(OriginalOrderLineItemNumber).Append("\n");
            sb.Append("  OriginalOrderNumber: ").Append(OriginalOrderNumber).Append("\n");
            sb.Append("  DiscountTotal: ").Append(DiscountTotal).Append("\n");
            sb.Append("  ListPrice: ").Append(ListPrice).Append("\n");
            sb.Append("  OriginalSoldToId: ").Append(OriginalSoldToId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}