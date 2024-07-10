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
  public class BillingDocumentItem {
    /// <summary>
    /// Unique identifier for the object.
    /// </summary>
    /// <value>Unique identifier for the object.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Unique identifier of the Zuora user who last updated the object
    /// </summary>
    /// <value>Unique identifier of the Zuora user who last updated the object</value>
    [DataMember(Name="updated_by_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_by_id")]
    public string UpdatedById { get; set; }

    /// <summary>
    /// The date and time when the object was last updated in ISO 8601 UTC format.
    /// </summary>
    /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
    [DataMember(Name="updated_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_time")]
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// Unique identifier of the Zuora user who created the object
    /// </summary>
    /// <value>Unique identifier of the Zuora user who created the object</value>
    [DataMember(Name="created_by_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_by_id")]
    public string CreatedById { get; set; }

    /// <summary>
    /// The date and time when the object was created in ISO 8601 UTC format.
    /// </summary>
    /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
    [DataMember(Name="created_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_time")]
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
    /// </summary>
    /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
    [DataMember(Name="custom_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_fields")]
    public Dictionary<string, Object> CustomFields { get; set; }

    /// <summary>
    /// The custom objects associated with a Zuora standard object.
    /// </summary>
    /// <value>The custom objects associated with a Zuora standard object.</value>
    [DataMember(Name="custom_objects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_objects")]
    public OneOfbillingDocumentItemCustomObjects CustomObjects { get; set; }

    /// <summary>
    /// The total amount of this billing document item.
    /// </summary>
    /// <value>The total amount of this billing document item.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// The total amount of this billing document item exclusive of tax.
    /// </summary>
    /// <value>The total amount of this billing document item exclusive of tax.</value>
    [DataMember(Name="subtotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtotal")]
    public decimal? Subtotal { get; set; }

    /// <summary>
    /// An arbitrary string associated with the object. Often useful for displaying to users.
    /// </summary>
    /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The accounting code for the deferred revenue, such as Monthly Recurring Liability.
    /// </summary>
    /// <value>The accounting code for the deferred revenue, such as Monthly Recurring Liability.</value>
    [DataMember(Name="deferred_revenue_account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deferred_revenue_account")]
    public string DeferredRevenueAccount { get; set; }

    /// <summary>
    /// The accounting code that maps to an on account in your accounting system.
    /// </summary>
    /// <value>The accounting code that maps to an on account in your accounting system.</value>
    [DataMember(Name="on_account_account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on_account_account")]
    public string OnAccountAccount { get; set; }

    /// <summary>
    /// The accounting code for the recognized revenue, such as Monthly Recurring Charges or Overage Charges.
    /// </summary>
    /// <value>The accounting code for the recognized revenue, such as Monthly Recurring Charges or Overage Charges.</value>
    [DataMember(Name="recognized_revenue_account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recognized_revenue_account")]
    public string RecognizedRevenueAccount { get; set; }

    /// <summary>
    /// The related billing document.
    /// </summary>
    /// <value>The related billing document.</value>
    [DataMember(Name="billing_document", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_document")]
    public AllOfbillingDocumentItemBillingDocument BillingDocument { get; set; }

    /// <summary>
    /// The related billing document id.
    /// </summary>
    /// <value>The related billing document id.</value>
    [DataMember(Name="billing_document_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_document_id")]
    public string BillingDocumentId { get; set; }

    /// <summary>
    /// The name of the revenue recognition rule governing the revenue schedule.
    /// </summary>
    /// <value>The name of the revenue recognition rule governing the revenue schedule.</value>
    [DataMember(Name="revenue_recognition_rule_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revenue_recognition_rule_name")]
    public string RevenueRecognitionRuleName { get; set; }

    /// <summary>
    /// The number of units of this item.
    /// </summary>
    /// <value>The number of units of this item.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// The end date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.
    /// </summary>
    /// <value>The end date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
    [DataMember(Name="service_end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_end")]
    public string ServiceEnd { get; set; }

    /// <summary>
    /// An active account in your Zuora Chart of Accounts.
    /// </summary>
    /// <value>An active account in your Zuora Chart of Accounts.</value>
    [DataMember(Name="accounts_receivable_account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accounts_receivable_account")]
    public string AccountsReceivableAccount { get; set; }

    /// <summary>
    /// If true, indicates that the item is a discount item.
    /// </summary>
    /// <value>If true, indicates that the item is a discount item.</value>
    [DataMember(Name="discount_item", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount_item")]
    public bool? DiscountItem { get; set; }

    /// <summary>
    /// Identifier of an invoice item or a debit memo item that this discount item or credit memo item is applied to.
    /// </summary>
    /// <value>Identifier of an invoice item or a debit memo item that this discount item or credit memo item is applied to.</value>
    [DataMember(Name="applied_to_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applied_to_item_id")]
    public string AppliedToItemId { get; set; }

    /// <summary>
    /// The start date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.
    /// </summary>
    /// <value>The start date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
    [DataMember(Name="service_start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_start")]
    public string ServiceStart { get; set; }

    /// <summary>
    /// Gets or Sets AccountingCode
    /// </summary>
    [DataMember(Name="accounting_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accounting_code")]
    public string AccountingCode { get; set; }

    /// <summary>
    /// The unique SKU (stock keeping unit) of the product associated with this item.
    /// </summary>
    /// <value>The unique SKU (stock keeping unit) of the product associated with this item.</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// The name of the product associated with this item.
    /// </summary>
    /// <value>The name of the product associated with this item.</value>
    [DataMember(Name="product_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_name")]
    public string ProductName { get; set; }

    /// <summary>
    /// The identifier of the subscription associated with the billing document item.
    /// </summary>
    /// <value>The identifier of the subscription associated with the billing document item.</value>
    [DataMember(Name="subscription_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_id")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// The expandable subscription associated with the billing document item.
    /// </summary>
    /// <value>The expandable subscription associated with the billing document item.</value>
    [DataMember(Name="subscription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription")]
    public AllOfbillingDocumentItemSubscription Subscription { get; set; }

    /// <summary>
    /// This specifies if the billing document item amount is inclusive or exclusive of tax.
    /// </summary>
    /// <value>This specifies if the billing document item amount is inclusive or exclusive of tax.</value>
    [DataMember(Name="tax_inclusive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_inclusive")]
    public bool? TaxInclusive { get; set; }

    /// <summary>
    /// The remaining balance of this billing document item.
    /// </summary>
    /// <value>The remaining balance of this billing document item.</value>
    [DataMember(Name="remaining_balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remaining_balance")]
    public decimal? RemainingBalance { get; set; }

    /// <summary>
    /// Specifies the units used to measure usage.
    /// </summary>
    /// <value>Specifies the units used to measure usage.</value>
    [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_of_measure")]
    public string UnitOfMeasure { get; set; }

    /// <summary>
    /// Unit amount (in the currency specified) of the billing document item.
    /// </summary>
    /// <value>Unit amount (in the currency specified) of the billing document item.</value>
    [DataMember(Name="unit_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_amount")]
    public decimal? UnitAmount { get; set; }

    /// <summary>
    /// The booking reference for this billing document item.
    /// </summary>
    /// <value>The booking reference for this billing document item.</value>
    [DataMember(Name="booking_reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_reference")]
    public string BookingReference { get; set; }

    /// <summary>
    /// The description of the price this billing document item is associated with.
    /// </summary>
    /// <value>The description of the price this billing document item is associated with.</value>
    [DataMember(Name="price_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_description")]
    public string PriceDescription { get; set; }

    /// <summary>
    /// Name of the billing document item displayed to customers on the billing document.
    /// </summary>
    /// <value>Name of the billing document item displayed to customers on the billing document.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The identifier of the price this billing document item is associated with.
    /// </summary>
    /// <value>The identifier of the price this billing document item is associated with.</value>
    [DataMember(Name="price_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_id")]
    public string PriceId { get; set; }

    /// <summary>
    /// The purchase order number associated with this billing document item.
    /// </summary>
    /// <value>The purchase order number associated with this billing document item.</value>
    [DataMember(Name="purchase_order_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchase_order_number")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// The amount of tax applied to the billing document item.
    /// </summary>
    /// <value>The amount of tax applied to the billing document item.</value>
    [DataMember(Name="tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax")]
    public decimal? Tax { get; set; }

    /// <summary>
    /// The designated tax code.
    /// </summary>
    /// <value>The designated tax code.</value>
    [DataMember(Name="tax_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_code")]
    public string TaxCode { get; set; }

    /// <summary>
    /// The identifier the subscription item associated with this billing document item.
    /// </summary>
    /// <value>The identifier the subscription item associated with this billing document item.</value>
    [DataMember(Name="subscription_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_item_id")]
    public string SubscriptionItemId { get; set; }

    /// <summary>
    /// The expandable subscription item associated with this billing document item.
    /// </summary>
    /// <value>The expandable subscription item associated with this billing document item.</value>
    [DataMember(Name="subscription_item", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_item")]
    public AllOfbillingDocumentItemSubscriptionItem SubscriptionItem { get; set; }

    /// <summary>
    /// The identifier of the invoice item associated with this billing document item.
    /// </summary>
    /// <value>The identifier of the invoice item associated with this billing document item.</value>
    [DataMember(Name="invoice_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_item_id")]
    public string InvoiceItemId { get; set; }

    /// <summary>
    /// The date when the billing document item takes effect.
    /// </summary>
    /// <value>The date when the billing document item takes effect.</value>
    [DataMember(Name="document_item_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document_item_date")]
    public DateTime? DocumentItemDate { get; set; }

    /// <summary>
    /// List of taxation items.
    /// </summary>
    /// <value>List of taxation items.</value>
    [DataMember(Name="taxation_items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxation_items")]
    public AllOfbillingDocumentItemTaxationItems TaxationItems { get; set; }

    /// <summary>
    /// The type of billing document, one of credit_memo, debit_memo or invoice.
    /// </summary>
    /// <value>The type of billing document, one of credit_memo, debit_memo or invoice.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingDocumentItem {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
      sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
      sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
      sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
      sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
      sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DeferredRevenueAccount: ").Append(DeferredRevenueAccount).Append("\n");
      sb.Append("  OnAccountAccount: ").Append(OnAccountAccount).Append("\n");
      sb.Append("  RecognizedRevenueAccount: ").Append(RecognizedRevenueAccount).Append("\n");
      sb.Append("  BillingDocument: ").Append(BillingDocument).Append("\n");
      sb.Append("  BillingDocumentId: ").Append(BillingDocumentId).Append("\n");
      sb.Append("  RevenueRecognitionRuleName: ").Append(RevenueRecognitionRuleName).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  ServiceEnd: ").Append(ServiceEnd).Append("\n");
      sb.Append("  AccountsReceivableAccount: ").Append(AccountsReceivableAccount).Append("\n");
      sb.Append("  DiscountItem: ").Append(DiscountItem).Append("\n");
      sb.Append("  AppliedToItemId: ").Append(AppliedToItemId).Append("\n");
      sb.Append("  ServiceStart: ").Append(ServiceStart).Append("\n");
      sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  Subscription: ").Append(Subscription).Append("\n");
      sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
      sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
      sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
      sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
      sb.Append("  BookingReference: ").Append(BookingReference).Append("\n");
      sb.Append("  PriceDescription: ").Append(PriceDescription).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PriceId: ").Append(PriceId).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  Tax: ").Append(Tax).Append("\n");
      sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
      sb.Append("  SubscriptionItemId: ").Append(SubscriptionItemId).Append("\n");
      sb.Append("  SubscriptionItem: ").Append(SubscriptionItem).Append("\n");
      sb.Append("  InvoiceItemId: ").Append(InvoiceItemId).Append("\n");
      sb.Append("  DocumentItemDate: ").Append(DocumentItemDate).Append("\n");
      sb.Append("  TaxationItems: ").Append(TaxationItems).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
