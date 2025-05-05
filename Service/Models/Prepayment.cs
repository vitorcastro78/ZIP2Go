using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Prepayment
    {
        /// <summary>
        /// The way to calculate credit. See <a href='https://knowledgecenter.zuora.com/Zuora_Billing/Billing_and_Invoicing/JA_Advanced_Consumption_Billing/Prepaid_with_Drawdown/A_Create_prepayment_charge#Credit_Option'  target='_blank'>Credit Option</a> for more information.
        /// </summary>
        /// <value>The way to calculate credit. See <a href='https://knowledgecenter.zuora.com/Zuora_Billing/Billing_and_Invoicing/JA_Advanced_Consumption_Billing/Prepaid_with_Drawdown/A_Create_prepayment_charge#Credit_Option'  target='_blank'>Credit Option</a> for more information.</value>
        [DataMember(Name = "credit_option")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_option")]
        public string CreditOption { get; set; }

        /// <summary>
        /// The number of units included in a prepayment charge.
        /// </summary>
        /// <value>The number of units included in a prepayment charge.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The total amount of units that end customers can use during a validity period when they subscribe to a prepayment charge.
        /// </summary>
        /// <value>The total amount of units that end customers can use during a validity period when they subscribe to a prepayment charge.</value>
        [DataMember(Name = "total_quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total_quantity")]
        public decimal? TotalQuantity { get; set; }

        /// <summary>
        /// A configured unit of measure. This field is required for per-unit prices.
        /// </summary>
        /// <value>A configured unit of measure. This field is required for per-unit prices.</value>
        [DataMember(Name = "unit_of_measure")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_of_measure")]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// The period in which the prepayment units are valid to use as defined in a prepayment charge.
        /// </summary>
        /// <value>The period in which the prepayment units are valid to use as defined in a prepayment charge.</value>
        [DataMember(Name = "validity_period")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "validity_period")]
        public string ValidityPeriod { get; set; }

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
            sb.Append("class Prepayment {\n");
            sb.Append("  CreditOption: ").Append(CreditOption).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  ValidityPeriod: ").Append(ValidityPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}