using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InvoiceCreateRequest {
    /// <summary>
    /// Identifier of the account that owns the invoice.
    /// </summary>
    /// <value>Identifier of the account that owns the invoice.</value>
    [DataMember(Name="account_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_id")]
    public string AccountId { get; set; }

    /// <summary>
    /// Human-readable identifier of the account that owns the invoice.
    /// </summary>
    /// <value>Human-readable identifier of the account that owns the invoice.</value>
    [DataMember(Name="account_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account_number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// An arbitrary string associated with the object. Often useful for displaying to users.
    /// </summary>
    /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The date on which payment for the invoice is due.
    /// </summary>
    /// <value>The date on which payment for the invoice is due.</value>
    [DataMember(Name="due_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "due_date")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// The date when the invoice takes effect.
    /// </summary>
    /// <value>The date when the invoice takes effect.</value>
    [DataMember(Name="document_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document_date")]
    public DateTime? DocumentDate { get; set; }

    /// <summary>
    /// Whether to transfer to an external accounting system.
    /// </summary>
    /// <value>Whether to transfer to an external accounting system.</value>
    [DataMember(Name="transfer_to_accounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transfer_to_accounting")]
    public bool? TransferToAccounting { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public CustomFields CustomFields { get; set; }

    /// <summary>
    /// Indicates whether the invoice is automatically picked up for processing in the corresponding payment run.
    /// </summary>
    /// <value>Indicates whether the invoice is automatically picked up for processing in the corresponding payment run.</value>
    [DataMember(Name="pay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pay")]
    public bool? Pay { get; set; }

    /// <summary>
    /// 3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.
    /// </summary>
    /// <value>3-letter ISO 4217 currency code. This field is available only if you have the [Multiple Currencies](https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Flexible_Billing/Multiple_Currencies) feature enabled.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Information of all invoice items.
    /// </summary>
    /// <value>Information of all invoice items.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<InvoiceItemCreateRequest> Items { get; set; }

    /// <summary>
    /// Whether to automatically post an invoice after it is created.
    /// </summary>
    /// <value>Whether to automatically post an invoice after it is created.</value>
    [DataMember(Name="post", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "post")]
    public bool? Post { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceCreateRequest {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
      sb.Append("  TransferToAccounting: ").Append(TransferToAccounting).Append("\n");
      sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
      sb.Append("  Pay: ").Append(Pay).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Post: ").Append(Post).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
