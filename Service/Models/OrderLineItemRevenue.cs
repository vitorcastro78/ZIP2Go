using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Accounting configuration if you have Zuora Revenue enabled.
    /// </summary>
    [DataContract]
    public class OrderLineItemRevenue
    {
        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "adjustment_revenue_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "adjustment_revenue_account")]
        public string AdjustmentRevenueAccount { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "contract_recognized_revenue_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contract_recognized_revenue_account")]
        public string ContractRecognizedRevenueAccount { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "deferred_revenue_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deferred_revenue_account")]
        public string DeferredRevenueAccount { get; set; }

        /// <summary>
        /// If set to `true`, any associated billing document items are excluded from the revenue accounting.
        /// </summary>
        /// <value>If set to `true`, any associated billing document items are excluded from the revenue accounting.</value>
        [DataMember(Name = "exclude_item_billing_from_revenue_accounting")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exclude_item_billing_from_revenue_accounting")]
        public bool? ExcludeItemBillingFromRevenueAccounting { get; set; }

        /// <summary>
        /// If set to `true`, any associated subscription items are excluded from the revenue accounting.
        /// </summary>
        /// <value>If set to `true`, any associated subscription items are excluded from the revenue accounting.</value>
        [DataMember(Name = "exclude_item_booking_from_revenue_accounting")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exclude_item_booking_from_revenue_accounting")]
        public bool? ExcludeItemBookingFromRevenueAccounting { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "recognized_revenue_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recognized_revenue_account")]
        public string RecognizedRevenueAccount { get; set; }

        /// <summary>
        /// The revenue recognition rule for the order line item.
        /// </summary>
        /// <value>The revenue recognition rule for the order line item.</value>
        [DataMember(Name = "revenue_recognition_rule_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revenue_recognition_rule_name")]
        public string RevenueRecognitionRuleName { get; set; }

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
            sb.Append("class OrderLineItemRevenue {\n");
            sb.Append("  ExcludeItemBillingFromRevenueAccounting: ").Append(ExcludeItemBillingFromRevenueAccounting).Append("\n");
            sb.Append("  ExcludeItemBookingFromRevenueAccounting: ").Append(ExcludeItemBookingFromRevenueAccounting).Append("\n");
            sb.Append("  AdjustmentRevenueAccount: ").Append(AdjustmentRevenueAccount).Append("\n");
            sb.Append("  ContractRecognizedRevenueAccount: ").Append(ContractRecognizedRevenueAccount).Append("\n");
            sb.Append("  DeferredRevenueAccount: ").Append(DeferredRevenueAccount).Append("\n");
            sb.Append("  RecognizedRevenueAccount: ").Append(RecognizedRevenueAccount).Append("\n");
            sb.Append("  RevenueRecognitionRuleName: ").Append(RevenueRecognitionRuleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}