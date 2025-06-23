using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Service.Enums
{
    /// <summary>
    /// The action associated with this metric.
    /// </summary>
    /// <value>The action associated with this metric.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActionTypeEnum
    {
        /// <summary>
        /// Enum CreateSubscriptionEnum for create_subscription
        /// </summary>
        [EnumMember(Value = "create_subscription")]
        CreateSubscriptionEnum = 0,

        /// <summary>
        /// Enum TermsEnum for terms
        /// </summary>
        [EnumMember(Value = "terms")]
        TermsEnum = 1,

        /// <summary>
        /// Enum AddSubscriptionPlanEnum for add_subscription_plan
        /// </summary>
        [EnumMember(Value = "add_subscription_plan")]
        AddSubscriptionPlanEnum = 2,

        /// <summary>
        /// Enum UpdateSubscriptionPlanEnum for update_subscription_plan
        /// </summary>
        [EnumMember(Value = "update_subscription_plan")]
        UpdateSubscriptionPlanEnum = 3,

        /// <summary>
        /// Enum RemoveSubscriptionPlanEnum for remove_subscription_plan
        /// </summary>
        [EnumMember(Value = "remove_subscription_plan")]
        RemoveSubscriptionPlanEnum = 4,

        /// <summary>
        /// Enum RenewEnum for renew
        /// </summary>
        [EnumMember(Value = "renew")]
        RenewEnum = 5,

        /// <summary>
        /// Enum CancelEnum for cancel
        /// </summary>
        [EnumMember(Value = "cancel")]
        CancelEnum = 6,

        /// <summary>
        /// Enum OwnerTransferEnum for owner_transfer
        /// </summary>
        [EnumMember(Value = "owner_transfer")]
        OwnerTransferEnum = 7,

        /// <summary>
        /// Enum PauseEnum for pause
        /// </summary>
        [EnumMember(Value = "pause")]
        PauseEnum = 8,

        /// <summary>
        /// Enum ResumeEnum for resume
        /// </summary>
        [EnumMember(Value = "resume")]
        ResumeEnum = 9,

        /// <summary>
        /// Enum ReplaceSubscriptionPlanEnum for replace_subscription_plan
        /// </summary>
        [EnumMember(Value = "replace_subscription_plan")]
        ReplaceSubscriptionPlanEnum = 10
    }

    /// <summary>
    /// Indicates whether to generate a preview of future invoice items and credit memo items with the assumption that the subscriptions are renewed. **all**: The assumption is applied to all the subscriptions. Zuora generates preview invoice item data and credit memo item data from the first day of the customer's next billing period to the target date. **auto_renew_only**: The assumption is applied to the subscriptions that have auto_renew enabled. Zuora generates preview invoice item data and credit memo item data from the first day of the customer's next billing period to the target date.
    /// </summary>
    /// <value>Indicates whether to generate a preview of future invoice items and credit memo items with the assumption that the subscriptions are renewed. **all**: The assumption is applied to all the subscriptions. Zuora generates preview invoice item data and credit memo item data from the first day of the customer's next billing period to the target date. **auto_renew_only**: The assumption is applied to the subscriptions that have auto_renew enabled. Zuora generates preview invoice item data and credit memo item data from the first day of the customer's next billing period to the target date.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssumeRenewalEnum
    {
        /// <summary>
        /// Enum AllEnum for all
        /// </summary>
        [EnumMember(Value = "all")]
        AllEnum = 0,

        /// <summary>
        /// Enum AutoRenewOnlyEnum for auto_renew_only
        /// </summary>
        [EnumMember(Value = "auto_renew_only")]
        AutoRenewOnlyEnum = 1,

        /// <summary>
        /// Enum NoneEnum for none
        /// </summary>
        [EnumMember(Value = "none")]
        NoneEnum = 2
    }

    /// <summary>
    /// The type of bank account associated with the payment method.
    /// </summary>
    /// <value>The type of bank account associated with the payment method.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BankAccountTypeEnum
    {
        /// <summary>
        /// Enum BusinessSavingEnum for business_saving
        /// </summary>
        [EnumMember(Value = "business_saving")]
        BusinessSavingEnum = 0,

        /// <summary>
        /// Enum BusinessCheckingEnum for business_checking
        /// </summary>
        [EnumMember(Value = "business_checking")]
        BusinessCheckingEnum = 1,

        /// <summary>
        /// Enum CheckingEnum for checking
        /// </summary>
        [EnumMember(Value = "checking")]
        CheckingEnum = 2,

        /// <summary>
        /// Enum SavingEnum for saving
        /// </summary>
        [EnumMember(Value = "saving")]
        SavingEnum = 3
    }

    /// <summary>
    /// The status of the billing document.
    /// </summary>
    /// <value>The status of the billing document.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BillingDocumentStateEnum
    {
        /// <summary>
        /// Enum DraftEnum for draft
        /// </summary>
        [EnumMember(Value = "draft")]
        DraftEnum = 0,

        /// <summary>
        /// Enum OpenEnum for open
        /// </summary>
        [EnumMember(Value = "open")]
        OpenEnum = 1,

        /// <summary>
        /// Enum UncollectibleEnum for uncollectible
        /// </summary>
        [EnumMember(Value = "uncollectible")]
        UncollectibleEnum = 2,

        /// <summary>
        /// Enum FailedEnum for failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FailedEnum = 3
    }

    /// <summary>
    /// The type of billing document. Can be one of the credit memo, debit memo, or invoice.
    /// </summary>
    /// <value>The type of billing document. Can be one of the credit memo, debit memo, or invoice.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BillingDocumentTypeEnum
    {
        /// <summary>
        /// Enum CreditMemoEnum for credit_memo
        /// </summary>
        [EnumMember(Value = "credit_memo")]
        CreditMemoEnum = 0,

        /// <summary>
        /// Enum DebitMemoEnum for debit_memo
        /// </summary>
        [EnumMember(Value = "debit_memo")]
        DebitMemoEnum = 1,

        /// <summary>
        /// Enum InvoiceEnum for invoice
        /// </summary>
        [EnumMember(Value = "invoice")]
        InvoiceEnum = 2
    }

    /// <summary>
    /// The billing rule for the Order Line Item.
    /// </summary>
    /// <value>The billing rule for the Order Line Item.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BillingRuleEnum
    {
        /// <summary>
        /// Enum WithoutFulfillmentEnum for trigger_without_fulfillment
        /// </summary>
        [EnumMember(Value = "trigger_without_fulfillment")]
        WithoutFulfillmentEnum = 0,

        /// <summary>
        /// Enum OnFulfillmentEnum for trigger_on_fulfillment
        /// </summary>
        [EnumMember(Value = "trigger_on_fulfillment")]
        OnFulfillmentEnum = 1
    }

    /// <summary>
    /// The state of the bill run preview.
    /// </summary>
    /// <value>The state of the bill run preview.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BillRunPreviewStateEnum
    {
        /// <summary>
        /// Enum PendingEnum for pending
        /// </summary>
        [EnumMember(Value = "pending")]
        PendingEnum = 0,

        /// <summary>
        /// Enum ProcessingEnum for processing
        /// </summary>
        [EnumMember(Value = "processing")]
        ProcessingEnum = 1,

        /// <summary>
        /// Enum CompletedEnum for completed
        /// </summary>
        [EnumMember(Value = "completed")]
        CompletedEnum = 2,

        /// <summary>
        /// Enum FailedEnum for failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FailedEnum = 3,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 4
    }

    /// <summary>
    /// Status of the bill run.
    /// </summary>
    /// <value>Status of the bill run.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BillRunStateEnum
    {
        /// <summary>
        /// Enum ProcessedEnum for processed
        /// </summary>
        [EnumMember(Value = "processed")]
        ProcessedEnum = 0,

        /// <summary>
        /// Enum PendingEnum for pending
        /// </summary>
        [EnumMember(Value = "pending")]
        PendingEnum = 1,

        /// <summary>
        /// Enum CompletedEnum for completed
        /// </summary>
        [EnumMember(Value = "completed")]
        CompletedEnum = 2,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 3,

        /// <summary>
        /// Enum PostedEnum for posted
        /// </summary>
        [EnumMember(Value = "posted")]
        PostedEnum = 4,

        /// <summary>
        /// Enum FailedEnum for failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FailedEnum = 5
    }

    /// <summary>
    /// The type of the bill run. This field is only available if you have the <a href=”https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Automate_billing_document_generation/Bill_runs/Z_Catch-Up_Bill_Run” target=”_blank”>Catch-Up Bill Run</a> feature enabled in your tenant.
    /// </summary>
    /// <value>The type of the bill run. This field is only available if you have the <a href=”https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Automate_billing_document_generation/Bill_runs/Z_Catch-Up_Bill_Run” target=”_blank”>Catch-Up Bill Run</a> feature enabled in your tenant.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BillRunTypeEnum
    {
        /// <summary>
        /// Enum RegularEnum for regular
        /// </summary>
        [EnumMember(Value = "regular")]
        RegularEnum = 0,

        /// <summary>
        /// Enum CatchUpEnum for catch_up
        /// </summary>
        [EnumMember(Value = "catch_up")]
        CatchUpEnum = 1
    }

    /// <summary>
    /// Card brand.
    /// </summary>
    /// <value>Card brand.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BrandEnum
    {
        /// <summary>
        /// Enum VisaEnum for visa
        /// </summary>
        [EnumMember(Value = "visa")]
        VisaEnum = 0,

        /// <summary>
        /// Enum MastercardEnum for mastercard
        /// </summary>
        [EnumMember(Value = "mastercard")]
        MastercardEnum = 1,

        /// <summary>
        /// Enum AmericanExpressEnum for american_express
        /// </summary>
        [EnumMember(Value = "american_express")]
        AmericanExpressEnum = 2,

        /// <summary>
        /// Enum DiscoverEnum for discover
        /// </summary>
        [EnumMember(Value = "discover")]
        DiscoverEnum = 3,

        /// <summary>
        /// Enum JcbEnum for jcb
        /// </summary>
        [EnumMember(Value = "jcb")]
        JcbEnum = 4,

        /// <summary>
        /// Enum DinersEnum for diners
        /// </summary>
        [EnumMember(Value = "diners")]
        DinersEnum = 5
    }

    /// <summary>
    /// The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.
    /// </summary>
    /// <value>The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CancelAtEnum
    {
        /// <summary>
        /// Enum InvoicePeriodEndEnum for invoice_period_end
        /// </summary>
        [EnumMember(Value = "invoice_period_end")]
        InvoicePeriodEndEnum = 0,

        /// <summary>
        /// Enum SubscriptionTermEndEnum for subscription_term_end
        /// </summary>
        [EnumMember(Value = "subscription_term_end")]
        SubscriptionTermEndEnum = 1
    }

    /// <summary>
    /// The status of the mandate, which indicates whether it can be used to initiate a payment.
    /// </summary>
    /// <value>The status of the mandate, which indicates whether it can be used to initiate a payment.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CardMandateStateEnum
    {
        /// <summary>
        /// Enum ActiveEnum for active
        /// </summary>
        [EnumMember(Value = "active")]
        ActiveEnum = 0,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 1,

        /// <summary>
        /// Enum ExpiredEnum for expired
        /// </summary>
        [EnumMember(Value = "expired")]
        ExpiredEnum = 2,

        /// <summary>
        /// Enum AgreedEnum for agreed
        /// </summary>
        [EnumMember(Value = "agreed")]
        AgreedEnum = 3
    }

    /// <summary>
    /// Gets or Sets ChargesExcluded
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChargesExcludedEnum
    {
        /// <summary>
        /// Enum OneTimeEnum for one_time
        /// </summary>
        [EnumMember(Value = "one_time")]
        OneTimeEnum = 0,

        /// <summary>
        /// Enum RecurringEnum for recurring
        /// </summary>
        [EnumMember(Value = "recurring")]
        RecurringEnum = 1,

        /// <summary>
        /// Enum UsageEnum for usage
        /// </summary>
        [EnumMember(Value = "usage")]
        UsageEnum = 2
    }

    /// <summary>
    /// Specifies whether to just create an invoice, or to create an invoice and collect payment.
    /// </summary>
    /// <value>Specifies whether to just create an invoice, or to create an invoice and collect payment.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CollectionMethodEnum
    {
        /// <summary>
        /// Enum CollectPaymentEnum for collect_payment
        /// </summary>
        [EnumMember(Value = "collect_payment")]
        CollectPaymentEnum = 0,

        /// <summary>
        /// Enum CreateInvoiceEnum for create_invoice
        /// </summary>
        [EnumMember(Value = "create_invoice")]
        CreateInvoiceEnum = 1,

        /// <summary>
        /// Enum ProcessRefundEnum for process_refund
        /// </summary>
        [EnumMember(Value = "process_refund")]
        ProcessRefundEnum = 2,

        /// <summary>
        /// Enum RunBillingEnum for run_billing
        /// </summary>
        [EnumMember(Value = "run_billing")]
        RunBillingEnum = 3
    }

    /// <summary>
    /// The status of the billing document.
    /// </summary>
    /// <value>The status of the billing document.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreditMemoStateEnum
    {
        /// <summary>
        /// Enum DraftEnum for draft
        /// </summary>
        [EnumMember(Value = "draft")]
        DraftEnum = 0,

        /// <summary>
        /// Enum PostedEnum for posted
        /// </summary>
        [EnumMember(Value = "posted")]
        PostedEnum = 1,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 2,

        /// <summary>
        /// Enum FailedEnum for failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FailedEnum = 3
    }

    /// <summary>
    /// The status of the debit memo.
    /// </summary>
    /// <value>The status of the debit memo.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DebitMemoStateEnum
    {
        /// <summary>
        /// Enum DraftEnum for draft
        /// </summary>
        [EnumMember(Value = "draft")]
        DraftEnum = 0,

        /// <summary>
        /// Enum PostedEnum for posted
        /// </summary>
        [EnumMember(Value = "posted")]
        PostedEnum = 1,

        /// <summary>
        /// Enum OpenEnum for open
        /// </summary>
        [EnumMember(Value = "open")]
        OpenEnum = 2,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 3,

        /// <summary>
        /// Enum FailedEnum for failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FailedEnum = 4
    }

    /// <summary>
    /// Any combination of one-time, recurring, and usage.
    /// </summary>
    /// <value>Any combination of one-time, recurring, and usage.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExcludeEnum
    {
        /// <summary>
        /// Enum OneTimeEnum for one_time
        /// </summary>
        [EnumMember(Value = "one_time")]
        OneTimeEnum = 0,

        /// <summary>
        /// Enum RecurringEnum for recurring
        /// </summary>
        [EnumMember(Value = "recurring")]
        RecurringEnum = 1,

        /// <summary>
        /// Enum UsageEnum for usage
        /// </summary>
        [EnumMember(Value = "usage")]
        UsageEnum = 2
    }

    /// <summary>
    /// The status of the invoice.
    /// </summary>
    /// <value>The status of the invoice.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FullFillmenStateEnum
    {
        /// <summary>
        /// Enum AcceptedEnum for accepted
        /// </summary>
        [EnumMember(Value = "accepted")]
        AcceptedEnum = 0,

        /// <summary>
        /// Enum BookedEnum for booked
        /// </summary>
        [EnumMember(Value = "booked")]
        BookedEnum = 1,

        /// <summary>
        /// Enum SentToBillingEnum for sent_to_billing
        /// </summary>
        [EnumMember(Value = "sent_to_billing")]
        SentToBillingEnum = 2,

        /// <summary>
        /// Enum CompleteEnum for complete
        /// </summary>
        [EnumMember(Value = "complete")]
        CompleteEnum = 3,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 4
    }

    /// <summary>
    /// The type of fulfillment.
    /// </summary>
    /// <value>The type of fulfillment.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FullFilmentTypeEnum
    {
        /// <summary>
        /// Enum DeliveryEnum for delivery
        /// </summary>
        [EnumMember(Value = "delivery")]
        DeliveryEnum = 0,

        /// <summary>
        /// Enum ReturnEnum for return
        /// </summary>
        [EnumMember(Value = "return")]
        ReturnEnum = 1
    }

    /// <summary>
    /// The type of billing document, one of invoice or debit_memo.
    /// </summary>
    /// <value>The type of billing document, one of invoice or debit_memo.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvoiceDebitMemoTypeEnum
    {
        /// <summary>
        /// Enum DebitMemoEnum for debit_memo
        /// </summary>
        [EnumMember(Value = "debit_memo")]
        DebitMemoEnum = 0,

        /// <summary>
        /// Enum InvoiceEnum for invoice
        /// </summary>
        [EnumMember(Value = "invoice")]
        InvoiceEnum = 1
    }

    /// <summary>
    /// The status of the invoice.
    /// </summary>
    /// <value>The status of the invoice.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvoiceStateEnum
    {
        /// <summary>
        /// Enum DraftEnum for draft
        /// </summary>
        [EnumMember(Value = "draft")]
        DraftEnum = 0,

        /// <summary>
        /// Enum PostedEnum for posted
        /// </summary>
        [EnumMember(Value = "posted")]
        PostedEnum = 1,

        /// <summary>
        /// Enum OpenEnum for open
        /// </summary>
        [EnumMember(Value = "open")]
        OpenEnum = 2,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 3,

        /// <summary>
        /// Enum FailedEnum for failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FailedEnum = 4
    }

    /// <summary>
    /// The category for the order line item, to indicate a product sale or return.
    /// </summary>
    /// <value>The category for the order line item, to indicate a product sale or return.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LineItemCategoryEnum
    {
        /// <summary>
        /// Enum SaleEnum for sale
        /// </summary>
        [EnumMember(Value = "sale")]
        SaleEnum = 0,

        /// <summary>
        /// Enum ReturnEnum for return
        /// </summary>
        [EnumMember(Value = "return")]
        ReturnEnum = 1
    }

    /// <summary>
    /// The state of an order line item. If you want to generate billing documents for order line items, you must set this field to `sent_to_billing`. For invoice preview, you do not need to set this field.
    /// </summary>
    /// <value>The state of an order line item. If you want to generate billing documents for order line items, you must set this field to `sent_to_billing`. For invoice preview, you do not need to set this field.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LineItemStateEnum
    {
        /// <summary>
        /// Enum PendingEnum for pending
        /// </summary>
        [EnumMember(Value = "pending")]
        PendingEnum = 0,

        /// <summary>
        /// Enum BookedEnum for booked
        /// </summary>
        [EnumMember(Value = "booked")]
        BookedEnum = 1,

        /// <summary>
        /// Enum SentToBillingEnum for sent_to_billing
        /// </summary>
        [EnumMember(Value = "sent_to_billing")]
        SentToBillingEnum = 2,

        /// <summary>
        /// Enum CompleteEnum for complete
        /// </summary>
        [EnumMember(Value = "complete")]
        CompleteEnum = 3,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 4
    }

    /// <summary>
    /// The type of the order line item.
    /// </summary>
    /// <value>The type of the order line item.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LineItemTypeEnum
    {
        /// <summary>
        /// Enum ProductEnum for product
        /// </summary>
        [EnumMember(Value = "product")]
        ProductEnum = 0,

        /// <summary>
        /// Enum FeeEnum for fee
        /// </summary>
        [EnumMember(Value = "fee")]
        FeeEnum = 1,

        /// <summary>
        /// Enum ServicesEnum for services
        /// </summary>
        [EnumMember(Value = "services")]
        ServicesEnum = 2
    }

    /// <summary>
    /// The status of the mandate, which indicates whether it can be used to initiate a payment.
    /// </summary>
    /// <value>The status of the mandate, which indicates whether it can be used to initiate a payment.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MandateStateEnum
    {
        /// <summary>
        /// Enum ActiveEnum for active
        /// </summary>
        [EnumMember(Value = "active")]
        ActiveEnum = 0,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 1,

        /// <summary>
        /// Enum ExpiredEnum for expired
        /// </summary>
        [EnumMember(Value = "expired")]
        ExpiredEnum = 2,

        /// <summary>
        /// Enum AgreedEnum for agreed
        /// </summary>
        [EnumMember(Value = "agreed")]
        AgreedEnum = 3
    }

    /// <summary>
    /// Indicates the type of mandate, if any.
    /// </summary>
    /// <value>Indicates the type of mandate, if any.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MandateTypeEnum
    {
        /// <summary>
        /// Enum MultiUseEnum for multi_use
        /// </summary>
        [EnumMember(Value = "multi_use")]
        MultiUseEnum = 0,

        /// <summary>
        /// Enum SingleUseEnum for single_use
        /// </summary>
        [EnumMember(Value = "single_use")]
        SingleUseEnum = 1
    }

    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MetricsEnum
    {
        /// <summary>
        /// Enum BillingDocumentsEnum for billing_documents
        /// </summary>
        [EnumMember(Value = "billing_documents")]
        BillingDocumentsEnum = 0,

        /// <summary>
        /// Enum DeltaMetricsEnum for delta_metrics
        /// </summary>
        [EnumMember(Value = "delta_metrics")]
        DeltaMetricsEnum = 1
    }

    /// <summary>
    /// Category of the order to indicate a product sale or return. Default value is `sale`.
    /// </summary>
    /// <value>Category of the order to indicate a product sale or return. Default value is `sale`.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderCategoryEnum
    {
        /// <summary>
        /// Enum SaleEnum for sale
        /// </summary>
        [EnumMember(Value = "sale")]
        SaleEnum = 0,

        /// <summary>
        /// Enum ReturnEnum for return
        /// </summary>
        [EnumMember(Value = "return")]
        ReturnEnum = 1
    }

    /// <summary>
    /// The status of the order.
    /// </summary>
    /// <value>The status of the order.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderStateEnum
    {
        /// <summary>
        /// Enum PendingEnum for pending
        /// </summary>
        [EnumMember(Value = "pending")]
        PendingEnum = 0,

        /// <summary>
        /// Enum CompleteEnum for complete
        /// </summary>
        [EnumMember(Value = "complete")]
        CompleteEnum = 1,

        /// <summary>
        /// Enum DraftEnum for draft
        /// </summary>
        [EnumMember(Value = "draft")]
        DraftEnum = 2,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 3,

        /// <summary>
        /// Enum ScheduledEnum for scheduled
        /// </summary>
        [EnumMember(Value = "scheduled")]
        ScheduledEnum = 4,

        /// <summary>
        /// Enum ExecutingEnum for executing
        /// </summary>
        [EnumMember(Value = "executing")]
        ExecutingEnum = 5,

        /// <summary>
        /// Enum FailedEnum for failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FailedEnum = 6
    }

    /// <summary>
    /// The type of the additional phone number.
    /// </summary>
    /// <value>The type of the additional phone number.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OtherPhoneTypeEnum
    {
        /// <summary>
        /// Enum WorkEnum for work
        /// </summary>
        [EnumMember(Value = "work")]
        WorkEnum = 0,

        /// <summary>
        /// Enum MobileEnum for mobile
        /// </summary>
        [EnumMember(Value = "mobile")]
        MobileEnum = 1,

        /// <summary>
        /// Enum HomeEnum for home
        /// </summary>
        [EnumMember(Value = "home")]
        HomeEnum = 2,

        /// <summary>
        /// Enum OtherEnum for other
        /// </summary>
        [EnumMember(Value = "other")]
        OtherEnum = 3
    }

    /// <summary>
    /// Represents the overage type: one of rolling_window or rollover.
    /// </summary>
    /// <value>Represents the overage type: one of rolling_window or rollover.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OverageTypeEnum
    {
        /// <summary>
        /// Enum RollingWindowEnum for rolling_window
        /// </summary>
        [EnumMember(Value = "rolling_window")]
        RollingWindowEnum = 0,

        /// <summary>
        /// Enum RolloverEnum for rollover
        /// </summary>
        [EnumMember(Value = "rollover")]
        RolloverEnum = 1
    }

    /// <summary>
    /// Can be either the end of the current billing period or a specific date.
    /// </summary>
    /// <value>Can be either the end of the current billing period or a specific date.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PauseAtEnum
    {
        /// <summary>
        /// Enum InvoicePeriodEndEnum for invoice_period_end
        /// </summary>
        [EnumMember(Value = "invoice_period_end")]
        InvoicePeriodEndEnum = 0
    }

    /// <summary>
    /// Unit in which the pause duration is defined. One of day, week, month or year.
    /// </summary>
    /// <value>Unit in which the pause duration is defined. One of day, week, month or year.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PauseIntervalEnum
    {
        /// <summary>
        /// Enum MonthEnum for month
        /// </summary>
        [EnumMember(Value = "month")]
        MonthEnum = 0,

        /// <summary>
        /// Enum DayEnum for day
        /// </summary>
        [EnumMember(Value = "day")]
        DayEnum = 1,

        /// <summary>
        /// Enum YearEnum for year
        /// </summary>
        [EnumMember(Value = "year")]
        YearEnum = 2,

        /// <summary>
        /// Enum WeekEnum for week
        /// </summary>
        [EnumMember(Value = "week")]
        WeekEnum = 3
    }

    /// <summary>
    /// The payment gateway state of the payment.
    /// </summary>
    /// <value>The payment gateway state of the payment.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentGatewayStateEnum
    {
        /// <summary>
        /// Enum MarkedForSubmissionEnum for marked_for_submission
        /// </summary>
        [EnumMember(Value = "marked_for_submission")]
        MarkedForSubmissionEnum = 0,

        /// <summary>
        /// Enum SubmittedEnum for submitted
        /// </summary>
        [EnumMember(Value = "submitted")]
        SubmittedEnum = 1,

        /// <summary>
        /// Enum SettledEnum for settled
        /// </summary>
        [EnumMember(Value = "settled")]
        SettledEnum = 2,

        /// <summary>
        /// Enum NotSubmittedEnum for not_submitted
        /// </summary>
        [EnumMember(Value = "not_submitted")]
        NotSubmittedEnum = 3,

        /// <summary>
        /// Enum FailedEnum for failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FailedEnum = 4
    }

    /// <summary>
    /// The status of the payment authorization.
    /// </summary>
    /// <value>The status of the payment authorization.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentMethodAuthorizationStateEnum
    {
        /// <summary>
        /// Enum ApprovedEnum for approved
        /// </summary>
        [EnumMember(Value = "approved")]
        ApprovedEnum = 0,

        /// <summary>
        /// Enum QueuedForSubmissionEnum for queued_for_submission
        /// </summary>
        [EnumMember(Value = "queued_for_submission")]
        QueuedForSubmissionEnum = 1
    }

    /// <summary>
    /// The state of the payment method.
    /// </summary>
    /// <value>The state of the payment method.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentMethodStateEnum
    {
        /// <summary>
        /// Enum ActiveEnum for active
        /// </summary>
        [EnumMember(Value = "active")]
        ActiveEnum = 0,

        /// <summary>
        /// Enum ClosedEnum for closed
        /// </summary>
        [EnumMember(Value = "closed")]
        ClosedEnum = 1,

        /// <summary>
        /// Enum ScrubbedEnum for scrubbed
        /// </summary>
        [EnumMember(Value = "scrubbed")]
        ScrubbedEnum = 2
    }

    /// <summary>
    /// The type of the payment method. An additional hash is included on the payment method with a name matching this value. It contains additional information specific to the payment method type.
    /// </summary>
    /// <value>The type of the payment method. An additional hash is included on the payment method with a name matching this value. It contains additional information specific to the payment method type.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentMethodTypeEnum
    {
        /// <summary>
        /// Enum PaypalExpressEnum for paypal_express
        /// </summary>
        [EnumMember(Value = "paypal_express")]
        PaypalExpressEnum = 0,

        /// <summary>
        /// Enum PaypalExpressNativeEnum for paypal_express_native
        /// </summary>
        [EnumMember(Value = "paypal_express_native")]
        PaypalExpressNativeEnum = 1,

        /// <summary>
        /// Enum PaypalAdaptiveEnum for paypal_adaptive
        /// </summary>
        [EnumMember(Value = "paypal_adaptive")]
        PaypalAdaptiveEnum = 2,

        /// <summary>
        /// Enum CardEnum for card
        /// </summary>
        [EnumMember(Value = "card")]
        CardEnum = 3,

        /// <summary>
        /// Enum CcRefEnum for cc_ref
        /// </summary>
        [EnumMember(Value = "cc_ref")]
        CcRefEnum = 4,

        /// <summary>
        /// Enum AchDebitEnum for ach_debit
        /// </summary>
        [EnumMember(Value = "ach_debit")]
        AchDebitEnum = 5,

        /// <summary>
        /// Enum SepaDebitEnum for sepa_debit
        /// </summary>
        [EnumMember(Value = "sepa_debit")]
        SepaDebitEnum = 6,

        /// <summary>
        /// Enum BetalingsDebitEnum for betalings_debit
        /// </summary>
        [EnumMember(Value = "betalings_debit")]
        BetalingsDebitEnum = 7,

        /// <summary>
        /// Enum AutogiroDebitEnum for autogiro_debit
        /// </summary>
        [EnumMember(Value = "autogiro_debit")]
        AutogiroDebitEnum = 8,

        /// <summary>
        /// Enum BacsDebitEnum for bacs_debit
        /// </summary>
        [EnumMember(Value = "bacs_debit")]
        BacsDebitEnum = 9,

        /// <summary>
        /// Enum AuBecsDebitEnum for au_becs_debit
        /// </summary>
        [EnumMember(Value = "au_becs_debit")]
        AuBecsDebitEnum = 10,

        /// <summary>
        /// Enum NzBecsDebitEnum for nz_becs_debit
        /// </summary>
        [EnumMember(Value = "nz_becs_debit")]
        NzBecsDebitEnum = 11,

        /// <summary>
        /// Enum PadDebitEnum for pad_debit
        /// </summary>
        [EnumMember(Value = "pad_debit")]
        PadDebitEnum = 12,

        /// <summary>
        /// Enum ApplePayEnum for apple_pay
        /// </summary>
        [EnumMember(Value = "apple_pay")]
        ApplePayEnum = 13,

        /// <summary>
        /// Enum WireTransferEnum for wire_transfer
        /// </summary>
        [EnumMember(Value = "wire_transfer")]
        WireTransferEnum = 14,

        /// <summary>
        /// Enum CheckEnum for check
        /// </summary>
        [EnumMember(Value = "check")]
        CheckEnum = 15,

        /// <summary>
        /// Enum CashEnum for cash
        /// </summary>
        [EnumMember(Value = "cash")]
        CashEnum = 16,

        /// <summary>
        /// Enum OtherEnum for other
        /// </summary>
        [EnumMember(Value = "other")]
        OtherEnum = 17,

        /// <summary>
        /// Enum PaypalEnum for paypal
        /// </summary>
        [EnumMember(Value = "paypal")]
        PaypalEnum = 18,

        /// <summary>
        /// Enum AdyenGooglePayEnum for adyen_google_pay
        /// </summary>
        [EnumMember(Value = "adyen_google_pay")]
        AdyenGooglePayEnum = 19,

        /// <summary>
        /// Enum AdyenApplePayEnum for adyen_apple_pay
        /// </summary>
        [EnumMember(Value = "adyen_apple_pay")]
        AdyenApplePayEnum = 20
    }

    /// <summary>
    /// The state of the payment.
    /// </summary>
    /// <value>The state of the payment.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentStateEnum
    {
        /// <summary>
        /// Enum DraftEnum for draft
        /// </summary>
        [EnumMember(Value = "draft")]
        DraftEnum = 0,

        /// <summary>
        /// Enum PostedEnum for posted
        /// </summary>
        [EnumMember(Value = "posted")]
        PostedEnum = 1,

        /// <summary>
        /// Enum ProcessingEnum for processing
        /// </summary>
        [EnumMember(Value = "processing")]
        ProcessingEnum = 2,

        /// <summary>
        /// Enum ProcessedEnum for processed
        /// </summary>
        [EnumMember(Value = "processed")]
        ProcessedEnum = 3,

        /// <summary>
        /// Enum ErrorEnum for error
        /// </summary>
        [EnumMember(Value = "error")]
        ErrorEnum = 4,

        /// <summary>
        /// Enum CanceledEnum for canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CanceledEnum = 5
    }

    /// <summary>
    /// The type of the payment method. An additional hash is included on the payment method with a name matching this value. It contains additional information specific to the payment method type.
    /// </summary>
    /// <value>The type of the payment method. An additional hash is included on the payment method with a name matching this value. It contains additional information specific to the payment method type.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentTypeEnum
    {
        /// <summary>
        /// Enum PaypalExpressEnum for paypal_express
        /// </summary>
        [EnumMember(Value = "paypal_express")]
        PaypalExpressEnum = 0,

        /// <summary>
        /// Enum PaypalExpressNativeEnum for paypal_express_native
        /// </summary>
        [EnumMember(Value = "paypal_express_native")]
        PaypalExpressNativeEnum = 1,

        /// <summary>
        /// Enum PaypalAdaptiveEnum for paypal_adaptive
        /// </summary>
        [EnumMember(Value = "paypal_adaptive")]
        PaypalAdaptiveEnum = 2,

        /// <summary>
        /// Enum CardEnum for card
        /// </summary>
        [EnumMember(Value = "card")]
        CardEnum = 3,

        /// <summary>
        /// Enum CcRefEnum for cc_ref
        /// </summary>
        [EnumMember(Value = "cc_ref")]
        CcRefEnum = 4,

        /// <summary>
        /// Enum AchDebitEnum for ach_debit
        /// </summary>
        [EnumMember(Value = "ach_debit")]
        AchDebitEnum = 5,

        /// <summary>
        /// Enum SepaDebitEnum for sepa_debit
        /// </summary>
        [EnumMember(Value = "sepa_debit")]
        SepaDebitEnum = 6,

        /// <summary>
        /// Enum BetalingsDebitEnum for betalings_debit
        /// </summary>
        [EnumMember(Value = "betalings_debit")]
        BetalingsDebitEnum = 7,

        /// <summary>
        /// Enum AutogiroDebitEnum for autogiro_debit
        /// </summary>
        [EnumMember(Value = "autogiro_debit")]
        AutogiroDebitEnum = 8,

        /// <summary>
        /// Enum BacsDebitEnum for bacs_debit
        /// </summary>
        [EnumMember(Value = "bacs_debit")]
        BacsDebitEnum = 9,

        /// <summary>
        /// Enum AuBecsDebitEnum for au_becs_debit
        /// </summary>
        [EnumMember(Value = "au_becs_debit")]
        AuBecsDebitEnum = 10,

        /// <summary>
        /// Enum NzBecsDebitEnum for nz_becs_debit
        /// </summary>
        [EnumMember(Value = "nz_becs_debit")]
        NzBecsDebitEnum = 11,

        /// <summary>
        /// Enum PadDebitEnum for pad_debit
        /// </summary>
        [EnumMember(Value = "pad_debit")]
        PadDebitEnum = 12,

        /// <summary>
        /// Enum ApplePayEnum for apple_pay
        /// </summary>
        [EnumMember(Value = "apple_pay")]
        ApplePayEnum = 13,

        /// <summary>
        /// Enum WireTransferEnum for wire_transfer
        /// </summary>
        [EnumMember(Value = "wire_transfer")]
        WireTransferEnum = 14,

        /// <summary>
        /// Enum CheckEnum for check
        /// </summary>
        [EnumMember(Value = "check")]
        CheckEnum = 15,

        /// <summary>
        /// Enum CashEnum for cash
        /// </summary>
        [EnumMember(Value = "cash")]
        CashEnum = 16,

        /// <summary>
        /// Enum OtherEnum for other
        /// </summary>
        [EnumMember(Value = "other")]
        OtherEnum = 17,

        /// <summary>
        /// Enum PaypalEnum for paypal
        /// </summary>
        [EnumMember(Value = "paypal")]
        PaypalEnum = 18,

        /// <summary>
        /// Enum AdyenGooglePayEnum for adyen_google_pay
        /// </summary>
        [EnumMember(Value = "adyen_google_pay")]
        AdyenGooglePayEnum = 19,

        /// <summary>
        /// Enum AdyenApplePayEnum for adyen_apple_pay
        /// </summary>
        [EnumMember(Value = "adyen_apple_pay")]
        AdyenApplePayEnum = 20
    }

    /// <summary>
    /// Gets or Sets ProcessingType
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProcessingTypeEnum
    {
        /// <summary>
        /// Enum SubscriptionItemEnum for subscription_item
        /// </summary>
        [EnumMember(Value = "subscription_item")]
        SubscriptionItemEnum = 0,

        /// <summary>
        /// Enum DiscountEnum for discount
        /// </summary>
        [EnumMember(Value = "discount")]
        DiscountEnum = 1,

        /// <summary>
        /// Enum PrepaymentEnum for prepayment
        /// </summary>
        [EnumMember(Value = "prepayment")]
        PrepaymentEnum = 2,

        /// <summary>
        /// Enum TaxEnum for tax
        /// </summary>
        [EnumMember(Value = "tax")]
        TaxEnum = 3
    }

    /// <summary>
    /// Indicates the type of the stored credential profile, if any.
    /// </summary>
    /// <value>Indicates the type of the stored credential profile, if any.</value>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StoredCredentialProfileTypeEnum
    {
        /// <summary>
        /// Enum MultiUseEnum for multi_use
        /// </summary>
        [EnumMember(Value = "multi_use")]
        MultiUseEnum = 0,

        /// <summary>
        /// Enum SingleUseEnum for single_use
        /// </summary>
        [EnumMember(Value = "single_use")]
        SingleUseEnum = 1
    }
}