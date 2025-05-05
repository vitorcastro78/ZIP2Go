using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// taxation information for this billing document item.
    /// </summary>
    [DataContract]
    public class TaxationItem
    {
        /// <summary>
        /// The amount of the tax applied to the total price.
        /// </summary>
        /// <value>The amount of the tax applied to the total price.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The credit memo item amount applied to the taxation item.
        /// </summary>
        /// <value>The credit memo item amount applied to the taxation item.</value>
        [DataMember(Name = "amount_applied")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_applied")]
        public decimal? AmountApplied { get; set; }

        /// <summary>
        /// The credit memo amount applied to the taxation item.
        /// </summary>
        /// <value>The credit memo amount applied to the taxation item.</value>
        [DataMember(Name = "amount_credited")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_credited")]
        public decimal? AmountCredited { get; set; }

        /// <summary>
        /// The calculated tax amount excluded due to the exemption.
        /// </summary>
        /// <value>The calculated tax amount excluded due to the exemption.</value>
        [DataMember(Name = "amount_exempt")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_exempt")]
        public decimal? AmountExempt { get; set; }

        /// <summary>
        /// The payment amount applied to the taxation item.
        /// </summary>
        /// <value>The payment amount applied to the taxation item.</value>
        [DataMember(Name = "amount_paid")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_paid")]
        public decimal? AmountPaid { get; set; }

        /// <summary>
        /// The refund amount applied to the taxation item.
        /// </summary>
        /// <value>The refund amount applied to the taxation item.</value>
        [DataMember(Name = "amount_refunded")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount_refunded")]
        public decimal? AmountRefunded { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public string CreatedById { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public CustomObject CustomObjects { get; set; }

        /// <summary>
        /// Identifier of the taxation item related to the invoice. Only applicable for credit memos created from invoices.
        /// </summary>
        /// <value>Identifier of the taxation item related to the invoice. Only applicable for credit memos created from invoices.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

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
        /// The remaining balance of the taxation item.
        /// </summary>
        /// <value>The remaining balance of the taxation item.</value>
        [DataMember(Name = "remaining_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_balance")]
        public decimal? RemainingBalance { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "sales_tax_payable_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sales_tax_payable_account")]
        public string SalesTaxPayableAccount { get; set; }

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
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public string UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

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
            sb.Append("class TaxationItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  LocationCode: ").Append(LocationCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  TaxCodeName: ").Append(TaxCodeName).Append("\n");
            sb.Append("  TaxDate: ").Append(TaxDate).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxRateName: ").Append(TaxRateName).Append("\n");
            sb.Append("  AmountExempt: ").Append(AmountExempt).Append("\n");
            sb.Append("  SourceTaxItemId: ").Append(SourceTaxItemId).Append("\n");
            sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
            sb.Append("  AmountCredited: ").Append(AmountCredited).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  AmountRefunded: ").Append(AmountRefunded).Append("\n");
            sb.Append("  AmountApplied: ").Append(AmountApplied).Append("\n");
            sb.Append("  SalesTaxPayableAccount: ").Append(SalesTaxPayableAccount).Append("\n");
            sb.Append("  OnAccountAccount: ").Append(OnAccountAccount).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  TaxRateType: ").Append(TaxRateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}