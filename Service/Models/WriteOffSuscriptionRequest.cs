using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// The financial information of the credit memo items generated to write off the invoice balance.
    /// </summary>
    [DataContract]
    public class WriteOffSuscriptionRequest
    {
        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "deferred_revenue_accounting_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deferred_revenue_accounting_code")]
        public string DeferredRevenueAccountingCode { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "on_account_accounting_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "on_account_accounting_code")]
        public string OnAccountAccountingCode { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name = "recognized_revenue_accounting_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recognized_revenue_accounting_code")]
        public string RecognizedRevenueAccountingCode { get; set; }

        /// <summary>
        /// Name of the revenue recognition rule that you want to apply.
        /// </summary>
        /// <value>Name of the revenue recognition rule that you want to apply.</value>
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
            sb.Append("class WriteOffSuscriptionRequest {\n");
            sb.Append("  OnAccountAccountingCode: ").Append(OnAccountAccountingCode).Append("\n");
            sb.Append("  DeferredRevenueAccountingCode: ").Append(DeferredRevenueAccountingCode).Append("\n");
            sb.Append("  RecognizedRevenueAccountingCode: ").Append(RecognizedRevenueAccountingCode).Append("\n");
            sb.Append("  RevenueRecognitionRuleName: ").Append(RevenueRecognitionRuleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}