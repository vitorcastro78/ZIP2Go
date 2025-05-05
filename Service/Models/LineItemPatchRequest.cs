using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Update an order line item
    /// </summary>
    [DataContract]
    public class LineItemPatchRequest
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
        /// Category of the order line item.
        /// </summary>
        /// <value>Category of the order line item.</value>
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
        /// Discount percent.
        /// </summary>
        /// <value>Discount percent.</value>
        [DataMember(Name = "discount_percent")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount_percent")]
        public decimal? DiscountPercent { get; set; }

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
        /// Human-readable identifier of the order item. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the order item. It can be user-supplied.</value>
        [DataMember(Name = "item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "item_number")]
        public string ItemNumber { get; set; }

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
        /// Use this field to relate an order line item to an subscription.
        /// </summary>
        /// <value>Use this field to relate an order line item to an subscription.</value>
        [DataMember(Name = "related_subscription_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "related_subscription_number")]
        public string RelatedSubscriptionNumber { get; set; }

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
            sb.Append("class LineItemPatchRequest {\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  AdjustmentLiabilityAccount: ").Append(AdjustmentLiabilityAccount).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  BillingRule: ").Append(BillingRule).Append("\n");
            sb.Append("  ContractAssetAccount: ").Append(ContractAssetAccount).Append("\n");
            sb.Append("  ContractLiabilityAccount: ").Append(ContractLiabilityAccount).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}