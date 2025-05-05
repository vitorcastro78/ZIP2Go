using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Plan information.
    /// </summary>
    [DataContract]
    public class ProductPlan
    {
        /// <summary>
        /// Whether the plan can be used for new purchases.
        /// </summary>
        /// <value>Whether the plan can be used for new purchases.</value>
        [DataMember(Name = "active")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A list of 3-letter ISO-standard currency codes representing active currencies for the plan.
        /// </summary>
        /// <value>A list of 3-letter ISO-standard currency codes representing active currencies for the plan.</value>
        [DataMember(Name = "active_currencies")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "active_currencies")]
        public List<string> ActiveCurrencies { get; set; }

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
        /// The date on which the plan can no longer be used for new purchases.
        /// </summary>
        /// <value>The date on which the plan can no longer be used for new purchases.</value>
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
        /// The name of the plan.
        /// </summary>
        /// <value>The name of the plan.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Human-readable identifier of the plan. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the plan. It can be user-supplied.</value>
        [DataMember(Name = "plan_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan_number")]
        public string PlanNumber { get; set; }

        /// <summary>
        /// A list of prices.
        /// </summary>
        /// <value>A list of prices.</value>
        [DataMember(Name = "prices")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prices")]
        public List<ProductPrice> Prices { get; set; }

        /// <summary>
        /// The product associated with this plan.
        /// </summary>
        /// <value>The product associated with this plan.</value>
        [DataMember(Name = "product")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "product")]
        public Product Product { get; set; }

        /// <summary>
        /// Identifier of the product associated with this plan.
        /// </summary>
        /// <value>Identifier of the product associated with this plan.</value>
        [DataMember(Name = "product_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// The product sku. This field is only availble for customers using high speed cache.
        /// </summary>
        /// <value>The product sku. This field is only availble for customers using high speed cache.</value>
        [DataMember(Name = "sku")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// The date from which the plan can be used for new purchases.
        /// </summary>
        /// <value>The date from which the plan can be used for new purchases.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

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
            sb.Append("class Plan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlanNumber: ").Append(PlanNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActiveCurrencies: ").Append(ActiveCurrencies).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}