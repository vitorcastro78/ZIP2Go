using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentScheduleItemPatch
    {
        /// <summary>
        /// The amount to be collected by this payment schedule item.
        /// </summary>
        /// <value>The amount to be collected by this payment schedule item.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Currency of the payment schedule. The default value is the account's default currency. This field will be ignored when items is specified.
        /// </summary>
        /// <value>Currency of the payment schedule. The default value is the account's default currency. This field will be ignored when items is specified.</value>
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
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "link")]
        public List<PaymentScheduleItemLink> Link { get; set; }

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
        /// Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the `gateway_options` type is supported. Payment schedule `payment_options` take precedence over payment schedule item `payment_options`.
        /// </summary>
        /// <value>Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the `gateway_options` type is supported. Payment schedule `payment_options` take precedence over payment schedule item `payment_options`.</value>
        [DataMember(Name = "payment_options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_options")]
        public List<PaymentScheduleItemPaymentOption> PaymentOptions { get; set; }

        /// <summary>
        /// ID of the payment schedule.
        /// </summary>
        /// <value>ID of the payment schedule.</value>
        [DataMember(Name = "payment_schedule_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_schedule_id")]
        public string PaymentScheduleId { get; set; }

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
        /// Gets or Sets Unlink
        /// </summary>
        [DataMember(Name = "unlink")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unlink")]
        public List<PaymentScheduleItemUnlink> Unlink { get; set; }

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
            sb.Append("class PaymentScheduleItemPatch {\n");
            sb.Append("  PaymentScheduleId: ").Append(PaymentScheduleId).Append("\n");
            sb.Append("  PaymentScheduleNumber: ").Append(PaymentScheduleNumber).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PaymentGatewayId: ").Append(PaymentGatewayId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  RunHour: ").Append(RunHour).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  PaymentOptions: ").Append(PaymentOptions).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Unlink: ").Append(Unlink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}