using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WriteOffItemsRequest {
    /// <summary>
    /// An arbitrary string associated with the object. Often useful for displaying to users.
    /// </summary>
    /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// An active account in your Zuora Chart of Accounts.
    /// </summary>
    /// <value>An active account in your Zuora Chart of Accounts.</value>
    [DataMember(Name="deferred_revenue_account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deferred_revenue_account")]
    public string DeferredRevenueAccount { get; set; }

    /// <summary>
    /// An active account in your Zuora Chart of Accounts.
    /// </summary>
    /// <value>An active account in your Zuora Chart of Accounts.</value>
    [DataMember(Name="on_account_account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on_account_account")]
    public string OnAccountAccount { get; set; }

    /// <summary>
    /// An active account in your Zuora Chart of Accounts.
    /// </summary>
    /// <value>An active account in your Zuora Chart of Accounts.</value>
    [DataMember(Name="recognized_revenue_account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognized_revenue_account")]
    public string RecognizedRevenueAccount { get; set; }

    /// <summary>
    /// The name of the revenue recognition rule governing the revenue schedule.
    /// </summary>
    /// <value>The name of the revenue recognition rule governing the revenue schedule.</value>
    [DataMember(Name="revenue_recognition_rule_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenue_recognition_rule_name")]
    public string RevenueRecognitionRuleName { get; set; }

    /// <summary>
    /// The end date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.
    /// </summary>
    /// <value>The end date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.</value>
    [DataMember(Name="service_end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_end")]
    public DateTime? ServiceEnd { get; set; }

    /// <summary>
    /// The start date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.
    /// </summary>
    /// <value>The start date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.</value>
    [DataMember(Name="service_start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_start")]
    public DateTime? ServiceStart { get; set; }

    /// <summary>
    /// The unique SKU (stock keeping unit) of the product associated with this item.
    /// </summary>
    /// <value>The unique SKU (stock keeping unit) of the product associated with this item.</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Specifies the units used to measure usage.
    /// </summary>
    /// <value>Specifies the units used to measure usage.</value>
    [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_of_measure")]
    public string UnitOfMeasure { get; set; }

    /// <summary>
    /// The unique identifier of the invoice item.
    /// </summary>
    /// <value>The unique identifier of the invoice item.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public CustomFields CustomFields { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WriteOffItemsRequest {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DeferredRevenueAccount: ").Append(DeferredRevenueAccount).Append("\n");
      sb.Append("  OnAccountAccount: ").Append(OnAccountAccount).Append("\n");
      sb.Append("  RecognizedRevenueAccount: ").Append(RecognizedRevenueAccount).Append("\n");
      sb.Append("  RevenueRecognitionRuleName: ").Append(RevenueRecognitionRuleName).Append("\n");
      sb.Append("  ServiceEnd: ").Append(ServiceEnd).Append("\n");
      sb.Append("  ServiceStart: ").Append(ServiceStart).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
