using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class TaxationItemCreateRequest
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
        /// Unique identifier of the invoice item to which the taxation item applies. **This field is required if you are creating a credit memo or debit memo from an invoice, and is not applicable if you are creating an invoice.**.
        /// </summary>
        /// <value>Unique identifier of the invoice item to which the taxation item applies. **This field is required if you are creating a credit memo or debit memo from an invoice, and is not applicable if you are creating an invoice.**.     </value>
        [DataMember(Name = "invoice_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_item_id")]
        public string InvoiceItemId { get; set; }

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
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "on_account_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "on_account_account")]
        public string OnAccountAccount { get; set; }

        /// <summary>
        /// The ID of the taxation item of the invoice, from which the credit or debit memo is created. This field is only applicable when the `type` of the billing document is `credit_memo` and `debit_memo`.
        /// </summary>
        /// <value>The ID of the taxation item of the invoice, from which the credit or debit memo is created. This field is only applicable when the `type` of the billing document is `credit_memo` and `debit_memo`.</value>
        [DataMember(Name = "source_tax_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source_tax_item_id")]
        public string SourceTaxItemId { get; set; }

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
        /// The date on which the tax is applied.
        /// </summary>
        /// <value>The date on which the tax is applied.</value>
        [DataMember(Name = "tax_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_date")]
        public DateTime? TaxDate { get; set; }

        /// <summary>
        /// If set to `true`, it indicates that amounts are inclusive of tax.
        /// </summary>
        /// <value>If set to `true`, it indicates that amounts are inclusive of tax.</value>
        [DataMember(Name = "tax_inclusive")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_inclusive")]
        public bool? TaxInclusive { get; set; }

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
            sb.Append("class TaxationItemCreateRequest {\n");
            sb.Append("  OnAccountAccount: ").Append(OnAccountAccount).Append("\n");
            sb.Append("  AmountExempt: ").Append(AmountExempt).Append("\n");
            sb.Append("  InvoiceItemId: ").Append(InvoiceItemId).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  LocationCode: ").Append(LocationCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  TaxCodeName: ").Append(TaxCodeName).Append("\n");
            sb.Append("  TaxDate: ").Append(TaxDate).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxRateName: ").Append(TaxRateName).Append("\n");
            sb.Append("  TaxRateType: ").Append(TaxRateType).Append("\n");
            sb.Append("  SourceTaxItemId: ").Append(SourceTaxItemId).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}