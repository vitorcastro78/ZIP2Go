using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionItemCreateRequest
    {
        /// <summary>
        /// The amount of the price. Specify this field if you want to override the original price with a flat-fee price
        /// </summary>
        /// <value>The amount of the price. Specify this field if you want to override the original price with a flat-fee price</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Any combination of one-time, recurring, and usage.
        /// </summary>
        /// <value>Any combination of one-time, recurring, and usage.</value>
        [DataMember(Name = "apply_discount_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apply_discount_to")]
        public List<string> ApplyDiscountTo { get; set; }

        /// <summary>
        /// Name of the custom field that will be used to set a per unit rate under the `Pre-Rated Per Unit` charge model
        /// </summary>
        /// <value>Name of the custom field that will be used to set a per unit rate under the `Pre-Rated Per Unit` charge model </value>
        [DataMember(Name = "custom_field_per_unit_rate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_field_per_unit_rate")]
        public string CustomFieldPerUnitRate { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Name of the custom field that will be used to set a total amount under the `Pre-Rated` charge model
        /// </summary>
        /// <value>Name of the custom field that will be used to set a total amount under the `Pre-Rated` charge model </value>
        [DataMember(Name = "custom_field_total_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_field_total_amount")]
        public string CustomFieldTotalAmount { get; set; }

        /// <summary>
        /// Description of the price. Often useful for displaying to users.
        /// </summary>
        /// <value>Description of the price. Often useful for displaying to users.</value>
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
        /// Gets or Sets Drawdown
        /// </summary>
        [DataMember(Name = "drawdown")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drawdown")]
        public SubscriptionItemDrawdownField Drawdown { get; set; }

        /// <summary>
        /// The date when the subscription item ends or ended.
        /// </summary>
        /// <value>The date when the subscription item ends or ended.</value>
        [DataMember(Name = "end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Overage
        /// </summary>
        [DataMember(Name = "overage")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "overage")]
        public Overage Overage { get; set; }

        /// <summary>
        /// Gets or Sets Prepayment
        /// </summary>
        [DataMember(Name = "prepayment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prepayment")]
        public SubscriptionItemPrepaymentField Prepayment { get; set; }

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
        /// The date when the subscription item starts
        /// </summary>
        /// <value>The date when the subscription item starts</value>
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
        /// Human-readable identifier of the subscription item. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the subscription item. It can be user-supplied.</value>
        [DataMember(Name = "subscription_item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_number")]
        public string SubscriptionItemNumber { get; set; }

        /// <summary>
        /// Information of all tiers if the price is a tiered price.
        /// </summary>
        /// <value>Information of all tiers if the price is a tiered price.</value>
        [DataMember(Name = "tiers")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tiers")]
        public List<ItemTier> Tiers { get; set; }

        /// <summary>
        /// Specifies the mode of tiering.
        /// </summary>
        /// <value>Specifies the mode of tiering.</value>
        [DataMember(Name = "tiers_mode")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tiers_mode")]
        public string TiersMode { get; set; }

        /// <summary>
        /// Unique identifier for the price. This identifier enables you to refer to the price before the price has an internal identifier in Zuora.
        /// </summary>
        /// <value>Unique identifier for the price. This identifier enables you to refer to the price before the price has an internal identifier in Zuora.</value>
        [DataMember(Name = "unique_token")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unique_token")]
        public string UniqueToken { get; set; }

        /// <summary>
        /// The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.
        /// </summary>
        /// <value>The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.</value>
        [DataMember(Name = "unit_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_amount")]
        public decimal? UnitAmount { get; set; }

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
            sb.Append("class SubscriptionItemCreateRequest {\n");
            sb.Append("  PriceId: ").Append(PriceId).Append("\n");
            sb.Append("  SubscriptionItemNumber: ").Append(SubscriptionItemNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  StartEvent: ").Append(StartEvent).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TiersMode: ").Append(TiersMode).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  PriceBaseInterval: ").Append(PriceBaseInterval).Append("\n");
            sb.Append("  Overage: ").Append(Overage).Append("\n");
            sb.Append("  UniqueToken: ").Append(UniqueToken).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  ApplyDiscountTo: ").Append(ApplyDiscountTo).Append("\n");
            sb.Append("  DiscountLevel: ").Append(DiscountLevel).Append("\n");
            sb.Append("  CustomFieldPerUnitRate: ").Append(CustomFieldPerUnitRate).Append("\n");
            sb.Append("  CustomFieldTotalAmount: ").Append(CustomFieldTotalAmount).Append("\n");
            sb.Append("  Prepayment: ").Append(Prepayment).Append("\n");
            sb.Append("  Drawdown: ").Append(Drawdown).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}