using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// The tax certificate information.
    /// </summary>
    [DataContract]
    public class TaxCertificate
    {
        /// <summary>
        /// Unique code that identifies a company account in Avalara. Use this field to calculate taxes based on country of origin and sold-to addresses in Avalara.
        /// </summary>
        /// <value>Unique code that identifies a company account in Avalara. Use this field to calculate taxes based on country of origin and sold-to addresses in Avalara.</value>
        [DataMember(Name = "company_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// Description of the tax exemption certificate.
        /// </summary>
        /// <value>Description of the tax exemption certificate.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The tax certificate end date.
        /// </summary>
        /// <value>The tax certificate end date.</value>
        [DataMember(Name = "end_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// A unique entity use code used by Avalara to apply exemptions. This field is required only when you choose Avalara as your tax engine. See [Exempt Transactions](https://developer.avalara.com/avatax/handling-tax-exempt-customers/) for more information.
        /// </summary>
        /// <value>A unique entity use code used by Avalara to apply exemptions. This field is required only when you choose Avalara as your tax engine. See [Exempt Transactions](https://developer.avalara.com/avatax/handling-tax-exempt-customers/) for more information.</value>
        [DataMember(Name = "entity_use_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "entity_use_code")]
        public string EntityUseCode { get; set; }

        /// <summary>
        /// Identifier of the tax exemption certificate.
        /// </summary>
        /// <value>Identifier of the tax exemption certificate.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Typically, this is a state or government agency
        /// </summary>
        /// <value>Typically, this is a state or government agency</value>
        [DataMember(Name = "issuing_jurisdiction")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuing_jurisdiction")]
        public string IssuingJurisdiction { get; set; }

        /// <summary>
        /// The tax certificate start date.
        /// </summary>
        /// <value>The tax certificate start date.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Status of the tax exemption certificate, indication whether the certificate has been verified.
        /// </summary>
        /// <value>Status of the tax exemption certificate, indication whether the certificate has been verified.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Value Added Tax (VAT) ID. Each VAT ID must begin with the code of the country code and followed by a block of digits or characters.
        /// </summary>
        /// <value>Value Added Tax (VAT) ID. Each VAT ID must begin with the code of the country code and followed by a block of digits or characters.</value>
        [DataMember(Name = "tax_identifier")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_identifier")]
        public string TaxIdentifier { get; set; }

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
            sb.Append("class TaxCertificate {\n");
            sb.Append("  CompanyCode: ").Append(CompanyCode).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EntityUseCode: ").Append(EntityUseCode).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  IssuingJurisdiction: ").Append(IssuingJurisdiction).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaxIdentifier: ").Append(TaxIdentifier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}