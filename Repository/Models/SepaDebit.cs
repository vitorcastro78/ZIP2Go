using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// If the &#x60;type&#x60; of the payment method is &#x60;sepa_debit&#x60;, this hash contains details about the SEPA bank account.
    /// </summary>
    [DataContract]
    public class SepaDebit
    {
        /// <summary>
        /// The BIC code used with the Sepa Debit payment method.
        /// </summary>
        /// <value>The BIC code used with the Sepa Debit payment method.</value>
        [DataMember(Name = "business_identification_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "business_identification_code")]
        public string BusinessIdentificationCode { get; set; }

        /// <summary>
        /// International Bank Account Number used to create the SEPA Debit payment method.
        /// </summary>
        /// <value>International Bank Account Number used to create the SEPA Debit payment method.</value>
        [DataMember(Name = "IBAN")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "IBAN")]
        public string IBAN { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name = "mandate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mandate")]
        public Mandate Mandate { get; set; }

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
            sb.Append("class SepaDebit {\n");
            sb.Append("  IBAN: ").Append(IBAN).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("  BusinessIdentificationCode: ").Append(BusinessIdentificationCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}