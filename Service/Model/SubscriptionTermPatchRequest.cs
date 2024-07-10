using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Term information of the subscription.
  /// </summary>
  [DataContract]
  public class SubscriptionTermPatchRequest {
    /// <summary>
    /// Current term information for the subscription.
    /// </summary>
    /// <value>Current term information for the subscription.</value>
    [DataMember(Name="current_term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_term")]
    public AllOfsubscriptionTermPatchRequestCurrentTerm CurrentTerm { get; set; }

    /// <summary>
    /// Renewal term information for the subscription.
    /// </summary>
    /// <value>Renewal term information for the subscription.</value>
    [DataMember(Name="renewal_term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewal_term")]
    public AllOfsubscriptionTermPatchRequestRenewalTerm RenewalTerm { get; set; }

    /// <summary>
    /// If true, the subscription automatically renews at the end of the current term.
    /// </summary>
    /// <value>If true, the subscription automatically renews at the end of the current term.</value>
    [DataMember(Name="auto_renew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_renew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// Gets or Sets StartOn
    /// </summary>
    [DataMember(Name="start_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_on")]
    public StartOn StartOn { get; set; }

    /// <summary>
    /// ID of the bill-to contact.
    /// </summary>
    /// <value>ID of the bill-to contact.</value>
    [DataMember(Name="bill_to_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bill_to_id")]
    public string BillToId { get; set; }

    /// <summary>
    /// The name of payment term associated with the invoice.
    /// </summary>
    /// <value>The name of payment term associated with the invoice.</value>
    [DataMember(Name="payment_terms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_terms")]
    public string PaymentTerms { get; set; }

    /// <summary>
    /// The billing document settings for the customer.
    /// </summary>
    /// <value>The billing document settings for the customer.</value>
    [DataMember(Name="billing_document_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_document_settings")]
    public AllOfsubscriptionTermPatchRequestBillingDocumentSettings BillingDocumentSettings { get; set; }

    /// <summary>
    /// ID of the sold-to contact.
    /// </summary>
    /// <value>ID of the sold-to contact.</value>
    [DataMember(Name="sold_to_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sold_to_id")]
    public string SoldToId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionTermPatchRequest {\n");
      sb.Append("  CurrentTerm: ").Append(CurrentTerm).Append("\n");
      sb.Append("  RenewalTerm: ").Append(RenewalTerm).Append("\n");
      sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
      sb.Append("  StartOn: ").Append(StartOn).Append("\n");
      sb.Append("  BillToId: ").Append(BillToId).Append("\n");
      sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
      sb.Append("  BillingDocumentSettings: ").Append(BillingDocumentSettings).Append("\n");
      sb.Append("  SoldToId: ").Append(SoldToId).Append("\n");
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
