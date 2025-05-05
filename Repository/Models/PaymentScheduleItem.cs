using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentScheduleItem
    {
        /// <summary>
        /// Unique identifier of the customer account the payment schedule belongs to.
        /// </summary>
        /// <value>Unique identifier of the customer account the payment schedule belongs to.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// The amount to be collected by this payment schedule item.
        /// </summary>
        /// <value>The amount to be collected by this payment schedule item.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The remaining balance of payment schedule item.
        /// </summary>
        /// <value>The remaining balance of payment schedule item.</value>
        [DataMember(Name = "balance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "balance")]
        public decimal? Balance { get; set; }

        /// <summary>
        /// The billing document with which the payment schedule is associated. If you have the Standalone Payment feature enabled, you can leave this field blank and set standalone to true to create standalone payments. You can also choose to create unapplied payments by leaving this object blank and setting standalone to false. If Standalone Payment is not enabled, leaving this object unspecified will create unapplied payments.
        /// </summary>
        /// <value>The billing document with which the payment schedule is associated. If you have the Standalone Payment feature enabled, you can leave this field blank and set standalone to true to create standalone payments. You can also choose to create unapplied payments by leaving this object blank and setting standalone to false. If Standalone Payment is not enabled, leaving this object unspecified will create unapplied payments.</value>
        [DataMember(Name = "billing_document")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_document")]
        public BillingDocument BillingDocument { get; set; }

        /// <summary>
        /// The reason for the cancellation of payment schedule item.
        /// </summary>
        /// <value>The reason for the cancellation of payment schedule item.</value>
        [DataMember(Name = "cancellation_reason")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancellation_reason")]
        public string CancellationReason { get; set; }

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
        /// Currency of the payment schedule. The default value is the account's default currency. This field will be ignored when items is specified.
        /// </summary>
        /// <value>Currency of the payment schedule. The default value is the account's default currency. This field will be ignored when items is specified.</value>
        [DataMember(Name = "currency")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// An error message indicating why payment collection failed for this payment schedule item.
        /// </summary>
        /// <value>An error message indicating why payment collection failed for this payment schedule item.</value>
        [DataMember(Name = "error_message")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// List of customer payments.
        /// </summary>
        /// <value>List of customer payments.</value>
        [DataMember(Name = "payment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment")]
        public Payment Payment { get; set; }

        /// <summary>
        /// ID of the payment gateway used to collect payments. The default value is the account's default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant's default payment gateway ID. This field will be ignored when `items` is specified.
        /// </summary>
        /// <value>ID of the payment gateway used to collect payments. The default value is the account's default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant's default payment gateway ID. This field will be ignored when `items` is specified.</value>
        [DataMember(Name = "payment_gateway_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_gateway_id")]
        public string PaymentGatewayId { get; set; }

        /// <summary>
        /// ID of the payment method. The default value is the account's default payment method ID. This field will be ignored when `items` is specified.
        /// </summary>
        /// <value>ID of the payment method. The default value is the account's default payment method ID. This field will be ignored when `items` is specified.</value>
        [DataMember(Name = "payment_method_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method_id")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// ID of the payment option.
        /// </summary>
        /// <value>ID of the payment option.</value>
        [DataMember(Name = "payment_option_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_option_id")]
        public string PaymentOptionId { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name = "payments")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payments")]
        public List<PaymentScheduleItemPayments> Payments { get; set; }

        /// <summary>
        /// Payment schedule record.
        /// </summary>
        /// <value>Payment schedule record.</value>
        [DataMember(Name = "payment_schedule")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_schedule")]
        public PaymentSchedule PaymentSchedule { get; set; }

        /// <summary>
        /// ID of the payment schedule.
        /// </summary>
        /// <value>ID of the payment schedule.</value>
        [DataMember(Name = "payment_schedule_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_schedule_id")]
        public string PaymentScheduleId { get; set; }

        /// <summary>
        /// Number of the payment schedule item.
        /// </summary>
        /// <value>Number of the payment schedule item.</value>
        [DataMember(Name = "payment_schedule_item_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_schedule_item_number")]
        public string PaymentScheduleItemNumber { get; set; }

        /// <summary>
        /// Number of the payment schedule.
        /// </summary>
        /// <value>Number of the payment schedule.</value>
        [DataMember(Name = "payment_schedule_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_schedule_number")]
        public string PaymentScheduleNumber { get; set; }

        /// <summary>
        /// At which hour in the day in the tenant's timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenant’s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs.
        /// </summary>
        /// <value>At which hour in the day in the tenant's timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenant’s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs.</value>
        [DataMember(Name = "run_hour")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "run_hour")]
        public int? RunHour { get; set; }

        /// <summary>
        /// The scheduled date of collection.
        /// </summary>
        /// <value>The scheduled date of collection.</value>
        [DataMember(Name = "scheduled_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduled_date")]
        public DateTime? ScheduledDate { get; set; }

        /// <summary>
        /// Indicates whether the payments created by the payment schedule are standalone payments or not. When setting to true, standalone payments will be created. When setting to false, you can either specify a billing document, or not specifying any billing documents. In the later case, unapplied payments will be created. If set to null, standalone payments will be created. Note: This parameter is only available if standalone payments are enabled in your tenant. Do not include this parameter if standalone payment have not been enabled in your tenant. If standalone payments are enabled, the default value is true.
        /// </summary>
        /// <value>Indicates whether the payments created by the payment schedule are standalone payments or not. When setting to true, standalone payments will be created. When setting to false, you can either specify a billing document, or not specifying any billing documents. In the later case, unapplied payments will be created. If set to null, standalone payments will be created. Note: This parameter is only available if standalone payments are enabled in your tenant. Do not include this parameter if standalone payment have not been enabled in your tenant. If standalone payments are enabled, the default value is true.</value>
        [DataMember(Name = "standalone")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "standalone")]
        public bool? Standalone { get; set; }

        /// <summary>
        /// The status of the payment schedule item. active: there are unprocessed payment schedule items. canceled: the payment schedule has been canceled. complete: the payment schedule is complete and all items have been processed.
        /// </summary>
        /// <value>The status of the payment schedule item. active: there are unprocessed payment schedule items. canceled: the payment schedule has been canceled. complete: the payment schedule is complete and all items have been processed.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

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
            sb.Append("class PaymentScheduleItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  BillingDocument: ").Append(BillingDocument).Append("\n");
            sb.Append("  CancellationReason: ").Append(CancellationReason).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PaymentScheduleItemNumber: ").Append(PaymentScheduleItemNumber).Append("\n");
            sb.Append("  PaymentGatewayId: ").Append(PaymentGatewayId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  PaymentOptionId: ").Append(PaymentOptionId).Append("\n");
            sb.Append("  PaymentScheduleId: ").Append(PaymentScheduleId).Append("\n");
            sb.Append("  PaymentScheduleNumber: ").Append(PaymentScheduleNumber).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  RunHour: ").Append(RunHour).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  Standalone: ").Append(Standalone).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  PaymentSchedule: ").Append(PaymentSchedule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}