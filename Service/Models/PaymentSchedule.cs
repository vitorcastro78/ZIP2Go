using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentSchedule
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
        public AllOfpaymentScheduleBillingDocument BillingDocument { get; set; }

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
        /// Currency of the payment schedule. Note: This field is optional. The default value is the account's default currency. This field will be ignored when items is specified.
        /// </summary>
        /// <value>Currency of the payment schedule. Note: This field is optional. The default value is the account's default currency. This field will be ignored when items is specified.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// If it is set to `true`, the payment schedule is a custom payment schedule.
        /// </summary>
        /// <value>If it is set to `true`, the payment schedule is a custom payment schedule.</value>
        [DataMember(Name = "custom")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom")]
        public bool? Custom { get; set; }

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
        public OneOfpaymentScheduleCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items")]
        public List<PaymentScheduleItem> Items { get; set; }

        /// <summary>
        /// The date of the next scheduled payment.
        /// </summary>
        /// <value>The date of the next scheduled payment.</value>
        [DataMember(Name = "next_payment_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "next_payment_date")]
        public DateTime? NextPaymentDate { get; set; }

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
        /// ID of the payment method. Note: This field is optional. The default value is the account's default payment method ID. This field will be ignored when items is specified.
        /// </summary>
        /// <value>ID of the payment method. Note: This field is optional. The default value is the account's default payment method ID. This field will be ignored when items is specified.</value>
        [DataMember(Name = "payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_id")]
        public string PaymentMethodId { get; set; }

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
        /// The date of the most recent scheduled payment.
        /// </summary>
        /// <value>The date of the most recent scheduled payment.</value>
        [DataMember(Name = "recent_payment_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recent_payment_date")]
        public DateTime? RecentPaymentDate { get; set; }

        /// <summary>
        /// At which hour in the day in the tenant's timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenant’s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs.
        /// </summary>
        /// <value>At which hour in the day in the tenant's timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenant’s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs.</value>
        [DataMember(Name = "run_hour")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "run_hour")]
        public int? RunHour { get; set; }

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
        /// The status of the payment schedule. active: there are unprocessed payment schedule items. canceled: the payment schedule has been canceled. complete: the payment schedule is complete and all items have been processed.
        /// </summary>
        /// <value>The status of the payment schedule. active: there are unprocessed payment schedule items. canceled: the payment schedule has been canceled. complete: the payment schedule is complete and all items have been processed.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// The total amount to be collected by the payment schedule.
        /// </summary>
        /// <value>The total amount to be collected by the payment schedule.</value>
        [DataMember(Name = "total_amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total_amount")]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// The total number of failed payments.
        /// </summary>
        /// <value>The total number of failed payments.</value>
        [DataMember(Name = "total_payments_errored")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total_payments_errored")]
        public int? TotalPaymentsErrored { get; set; }

        /// <summary>
        /// The total number of payments processed.
        /// </summary>
        /// <value>The total number of payments processed.</value>
        [DataMember(Name = "total_payments_processed")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total_payments_processed")]
        public int? TotalPaymentsProcessed { get; set; }

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
            sb.Append("class PaymentSchedule {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  BillingDocument: ").Append(BillingDocument).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
            sb.Append("  PaymentGatewayId: ").Append(PaymentGatewayId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  PaymentScheduleNumber: ").Append(PaymentScheduleNumber).Append("\n");
            sb.Append("  RunHour: ").Append(RunHour).Append("\n");
            sb.Append("  Standalone: ").Append(Standalone).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  NextPaymentDate: ").Append(NextPaymentDate).Append("\n");
            sb.Append("  RecentPaymentDate: ").Append(RecentPaymentDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TotalPaymentsErrored: ").Append(TotalPaymentsErrored).Append("\n");
            sb.Append("  TotalPaymentsProcessed: ").Append(TotalPaymentsProcessed).Append("\n");
            sb.Append("  PaymentOptions: ").Append(PaymentOptions).Append("\n");
            sb.Append("  Prepayment: ").Append(Prepayment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}