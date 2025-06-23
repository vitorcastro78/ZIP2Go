using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Subscription item information.
    /// </summary>
    [DataContract]
    public class SubscriptionItem
    {
        /// <summary>
        /// Indicates whether the price is active and can be used for new purchases.
        /// </summary>
        /// <value>Indicates whether the price is active and can be used for new purchases.</value>
        [DataMember(Name = "active")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The amount of the price. Specify this field if you want to override the original price with a flat-fee price
        /// </summary>
        /// <value>The amount of the price. Specify this field if you want to override the original price with a flat-fee price</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Any combination of one_time, recurring and plan.
        /// </summary>
        /// <value>Any combination of one_time, recurring and plan.</value>
        [DataMember(Name = "apply_discount_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apply_discount_to")]
        public List<string> ApplyDiscountTo { get; set; }

        /// <summary>
        /// The date through which a customer has been billed for the subscription item.
        /// </summary>
        /// <value>The date through which a customer has been billed for the subscription item.</value>
        [DataMember(Name = "charged_through_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "charged_through_date")]
        public DateTime? ChargedThroughDate { get; set; }

        /// <summary>
        /// Charge model of the price. See [Charge models](https://knowledgecenter.zuora.com/Billing/Subscriptions/Product_Catalog/B_Charge_Models) for more information.
        /// </summary>
        /// <value>Charge model of the price. See [Charge models](https://knowledgecenter.zuora.com/Billing/Subscriptions/Product_Catalog/B_Charge_Models) for more information.</value>
        [DataMember(Name = "charge_model")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "charge_model")]
        public string ChargeModel { get; set; }

        /// <summary>
        /// Type of the charge. It can be one of the following types: one-time, recurring, or usage.
        /// </summary>
        /// <value>Type of the charge. It can be one of the following types: one-time, recurring, or usage.</value>
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
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public OneOfsubscriptionItemCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Discount amount. Specify this field if you offer an amount-based discount.
        /// </summary>
        /// <value>Discount amount. Specify this field if you offer an amount-based discount.</value>
        [DataMember(Name = "discount_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount_amount")]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// Specifies at what level a discount should be applied: one of account, subscription or plan.
        /// </summary>
        /// <value>Specifies at what level a discount should be applied: one of account, subscription or plan.</value>
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
        /// The date when the subscription item ends.
        /// </summary>
        /// <value>The date when the subscription item ends.</value>
        [DataMember(Name = "end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the subscription item.
        /// </summary>
        /// <value>The name of the subscription item.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Overage
        /// </summary>
        [DataMember(Name = "overage")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "overage")]
        public Overage Overage { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price")]
        public Price Price { get; set; }

        /// <summary>
        /// Specifies the base interval of the price the subscriber is subscribed to. If not provided, this field defaults to `billing_period`.
        /// </summary>
        /// <value>Specifies the base interval of the price the subscriber is subscribed to. If not provided, this field defaults to `billing_period`.</value>
        [DataMember(Name = "price_base_interval")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price_base_interval")]
        public string PriceBaseInterval { get; set; }

        /// <summary>
        /// Identifier of the price.
        /// </summary>
        /// <value>Identifier of the price.</value>
        [DataMember(Name = "price_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// The date until when charges are processed. When billing takes place in arrears, such as usage-based prices, this field value is the the same as the `ChargedThroughDate` value. This date is the earliest date when a charge can be amended.
        /// </summary>
        /// <value>The date until when charges are processed. When billing takes place in arrears, such as usage-based prices, this field value is the the same as the `ChargedThroughDate` value. This date is the earliest date when a charge can be amended.</value>
        [DataMember(Name = "processed_through_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processed_through_date")]
        public DateTime? ProcessedThroughDate { get; set; }

        /// <summary>
        /// Identifier of the product with which this subscription is associated.
        /// </summary>
        /// <value>Identifier of the product with which this subscription is associated.</value>
        [DataMember(Name = "product_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// Quantity of the product to which your customers subscribe.
        /// </summary>
        /// <value>Quantity of the product to which your customers subscribe.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recurring")]
        public Recurring Recurring { get; set; }

        /// <summary>
        /// The date when the subscription item starts.
        /// </summary>
        /// <value>The date when the subscription item starts.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Specifies when to start billing your customer.
        /// </summary>
        /// <value>Specifies when to start billing your customer.</value>
        [DataMember(Name = "start_event")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_event")]
        public string StartEvent { get; set; }

        /// <summary>
        /// Based on the current date to populate a state field with the enumeration: [inactive, active, expired] where inactive would represent charge segments with a start_date in the future and expired charge segments with an end_date in the past.
        /// </summary>
        /// <value>Based on the current date to populate a state field with the enumeration: [inactive, active, expired] where inactive would represent charge segments with a start_date in the future and expired charge segments with an end_date in the past.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Human-readable identifier of the subscription item. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the subscription item. It can be user-supplied.</value>
        [DataMember(Name = "subscription_item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_number")]
        public string SubscriptionItemNumber { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionPlan
        /// </summary>
        [DataMember(Name = "subscription_plan")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plan")]
        public SubscriptionPlan SubscriptionPlan { get; set; }

        /// <summary>
        /// Identifier of the subscription plan this subscription item belongs to.
        /// </summary>
        /// <value>Identifier of the subscription plan this subscription item belongs to.</value>
        [DataMember(Name = "subscription_plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plan_id")]
        public string SubscriptionPlanId { get; set; }

        /// <summary>
        /// A tax code identifier. If the `tax_code` of a price is not provided when you create or override a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly.
        /// </summary>
        /// <value>A tax code identifier. If the `tax_code` of a price is not provided when you create or override a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly.</value>
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
        /// Gets or Sets Tiers
        /// </summary>
        [DataMember(Name = "tiers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tiers")]
        public List<ItemTier> Tiers { get; set; }

        /// <summary>
        /// Specifies the kind of tiering.
        /// </summary>
        /// <value>Specifies the kind of tiering.</value>
        [DataMember(Name = "tiers_mode")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tiers_mode")]
        public string TiersMode { get; set; }

        /// <summary>
        /// The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.
        /// </summary>
        /// <value>The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.</value>
        [DataMember(Name = "unit_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_amount")]
        public decimal? UnitAmount { get; set; }

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
            sb.Append("class SubscriptionItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  SubscriptionItemNumber: ").Append(SubscriptionItemNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ChargedThroughDate: ").Append(ChargedThroughDate).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StartEvent: ").Append(StartEvent).Append("\n");
            sb.Append("  TiersMode: ").Append(TiersMode).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  ApplyDiscountTo: ").Append(ApplyDiscountTo).Append("\n");
            sb.Append("  DiscountLevel: ").Append(DiscountLevel).Append("\n");
            sb.Append("  PriceBaseInterval: ").Append(PriceBaseInterval).Append("\n");
            sb.Append("  Overage: ").Append(Overage).Append("\n");
            sb.Append("  ChargeModel: ").Append(ChargeModel).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  PriceId: ").Append(PriceId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  SubscriptionPlanId: ").Append(SubscriptionPlanId).Append("\n");
            sb.Append("  SubscriptionPlan: ").Append(SubscriptionPlan).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ProcessedThroughDate: ").Append(ProcessedThroughDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}