using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentScheduleCreateRequest
    {
        /// <summary>
        /// Unique identifier of the customer account the payment schedule belongs to.
        /// </summary>
        /// <value>Unique identifier of the customer account the payment schedule belongs to.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Account number of the customer account the payment schedule belongs to.
        /// </summary>
        /// <value>Account number of the customer account the payment schedule belongs to.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The amount of each payment schedule item in the payment schedule.
        /// </summary>
        /// <value>The amount of each payment schedule item in the payment schedule.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The billing document with which the payment schedule is associated. Note: This field is optional. If you have the Standalone Payment feature enabled, you can leave this field blank and set standalone to true to create standalone payments. You can also choose to create unapplied payments by leaving this object blank and setting standalone to false. If Standalone Payment is not enabled, leaving this object unspecified will create unapplied payments.
        /// </summary>
        /// <value>The billing document with which the payment schedule is associated. Note: This field is optional. If you have the Standalone Payment feature enabled, you can leave this field blank and set standalone to true to create standalone payments. You can also choose to create unapplied payments by leaving this object blank and setting standalone to false. If Standalone Payment is not enabled, leaving this object unspecified will create unapplied payments.</value>
        [DataMember(Name = "billing_document")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document")]
        public AllOfpaymentScheduleCreateRequestBillingDocument BillingDocument { get; set; }

        /// <summary>
        /// Currency of the payment schedule. Note: This field is optional. The default value is the account's default currency. This field will be ignored when items is specified.
        /// </summary>
        /// <value>Currency of the payment schedule. Note: This field is optional. The default value is the account's default currency. This field will be ignored when items is specified.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Container for payment schedule items.
        /// </summary>
        /// <value>Container for payment schedule items.</value>
        [DataMember(Name = "items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items")]
        public List<PaymentScheduleItemRequest> Items { get; set; }

        /// <summary>
        /// The number of payment schedule items to be created for this payment schedule.
        /// </summary>
        /// <value>The number of payment schedule items to be created for this payment schedule.</value>
        [DataMember(Name = "number_of_payments")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_payments")]
        public int? NumberOfPayments { get; set; }

        /// <summary>
        /// ID of the payment gateway used to collect payments. Note: This field is optional. The default value is the account's default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant's default payment gateway ID. This field will be ignored when items is specified.
        /// </summary>
        /// <value>ID of the payment gateway used to collect payments. Note: This field is optional. The default value is the account's default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant's default payment gateway ID. This field will be ignored when items is specified.</value>
        [DataMember(Name = "payment_gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_gateway_id")]
        public string PaymentGatewayId { get; set; }

        /// <summary>
        /// The payment gateway number of the payment gateway used to collect scheduled payments.
        /// </summary>
        /// <value>The payment gateway number of the payment gateway used to collect scheduled payments.</value>
        [DataMember(Name = "payment_gateway_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_gateway_number")]
        public string PaymentGatewayNumber { get; set; }

        /// <summary>
        /// ID of the payment method. Note: This field is optional. The default value is the account's default payment method ID. This field will be ignored when items is specified.
        /// </summary>
        /// <value>ID of the payment method. Note: This field is optional. The default value is the account's default payment method ID. This field will be ignored when items is specified.</value>
        [DataMember(Name = "payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_id")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// The payment method number of the payment method to be used to collect payments.
        /// </summary>
        /// <value>The payment method number of the payment method to be used to collect payments.</value>
        [DataMember(Name = "payment_method_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_number")]
        public string PaymentMethodNumber { get; set; }

        /// <summary>
        /// Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the gateway_options type is supported. Payment schedule payment_options take precedence over payment schedule item payment_options.
        /// </summary>
        /// <value>Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the gateway_options type is supported. Payment schedule payment_options take precedence over payment schedule item payment_options.</value>
        [DataMember(Name = "payment_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_options")]
        public List<PaymentSchedulePaymentOptionRequest> PaymentOptions { get; set; }

        /// <summary>
        /// Number of the payment schedule.
        /// </summary>
        /// <value>Number of the payment schedule.</value>
        [DataMember(Name = "payment_schedule_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_schedule_number")]
        public string PaymentScheduleNumber { get; set; }

        /// <summary>
        /// Unit in which term duration is defined. One of week or month.
        /// </summary>
        /// <value>Unit in which term duration is defined. One of week or month.</value>
        [DataMember(Name = "period")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "period")]
        public string Period { get; set; }

        /// <summary>
        /// Indicates whether the payments created by the payment schedule will be used as reserved payments. This field will only be available if the prepaid cash drawdown permission is enabled. See <a href=\"https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Bill_for_usage_or_prepaid_products/Advanced_Consumption_Billing/Prepaid_with_Drawdown\" target=\"_blank\">Prepaid Cash with Drawdown for more information.</a>
        /// </summary>
        /// <value>Indicates whether the payments created by the payment schedule will be used as reserved payments. This field will only be available if the prepaid cash drawdown permission is enabled. See <a href=\"https://knowledgecenter.zuora.com/Zuora_Billing/Bill_your_customers/Bill_for_usage_or_prepaid_products/Advanced_Consumption_Billing/Prepaid_with_Drawdown\" target=\"_blank\">Prepaid Cash with Drawdown for more information.</a></value>
        [DataMember(Name = "prepayment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prepayment")]
        public bool? Prepayment { get; set; }

        /// <summary>
        /// Indicates whether the payments created by the payment schedule are standalone payments or not.              When setting to `true`, standalone payments will be created.       When setting to `false`, you can either specify a billing document, or not specifying any billing documents.       In the latter case, unapplied payments will be created.       If set to `null`, standalone payments will be created.              **Note**: This parameter is only available if standalone payments are enabled in your tenant. The default value is `true` if standalone payments are enabled in your tenant.
        /// </summary>
        /// <value>Indicates whether the payments created by the payment schedule are standalone payments or not.              When setting to `true`, standalone payments will be created.       When setting to `false`, you can either specify a billing document, or not specifying any billing documents.       In the latter case, unapplied payments will be created.       If set to `null`, standalone payments will be created.              **Note**: This parameter is only available if standalone payments are enabled in your tenant. The default value is `true` if standalone payments are enabled in your tenant.</value>
        [DataMember(Name = "standalone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "standalone")]
        public bool? Standalone { get; set; }

        /// <summary>
        /// The date of the first scheduled payment collection. Note: This parameter is required when `items` is not specified. This parameter will be ignored when `items` is specified.
        /// </summary>
        /// <value>The date of the first scheduled payment collection. Note: This parameter is required when `items` is not specified. This parameter will be ignored when `items` is specified.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The total amount to be collected by the payment schedule.
        /// </summary>
        /// <value>The total amount to be collected by the payment schedule.</value>
        [DataMember(Name = "total_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total_amount")]
        public decimal? TotalAmount { get; set; }

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
            sb.Append("class PaymentScheduleCreateRequest {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  BillingDocument: ").Append(BillingDocument).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  PaymentGatewayId: ").Append(PaymentGatewayId).Append("\n");
            sb.Append("  PaymentGatewayNumber: ").Append(PaymentGatewayNumber).Append("\n");
            sb.Append("  PaymentMethodNumber: ").Append(PaymentMethodNumber).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  PaymentScheduleNumber: ").Append(PaymentScheduleNumber).Append("\n");
            sb.Append("  PaymentOptions: ").Append(PaymentOptions).Append("\n");
            sb.Append("  Standalone: ").Append(Standalone).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Prepayment: ").Append(Prepayment).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}