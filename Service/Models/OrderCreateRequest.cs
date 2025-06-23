using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class OrderCreateRequest
    {
        /// <summary>
        /// The information of the new account that owns the subscription. The subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_id`.
        /// </summary>
        /// <value>The information of the new account that owns the subscription. The subscription owner account can be different from the invoice owner account. If you specify this field, do not specify `account_id`.</value>
        [DataMember(Name = "account_data")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_data")]
        public AllOforderCreateRequestAccountData AccountData { get; set; }

        /// <summary>
        /// Identifier of the account.
        /// </summary>
        /// <value>Identifier of the account.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Human-readable identifier of the account. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the account. It can be user-supplied.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Category of the order to indicate a product sale or return. Default value is `sale`.
        /// </summary>
        /// <value>Category of the order to indicate a product sale or return. Default value is `sale`.</value>
        [DataMember(Name = "category")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public OneOforderCreateRequestCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Order line items are non-subscription-based items created by an order, representing transactional charges such as one-time fees, physical goods, or professional service charges that are not sold as subscription services.    By specifying this field, you can launch non-subscription and unified monetization business models in Zuora, in addition to subscription business models.
        /// </summary>
        /// <value>Order line items are non-subscription-based items created by an order, representing transactional charges such as one-time fees, physical goods, or professional service charges that are not sold as subscription services.    By specifying this field, you can launch non-subscription and unified monetization business models in Zuora, in addition to subscription business models.</value>
        [DataMember(Name = "line_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "line_items")]
        public List<LineItemCreateRequest> LineItems { get; set; }

        /// <summary>
        /// The date when the order is signed. All the order actions under this order will use this order date as the contract effective date if the contract effective date field is skipped or its value is left as null.
        /// </summary>
        /// <value>The date when the order is signed. All the order actions under this order will use this order date as the contract effective date if the contract effective date field is skipped or its value is left as null.</value>
        [DataMember(Name = "order_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order_date")]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// The order number of the new order. If not provided, system will auto-generate a number for this order.     Note: Ensure that the order number does not contain a slash.
        /// </summary>
        /// <value>The order number of the new order. If not provided, system will auto-generate a number for this order.     Note: Ensure that the order number does not contain a slash.</value>
        [DataMember(Name = "order_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingOptions
        /// </summary>
        [DataMember(Name = "processing_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processing_options")]
        public OrdersProcessingOption ProcessingOptions { get; set; }

        /// <summary>
        /// The status of the order.
        /// </summary>
        /// <value>The status of the order.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Based on the intended order action, each item should include specific fields.     For example, to create a new subscription for a new account, you must specify the `account_data` and `subscription_plans` fields at a minimum.
        /// </summary>
        /// <value>Based on the intended order action, each item should include specific fields.     For example, to create a new subscription for a new account, you must specify the `account_data` and `subscription_plans` fields at a minimum.</value>
        [DataMember(Name = "subscriptions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptions")]
        public List<PostSubscriptionOrderRequest> Subscriptions { get; set; }

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
            sb.Append("class OrderCreateRequest {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountData: ").Append(AccountData).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ProcessingOptions: ").Append(ProcessingOptions).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}