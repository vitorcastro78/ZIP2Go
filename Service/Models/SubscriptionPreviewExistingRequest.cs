using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionPreviewExistingRequest
    {
        /// <summary>
        /// Gets or Sets AccountData
        /// </summary>
        [DataMember(Name = "account_data")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_data")]
        public SubscriptionPreviewAccountRequest AccountData { get; set; }

        /// <summary>
        /// Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account.
        /// </summary>
        /// <value>Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account.
        /// </summary>
        /// <value>Identifier of the account that owns the subscription. Subscription owner account can be different from the invoice owner account.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Specify this field if you want to add one or multiple subscription plans to this subscription.
        /// </summary>
        /// <value>Specify this field if you want to add one or multiple subscription plans to this subscription.</value>
        [DataMember(Name = "add_subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "add_subscription_plans")]
        public List<SubscriptionAddPlanPatchRequest> AddSubscriptionPlans { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Description of the subscription.
        /// </summary>
        /// <value>Description of the subscription.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// End date of the period for which you want to preview the subscription
        /// </summary>
        /// <value>End date of the period for which you want to preview the subscription</value>
        [DataMember(Name = "end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Specifies the metrics you want to preview.    You can preview metrics of billing documents, the order delta metrics, or both.
        /// </summary>
        /// <value>Specifies the metrics you want to preview.    You can preview metrics of billing documents, the order delta metrics, or both.</value>
        [DataMember(Name = "metrics")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "metrics")]
        public List<string> Metrics { get; set; }

        /// <summary>
        /// Specifies how many billing periods you want to preview.
        /// </summary>
        /// <value>Specifies how many billing periods you want to preview.</value>
        [DataMember(Name = "number_of_periods")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_periods")]
        public int? NumberOfPeriods { get; set; }

        /// <summary>
        /// Specify this field if you want to remove one or multiple subscription plans from this subscription.
        /// </summary>
        /// <value>Specify this field if you want to remove one or multiple subscription plans from this subscription.</value>
        [DataMember(Name = "remove_subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remove_subscription_plans")]
        public List<SubscriptionRemovePlanPatchRequest> RemoveSubscriptionPlans { get; set; }

        /// <summary>
        /// Specify this field if you want to replace one or multiple subscription plans to this subscription. <br />            **Note**: This field is currently not supported if you have Billing - Revenue Integration enabled. When Billing - Revenue Integration is enabled, the replace subscription plan type of order action will no longer be applicable in Zuora Billing.
        /// </summary>
        /// <value>Specify this field if you want to replace one or multiple subscription plans to this subscription. <br />            **Note**: This field is currently not supported if you have Billing - Revenue Integration enabled. When Billing - Revenue Integration is enabled, the replace subscription plan type of order action will no longer be applicable in Zuora Billing. </value>
        [DataMember(Name = "replace_subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replace_subscription_plans")]
        public List<SubscriptionReplacePlanPatchRequest> ReplaceSubscriptionPlans { get; set; }

        /// <summary>
        /// Indicates whether to preview the subscription till the end of the current term.
        /// </summary>
        /// <value>Indicates whether to preview the subscription till the end of the current term.</value>
        [DataMember(Name = "term_end")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "term_end")]
        public bool? TermEnd { get; set; }

        /// <summary>
        /// Gets or Sets UpdateSubscriptionPlans
        /// </summary>
        [DataMember(Name = "update_subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "update_subscription_plans")]
        public List<SubscriptionUpdatePlanPatchRequest> UpdateSubscriptionPlans { get; set; }

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
            sb.Append("class SubscriptionPreviewExistingRequest {\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountData: ").Append(AccountData).Append("\n");
            sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
            sb.Append("  TermEnd: ").Append(TermEnd).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  AddSubscriptionPlans: ").Append(AddSubscriptionPlans).Append("\n");
            sb.Append("  ReplaceSubscriptionPlans: ").Append(ReplaceSubscriptionPlans).Append("\n");
            sb.Append("  UpdateSubscriptionPlans: ").Append(UpdateSubscriptionPlans).Append("\n");
            sb.Append("  RemoveSubscriptionPlans: ").Append(RemoveSubscriptionPlans).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}