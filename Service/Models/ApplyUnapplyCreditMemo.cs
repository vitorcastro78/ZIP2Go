using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ApplyUnapplyCreditMemo
    {
        /// <summary>
        /// Array of billing documents to apply this credit memo to.
        /// </summary>
        /// <value>Array of billing documents to apply this credit memo to.</value>
        [DataMember(Name = "billing_documents")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_documents")]
        public List<CreditMemoApplicationRequest> BillingDocuments { get; set; }

        /// <summary>
        /// The date when the credit memo is applied
        /// </summary>
        /// <value>The date when the credit memo is applied</value>
        [DataMember(Name = "effective_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "effective_date")]
        public DateTime? EffectiveDate { get; set; }

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
            sb.Append("class ApplyUnapplyCreditMemo {\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  BillingDocuments: ").Append(BillingDocuments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}