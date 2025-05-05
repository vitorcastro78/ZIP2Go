using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Account data that is used for the subscription preview. If you specify this field, do not specify &#x60;account_id&#x60;. Note that this operation is only for preview and no subscription is created.
    /// </summary>
    [DataContract]
    public class SubscriptionPreviewAccountRequest
    {
        /// <summary>
        /// The day of the month on which your customer will be invoiced. For month-end specify 31.
        /// </summary>
        /// <value>The day of the month on which your customer will be invoiced. For month-end specify 31.</value>
        [DataMember(Name = "bill_cycle_day")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bill_cycle_day")]
        public int? BillCycleDay { get; set; }

        /// <summary>
        /// Three-letter ISO currency code. Once the currency is set for an account, it cannot be updated.
        /// </summary>
        /// <value>Three-letter ISO currency code. Once the currency is set for an account, it cannot be updated.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Customer address used for calculating tax.
        /// </summary>
        /// <value>Customer address used for calculating tax.</value>
        [DataMember(Name = "sold_to")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sold_to")]
        public AllOfsubscriptionPreviewAccountRequestSoldTo SoldTo { get; set; }

        /// <summary>
        /// Gets or Sets TaxCertificate
        /// </summary>
        [DataMember(Name = "tax_certificate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_certificate")]
        public TaxCertificate TaxCertificate { get; set; }

        /// <summary>
        /// Gets or Sets TaxIdentifier
        /// </summary>
        [DataMember(Name = "tax_identifier")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_identifier")]
        public TaxIdentifier TaxIdentifier { get; set; }

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
            sb.Append("class SubscriptionPreviewAccountRequest {\n");
            sb.Append("  SoldTo: ").Append(SoldTo).Append("\n");
            sb.Append("  TaxCertificate: ").Append(TaxCertificate).Append("\n");
            sb.Append("  BillCycleDay: ").Append(BillCycleDay).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TaxIdentifier: ").Append(TaxIdentifier).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}