using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GenerateBillingDocumentsAccountResponse
    {
        /// <summary>
        /// Array of credit memos.
        /// </summary>
        /// <value>Array of credit memos.</value>
        [DataMember(Name = "credit_memos")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memos")]
        public AllOfgenerateBillingDocumentsAccountResponseCreditMemos CreditMemos { get; set; }

        /// <summary>
        /// Array of invoices.
        /// </summary>
        /// <value>Array of invoices.</value>
        [DataMember(Name = "invoices")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoices")]
        public AllOfgenerateBillingDocumentsAccountResponseInvoices Invoices { get; set; }

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
            sb.Append("class GenerateBillingDocumentsAccountResponse {\n");
            sb.Append("  CreditMemos: ").Append(CreditMemos).Append("\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}