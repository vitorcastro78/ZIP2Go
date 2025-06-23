using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionPreviewBillingDocumentTaxationItemResponse
    {
        /// <summary>
        /// The amount of the tax applied to the total price.
        /// </summary>
        /// <value>The amount of the tax applied to the total price.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The calculated tax amount excluded due to the exemption.
        /// </summary>
        /// <value>The calculated tax amount excluded due to the exemption.</value>
        [DataMember(Name = "amount_exempt")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_exempt")]
        public decimal? AmountExempt { get; set; }

        /// <summary>
        /// The date on which the tax is applied.
        /// </summary>
        /// <value>The date on which the tax is applied.</value>
        [DataMember(Name = "date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Identifier of the taxation item related to the invoice. Only applicable for credit memos created from invoices.
        /// </summary>
        /// <value>Identifier of the taxation item related to the invoice. Only applicable for credit memos created from invoices.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The jurisdiction that applies the tax or VAT. This value is typically a state, province, county, or city.
        /// </summary>
        /// <value>The jurisdiction that applies the tax or VAT. This value is typically a state, province, county, or city.</value>
        [DataMember(Name = "jurisdiction")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jurisdiction")]
        public string Jurisdiction { get; set; }

        /// <summary>
        /// The identifier for the location based on the value of the `tax_code` field.
        /// </summary>
        /// <value>The identifier for the location based on the value of the `tax_code` field.</value>
        [DataMember(Name = "location_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location_code")]
        public string LocationCode { get; set; }

        /// <summary>
        /// The name of the taxation item.
        /// </summary>
        /// <value>The name of the taxation item.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A tax code identifier. If a `tax_code` of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly.
        /// </summary>
        /// <value>A tax code identifier. If a `tax_code` of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly.</value>
        [DataMember(Name = "tax_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// The amount of the tax applied to the total price.
        /// </summary>
        /// <value>The amount of the tax applied to the total price.</value>
        [DataMember(Name = "tax_code_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_code_name")]
        public string TaxCodeName { get; set; }

        /// <summary>
        /// The amount of the tax applied to the total price.
        /// </summary>
        /// <value>The amount of the tax applied to the total price.</value>
        [DataMember(Name = "tax_rate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_rate")]
        public decimal? TaxRate { get; set; }

        /// <summary>
        /// The name of the tax rate, such as sales tax or GST. This name is displayed on billing documents.
        /// </summary>
        /// <value>The name of the tax rate, such as sales tax or GST. This name is displayed on billing documents.</value>
        [DataMember(Name = "tax_rate_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_rate_name")]
        public string TaxRateName { get; set; }

        /// <summary>
        /// Indicates whether the tax rate is an amount or a percentage.
        /// </summary>
        /// <value>Indicates whether the tax rate is an amount or a percentage.</value>
        [DataMember(Name = "tax_rate_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_rate_type")]
        public string TaxRateType { get; set; }

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
            sb.Append("class SubscriptionPreviewBillingDocumentTaxationItemResponse {\n");
            sb.Append("  AmountExempt: ").Append(AmountExempt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  LocationCode: ").Append(LocationCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  TaxCodeName: ").Append(TaxCodeName).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxRateName: ").Append(TaxRateName).Append("\n");
            sb.Append("  TaxRateType: ").Append(TaxRateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}