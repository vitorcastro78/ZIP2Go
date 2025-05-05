using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Usage
    {
        /// <summary>
        /// The account that owns the usages. EXPANDABLE
        /// </summary>
        /// <value>The account that owns the usages. EXPANDABLE</value>
        [DataMember(Name = "account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account")]
        public Account Account { get; set; }

        /// <summary>
        /// Identifier of the account associated with this subscription. Either `account_id` or `account_number` is required.
        /// </summary>
        /// <value>Identifier of the account associated with this subscription. Either `account_id` or `account_number` is required.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Human-readable identifier of the account. It can be user-supplied. Either `account_number` or `account_id` is required.
        /// </summary>
        /// <value>Human-readable identifier of the account. It can be user-supplied. Either `account_number` or `account_id` is required.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

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
        /// The end time for which usage is recorded.
        /// </summary>
        /// <value>The end time for which usage is recorded.</value>
        [DataMember(Name = "end_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The start time for which usage is recorded.
        /// </summary>
        /// <value>The start time for which usage is recorded.</value>
        [DataMember(Name = "start_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_time")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// The identifier of the subscription associated with the billing document item.
        /// </summary>
        /// <value>The identifier of the subscription associated with the billing document item.</value>
        [DataMember(Name = "subscription_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Identifier of the subscription item.
        /// </summary>
        /// <value>Identifier of the subscription item.</value>
        [DataMember(Name = "subscription_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_id")]
        public string SubscriptionItemId { get; set; }

        /// <summary>
        /// Human-readable identifier of the subscription item.
        /// </summary>
        /// <value>Human-readable identifier of the subscription item.</value>
        [DataMember(Name = "subscription_item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_number")]
        public string SubscriptionItemNumber { get; set; }

        /// <summary>
        /// Human-readable identifier of the subscription. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the subscription. It can be user-supplied.</value>
        [DataMember(Name = "subscription_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_number")]
        public string SubscriptionNumber { get; set; }

        /// <summary>
        /// Specifies the units to measure usage. Units of measure are configured in Zuora Central. Your values depend on your configuration in Billing Settings.
        /// </summary>
        /// <value>Specifies the units to measure usage. Units of measure are configured in Zuora Central. Your values depend on your configuration in Billing Settings.</value>
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
            sb.Append("class Usage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  SubscriptionItemId: ").Append(SubscriptionItemId).Append("\n");
            sb.Append("  SubscriptionItemNumber: ").Append(SubscriptionItemNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  SubscriptionNumber: ").Append(SubscriptionNumber).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}