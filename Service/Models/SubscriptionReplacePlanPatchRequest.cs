using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionReplacePlanPatchRequest
    {
        /// <summary>
        /// Identifier of the plan to be removed. Only provide one of `previous_plan_id` or `subscription_plan_id` in your request, not both.
        /// </summary>
        /// <value>Identifier of the plan to be removed. Only provide one of `previous_plan_id` or `subscription_plan_id` in your request, not both.</value>
        [DataMember(Name = "previous_plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previous_plan_id")]
        public string PreviousPlanId { get; set; }

        /// <summary>
        /// The default value for the `replace_at` field is as follows:       <ul>         <li>If the subscription plan change (from old to new) is an upgrade, the `replace_at` is `now` by default. </li>         <li>If the subscription change (from old to new) is a downgrade, the `replace_at` is `end_of_billing_period` by default. </li>       </ul>       Otherwise, the `replace_at` is `specific_date` by default.            **Notes**:      <br />       When setting this field to `end_of_billing_period`, you cannot set the billing start dates for the subscription as the system will automatically set the start dates to the end of billing period, and you cannot set the following billing trigger date settings to `Yes`:      <ul>         <li> <a href=\"https://knowledgecenter.zuora.com/Zuora_Billing/Configure_billing_settings/Subscription_and_order_settings/A_Define_Default_Subscription_and_Order_Settings#Require_Customer_Acceptance_of_Orders.3F\" target=\"_blank\">Require Customer Acceptance of Orders</a> </li>         <li> <a href=\"https://knowledgecenter.zuora.com/Zuora_Billing/Billing_and_Invoicing/Billing_Settings/Define_Default_Subscription_and_Order_Settings#Require_Service_Activation_of_Orders.3F\" target=\"_blank\">Require Service Activation of Orders</a> </li>       </ul>       When setting this field to `specific_date`, you must also specify a date for the `contract_effective` date in the `start_on` field.
        /// </summary>
        /// <value>The default value for the `replace_at` field is as follows:       <ul>         <li>If the subscription plan change (from old to new) is an upgrade, the `replace_at` is `now` by default. </li>         <li>If the subscription change (from old to new) is a downgrade, the `replace_at` is `end_of_billing_period` by default. </li>       </ul>       Otherwise, the `replace_at` is `specific_date` by default.            **Notes**:      <br />       When setting this field to `end_of_billing_period`, you cannot set the billing start dates for the subscription as the system will automatically set the start dates to the end of billing period, and you cannot set the following billing trigger date settings to `Yes`:      <ul>         <li> <a href=\"https://knowledgecenter.zuora.com/Zuora_Billing/Configure_billing_settings/Subscription_and_order_settings/A_Define_Default_Subscription_and_Order_Settings#Require_Customer_Acceptance_of_Orders.3F\" target=\"_blank\">Require Customer Acceptance of Orders</a> </li>         <li> <a href=\"https://knowledgecenter.zuora.com/Zuora_Billing/Billing_and_Invoicing/Billing_Settings/Define_Default_Subscription_and_Order_Settings#Require_Service_Activation_of_Orders.3F\" target=\"_blank\">Require Service Activation of Orders</a> </li>       </ul>       When setting this field to `specific_date`, you must also specify a date for the `contract_effective` date in the `start_on` field.     </value>
        [DataMember(Name = "replace_at")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replace_at")]
        public string ReplaceAt { get; set; }

        /// <summary>
        /// Gets or Sets ReplacementType
        /// </summary>
        [DataMember(Name = "replacement_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replacement_type")]
        public string ReplacementType { get; set; }

        /// <summary>
        /// Gets or Sets StartOn
        /// </summary>
        [DataMember(Name = "start_on")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_on")]
        public StartOn StartOn { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionPlan
        /// </summary>
        [DataMember(Name = "subscription_plan")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plan")]
        public SubscriptionPlanCreateRequest SubscriptionPlan { get; set; }

        /// <summary>
        /// Identifier of the subscription plan. Only provide one of `previous_plan_id` or `subscription_plan_id` in your request, not both.
        /// </summary>
        /// <value>Identifier of the subscription plan. Only provide one of `previous_plan_id` or `subscription_plan_id` in your request, not both.</value>
        [DataMember(Name = "subscription_plan_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plan_id")]
        public string SubscriptionPlanId { get; set; }

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
            sb.Append("class SubscriptionReplacePlanPatchRequest {\n");
            sb.Append("  SubscriptionPlanId: ").Append(SubscriptionPlanId).Append("\n");
            sb.Append("  PreviousPlanId: ").Append(PreviousPlanId).Append("\n");
            sb.Append("  ReplaceAt: ").Append(ReplaceAt).Append("\n");
            sb.Append("  ReplacementType: ").Append(ReplacementType).Append("\n");
            sb.Append("  SubscriptionPlan: ").Append(SubscriptionPlan).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}