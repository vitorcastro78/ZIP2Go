using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class DebitMemoItem
    {
        /// <summary>
        /// Gets or Sets AccountingCode
        /// </summary>
        [DataMember(Name = "accounting_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accounting_code")]
        public string AccountingCode { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name = "accounts_receivable_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accounts_receivable_account")]
        public string AccountsReceivableAccount { get; set; }

        /// <summary>
        /// The total amount of this debit memo item.
        /// </summary>
        /// <value>The total amount of this debit memo item.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Identifier of an invoice item that this debit memo item is applied to.
        /// </summary>
        /// <value>Identifier of an invoice item that this debit memo item is applied to.</value>
        [DataMember(Name = "applied_to_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applied_to_item_id")]
        public string AppliedToItemId { get; set; }

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
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public OneOfdebitMemoItemCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// The related debit memo.
        /// </summary>
        /// <value>The related debit memo.</value>
        [DataMember(Name = "debit_memo")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "debit_memo")]
        public AllOfdebitMemoItemDebitMemo DebitMemo { get; set; }

        /// <summary>
        /// The related debit memo id.
        /// </summary>
        /// <value>The related debit memo id.</value>
        [DataMember(Name = "debit_memo_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "debit_memo_id")]
        public string DebitMemoId { get; set; }

        /// <summary>
        /// The accounting code for the deferred revenue, such as Monthly Recurring Liability.
        /// </summary>
        /// <value>The accounting code for the deferred revenue, such as Monthly Recurring Liability.</value>
        [DataMember(Name = "deferred_revenue_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deferred_revenue_account")]
        public string DeferredRevenueAccount { get; set; }

        /// <summary>
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// If true, indicates that the item is a discount item.
        /// </summary>
        /// <value>If true, indicates that the item is a discount item.</value>
        [DataMember(Name = "discount_item")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount_item")]
        public bool? DiscountItem { get; set; }

        /// <summary>
        /// The date when the debit memo item takes effect.
        /// </summary>
        /// <value>The date when the debit memo item takes effect.</value>
        [DataMember(Name = "document_item_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "document_item_date")]
        public DateTime? DocumentItemDate { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The identifier of the invoice item associated with this debit memo item.
        /// </summary>
        /// <value>The identifier of the invoice item associated with this debit memo item.</value>
        [DataMember(Name = "invoice_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_item_id")]
        public string InvoiceItemId { get; set; }

        /// <summary>
        /// Name of the billing document item displayed to customers on the billing document.
        /// </summary>
        /// <value>Name of the billing document item displayed to customers on the billing document.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The accounting code that maps to an on account in your accounting system.
        /// </summary>
        /// <value>The accounting code that maps to an on account in your accounting system.</value>
        [DataMember(Name = "on_account_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "on_account_account")]
        public string OnAccountAccount { get; set; }

        /// <summary>
        /// The identifier of the price this debit memo item is associated with.
        /// </summary>
        /// <value>The identifier of the price this debit memo item is associated with.</value>
        [DataMember(Name = "price_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// The purchase order number associated with this debit memo item.
        /// </summary>
        /// <value>The purchase order number associated with this debit memo item.</value>
        [DataMember(Name = "purchase_order_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchase_order_number")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name = "quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The accounting code for the recognized revenue, such as Monthly Recurring Charges or Overage Charges.
        /// </summary>
        /// <value>The accounting code for the recognized revenue, such as Monthly Recurring Charges or Overage Charges.</value>
        [DataMember(Name = "recognized_revenue_account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recognized_revenue_account")]
        public string RecognizedRevenueAccount { get; set; }

        /// <summary>
        /// The remaining balance of this debit memo item.
        /// </summary>
        /// <value>The remaining balance of this debit memo item.</value>
        [DataMember(Name = "remaining_balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_balance")]
        public decimal? RemainingBalance { get; set; }

        /// <summary>
        /// The name of the revenue recognition rule governing the revenue schedule.
        /// </summary>
        /// <value>The name of the revenue recognition rule governing the revenue schedule.</value>
        [DataMember(Name = "revenue_recognition_rule_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revenue_recognition_rule_name")]
        public string RevenueRecognitionRuleName { get; set; }

        /// <summary>
        /// The end date of the service period associated with this debit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The end date of the service period associated with this debit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name = "service_end")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_end")]
        public string ServiceEnd { get; set; }

        /// <summary>
        /// The start date of the service period associated with this debit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The start date of the service period associated with this debit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name = "service_start")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_start")]
        public string ServiceStart { get; set; }

        /// <summary>
        /// The unique SKU (stock keeping unit) of the product associated with this item.
        /// </summary>
        /// <value>The unique SKU (stock keeping unit) of the product associated with this item.</value>
        [DataMember(Name = "sku")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// List of customer subscriptions.
        /// </summary>
        /// <value>List of customer subscriptions.</value>
        [DataMember(Name = "subscription")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription")]
        public AllOfdebitMemoItemSubscription Subscription { get; set; }

        /// <summary>
        /// The identifier of the subscription associated with the debit memo item.
        /// </summary>
        /// <value>The identifier of the subscription associated with the debit memo item.</value>
        [DataMember(Name = "subscription_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The expandable subscription item associated with this billing document item.
        /// </summary>
        /// <value>The expandable subscription item associated with this billing document item.</value>
        [DataMember(Name = "subscription_item")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item")]
        public AllOfdebitMemoItemSubscriptionItem SubscriptionItem { get; set; }

        /// <summary>
        /// The identifier the subscription item associated with this debit memo item.
        /// </summary>
        /// <value>The identifier the subscription item associated with this debit memo item.</value>
        [DataMember(Name = "subscription_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_item_id")]
        public string SubscriptionItemId { get; set; }

        /// <summary>
        /// The total amount of this debit memo item exclusive of tax.
        /// </summary>
        /// <value>The total amount of this debit memo item exclusive of tax.</value>
        [DataMember(Name = "subtotal")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// The amount of tax applied to the debit memo item.
        /// </summary>
        /// <value>The amount of tax applied to the debit memo item.</value>
        [DataMember(Name = "tax")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax")]
        public decimal? Tax { get; set; }

        /// <summary>
        /// Gets or Sets TaxationItems
        /// </summary>
        [DataMember(Name = "taxation_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxation_items")]
        public TaxationItemListResponse TaxationItems { get; set; }

        /// <summary>
        /// The designated tax code.
        /// </summary>
        /// <value>The designated tax code.</value>
        [DataMember(Name = "tax_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// This specifies if the debit memo item amount is inclusive or exclusive of tax.
        /// </summary>
        /// <value>This specifies if the debit memo item amount is inclusive or exclusive of tax.</value>
        [DataMember(Name = "tax_inclusive")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_inclusive")]
        public bool? TaxInclusive { get; set; }

        /// <summary>
        /// Unit amount of the debit memo item.
        /// </summary>
        /// <value>Unit amount of the debit memo item.</value>
        [DataMember(Name = "unit_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_amount")]
        public decimal? UnitAmount { get; set; }

        /// <summary>
        /// Specifies the units used to measure usage.
        /// </summary>
        /// <value>Specifies the units used to measure usage.</value>
        [DataMember(Name = "unit_of_measure")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unit_of_measure")]
        public string UnitOfMeasure { get; set; }

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
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebitMemoItem {\n");
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
            sb.Append("  RevenueRecognitionRuleName: ").Append(RevenueRecognitionRuleName).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ServiceEnd: ").Append(ServiceEnd).Append("\n");
            sb.Append("  ServiceStart: ").Append(ServiceStart).Append("\n");
            sb.Append("  AccountsReceivableAccount: ").Append(AccountsReceivableAccount).Append("\n");
            sb.Append("  DiscountItem: ").Append(DiscountItem).Append("\n");
            sb.Append("  AppliedToItemId: ").Append(AppliedToItemId).Append("\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append("\n");
            sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PriceId: ").Append(PriceId).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  SubscriptionItemId: ").Append(SubscriptionItemId).Append("\n");
            sb.Append("  InvoiceItemId: ").Append(InvoiceItemId).Append("\n");
            sb.Append("  DocumentItemDate: ").Append(DocumentItemDate).Append("\n");
            sb.Append("  TaxationItems: ").Append(TaxationItems).Append("\n");
            sb.Append("  DebitMemo: ").Append(DebitMemo).Append("\n");
            sb.Append("  DebitMemoId: ").Append(DebitMemoId).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  SubscriptionItem: ").Append(SubscriptionItem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}