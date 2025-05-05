using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Price information.
    /// </summary>
    [DataContract]
    public class Price
    {
        /// <summary>
        /// An active accounting code defined in **Finance Settings > Configure Accounting Codes** in your Zuora tenant.
        /// </summary>
        /// <value>An active accounting code defined in **Finance Settings > Configure Accounting Codes** in your Zuora tenant.</value>
        [DataMember(Name = "accounting_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accounting_code")]
        public string AccountingCode { get; set; }

        /// <summary>
        /// Whether the price can be used for new purchases.
        /// </summary>
        /// <value>Whether the price can be used for new purchases.</value>
        [DataMember(Name = "active")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets Amounts
        /// </summary>
        [DataMember(Name = "amounts")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amounts")]
        public Dictionary<string, decimal?> Amounts { get; set; }

        /// <summary>
        /// Any combination of one_time, recurring and plan.
        /// </summary>
        /// <value>Any combination of one_time, recurring and plan.</value>
        [DataMember(Name = "apply_discount_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apply_discount_to")]
        public List<string> ApplyDiscountTo { get; set; }

        /// <summary>
        /// The charge model of the price, which determines how users are charged. Common charge models include flat fee, per-unit, volume, and tiered prices.
        /// </summary>
        /// <value>The charge model of the price, which determines how users are charged. Common charge models include flat fee, per-unit, volume, and tiered prices.</value>
        [DataMember(Name = "charge_model")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "charge_model")]
        public string ChargeModel { get; set; }

        /// <summary>
        /// The type of charge. Can be `one_time`,`recurring`, or `usage`.
        /// </summary>
        /// <value>The type of charge. Can be `one_time`,`recurring`, or `usage`.</value>
        [DataMember(Name = "charge_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "charge_type")]
        public string ChargeType { get; set; }

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
        /// Name of the custom field that will be used to set a per unit rate under the `Pre-Rated Per Unit` charge model
        /// </summary>
        /// <value>Name of the custom field that will be used to set a per unit rate under the `Pre-Rated Per Unit` charge model </value>
        [DataMember(Name = "custom_field_per_unit_rate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_field_per_unit_rate")]
        public string CustomFieldPerUnitRate { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// Name of the custom field that will be used to set a total amount under the `Pre-Rated` charge model
        /// </summary>
        /// <value>Name of the custom field that will be used to set a total amount under the `Pre-Rated` charge model </value>
        [DataMember(Name = "custom_field_total_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_field_total_amount")]
        public string CustomFieldTotalAmount { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public OneOfPriceCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "deferred_revenue_accounting_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deferred_revenue_accounting_code")]
        public string DeferredRevenueAccountingCode { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmounts
        /// </summary>
        [DataMember(Name = "discount_amounts")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount_amounts")]
        public Dictionary<string, decimal?> DiscountAmounts { get; set; }

        /// <summary>
        /// Specifies at what level a discount should be applied: account, subscription, or plan.
        /// </summary>
        /// <value>Specifies at what level a discount should be applied: account, subscription, or plan.</value>
        [DataMember(Name = "discount_level")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount_level")]
        public string DiscountLevel { get; set; }

        /// <summary>
        /// Discount percent. Specify this field if you offer a percentage-based discount.
        /// </summary>
        /// <value>Discount percent. Specify this field if you offer a percentage-based discount.</value>
        [DataMember(Name = "discount_percent")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount_percent")]
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// Gets or Sets Drawdown
        /// </summary>
        [DataMember(Name = "drawdown")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drawdown")]
        public Drawdown Drawdown { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The maximum quantity for a price. Specify this field and the `min_quantity` field to create a range of quantities allowed in a price.
        /// </summary>
        /// <value>The maximum quantity for a price. Specify this field and the `min_quantity` field to create a range of quantities allowed in a price.</value>
        [DataMember(Name = "max_quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "max_quantity")]
        public decimal? MaxQuantity { get; set; }

        /// <summary>
        /// The minimum quantity for a price. Specify this field and the `max_quantity` field to create a range of quantities allowed in a price.
        /// </summary>
        /// <value>The minimum quantity for a price. Specify this field and the `max_quantity` field to create a range of quantities allowed in a price.</value>
        [DataMember(Name = "min_quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "min_quantity")]
        public decimal? MinQuantity { get; set; }

        /// <summary>
        /// The name of the price.
        /// </summary>
        /// <value>The name of the price.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Overage
        /// </summary>
        [DataMember(Name = "overage")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "overage")]
        public AllOfPriceOverage Overage { get; set; }

        /// <summary>
        /// Specify the ID of a plan to which this price is associated.
        /// </summary>
        /// <value>Specify the ID of a plan to which this price is associated.</value>
        [DataMember(Name = "plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// Specify the number of a plan to which this price is associated. This field is required if plan_id is not supplied
        /// </summary>
        /// <value>Specify the number of a plan to which this price is associated. This field is required if plan_id is not supplied</value>
        [DataMember(Name = "plan_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan_number")]
        public string PlanNumber { get; set; }

        /// <summary>
        /// Gets or Sets Prepayment
        /// </summary>
        [DataMember(Name = "prepayment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prepayment")]
        public Prepayment Prepayment { get; set; }

        /// <summary>
        /// Specifies the base interval of a price. If not provided, this field defaults to `billing_period`.
        /// </summary>
        /// <value>Specifies the base interval of a price. If not provided, this field defaults to `billing_period`.</value>
        [DataMember(Name = "price_base_interval")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price_base_interval")]
        public string PriceBaseInterval { get; set; }

        /// <summary>
        /// Quantity of the product to which your customers subscribe.
        /// </summary>
        /// <value>Quantity of the product to which your customers subscribe.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "recognized_revenue_accounting_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recognized_revenue_accounting_code")]
        public string RecognizedRevenueAccountingCode { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recurring")]
        public Recurring Recurring { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name = "revenue")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revenue")]
        public AllOfPriceRevenue Revenue { get; set; }

        /// <summary>
        /// Determines when to recognize the revenue for this charge. You can choose to recognize upon invoicing or daily over time.
        /// </summary>
        /// <value>Determines when to recognize the revenue for this charge. You can choose to recognize upon invoicing or daily over time.</value>
        [DataMember(Name = "revenue_recognition_rule")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revenue_recognition_rule")]
        public string RevenueRecognitionRule { get; set; }

        /// <summary>
        /// This field is only applicable for the Percentage Discount price. This field indicates whether the discount is to be calculated as stacked discount. Possible values are as follows:        <ul>       <li>`true`: This is a stacked discount, which should be calculated by stacking with other discounts.</li>       <li> `false`: This is not a stacked discount, which should be calculated in sequence with other discounts.</li></ul> For more information, see <a href='https://knowledgecenter.zuora.com/Zuora_Billing/Products/Product_Catalog/B_Charge_Models/B_Discount_Charge_Models' target='_blank'>Stacked discounts</a>
        /// </summary>
        /// <value>This field is only applicable for the Percentage Discount price. This field indicates whether the discount is to be calculated as stacked discount. Possible values are as follows:        <ul>       <li>`true`: This is a stacked discount, which should be calculated by stacking with other discounts.</li>       <li> `false`: This is not a stacked discount, which should be calculated in sequence with other discounts.</li></ul> For more information, see <a href='https://knowledgecenter.zuora.com/Zuora_Billing/Products/Product_Catalog/B_Charge_Models/B_Discount_Charge_Models' target='_blank'>Stacked discounts</a></value>
        [DataMember(Name = "stacked_discount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "stacked_discount")]
        public bool? StackedDiscount { get; set; }

        /// <summary>
        /// Specifies when to start billing your customer.
        /// </summary>
        /// <value>Specifies when to start billing your customer.</value>
        [DataMember(Name = "start_event")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_event")]
        public string StartEvent { get; set; }

        /// <summary>
        /// Gets or Sets Taxable
        /// </summary>
        [DataMember(Name = "taxable")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxable")]
        public bool? Taxable { get; set; }

        /// <summary>
        /// A tax code identifier. If a `tax_code` of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly.
        /// </summary>
        /// <value>A tax code identifier. If a `tax_code` of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly.</value>
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
        /// Price information for different tiers. When creating or updating tiered prices, you must specify this field and the `tiers_mode` field.
        /// </summary>
        /// <value>Price information for different tiers. When creating or updating tiered prices, you must specify this field and the `tiers_mode` field.</value>
        [DataMember(Name = "tiers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tiers")]
        public List<Tier> Tiers { get; set; }

        /// <summary>
        /// Specifies the mode for tiered prices.
        /// </summary>
        /// <value>Specifies the mode for tiered prices.</value>
        [DataMember(Name = "tiers_mode")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tiers_mode")]
        public string TiersMode { get; set; }

        /// <summary>
        /// Gets or Sets UnitAmounts
        /// </summary>
        [DataMember(Name = "unit_amounts")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_amounts")]
        public Dictionary<string, decimal?> UnitAmounts { get; set; }

        /// <summary>
        /// A configured unit of measure. This field is required for per-unit prices.
        /// </summary>
        /// <value>A configured unit of measure. This field is required for per-unit prices.</value>
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
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Price {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RecognizedRevenueAccountingCode: ").Append(RecognizedRevenueAccountingCode).Append("\n");
            sb.Append("  DeferredRevenueAccountingCode: ").Append(DeferredRevenueAccountingCode).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  StartEvent: ").Append(StartEvent).Append("\n");
            sb.Append("  TiersMode: ").Append(TiersMode).Append("\n");
            sb.Append("  ApplyDiscountTo: ").Append(ApplyDiscountTo).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  MinQuantity: ").Append(MinQuantity).Append("\n");
            sb.Append("  MaxQuantity: ").Append(MaxQuantity).Append("\n");
            sb.Append("  DiscountLevel: ").Append(DiscountLevel).Append("\n");
            sb.Append("  RevenueRecognitionRule: ").Append(RevenueRecognitionRule).Append("\n");
            sb.Append("  StackedDiscount: ").Append(StackedDiscount).Append("\n");
            sb.Append("  Amounts: ").Append(Amounts).Append("\n");
            sb.Append("  UnitAmounts: ").Append(UnitAmounts).Append("\n");
            sb.Append("  DiscountAmounts: ").Append(DiscountAmounts).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  PriceBaseInterval: ").Append(PriceBaseInterval).Append("\n");
            sb.Append("  Overage: ").Append(Overage).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  Prepayment: ").Append(Prepayment).Append("\n");
            sb.Append("  Drawdown: ").Append(Drawdown).Append("\n");
            sb.Append("  Taxable: ").Append(Taxable).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  PlanNumber: ").Append(PlanNumber).Append("\n");
            sb.Append("  CustomFieldPerUnitRate: ").Append(CustomFieldPerUnitRate).Append("\n");
            sb.Append("  CustomFieldTotalAmount: ").Append(CustomFieldTotalAmount).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  ChargeModel: ").Append(ChargeModel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}