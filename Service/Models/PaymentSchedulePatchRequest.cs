using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentSchedulePatchRequest
    {
        /// <summary>
        /// The amount of each payment schedule item in the payment schedule.
        /// </summary>
        /// <value>The amount of each payment schedule item in the payment schedule.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

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
        /// Unit in which term duration is defined. One of week or month.
        /// </summary>
        /// <value>Unit in which term duration is defined. One of week or month.</value>
        [DataMember(Name = "period")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "period")]
        public string Period { get; set; }

        /// <summary>
        /// At which hour in the day in the tenant's timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenant’s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time.       The default value is `0`. If the payment `run_hour` and `scheduled_date` are backdated, the system will collect the payment when the next `run_hour` occurs.
        /// </summary>
        /// <value>At which hour in the day in the tenant's timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenant’s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time.       The default value is `0`. If the payment `run_hour` and `scheduled_date` are backdated, the system will collect the payment when the next `run_hour` occurs.</value>
        [DataMember(Name = "run_hour")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "run_hour")]
        public int? RunHour { get; set; }

        /// <summary>
        /// The date of the first scheduled payment collection. Note: This parameter is required when `items` is not specified. This parameter will be ignored when `items` is specified.
        /// </summary>
        /// <value>The date of the first scheduled payment collection. Note: This parameter is required when `items` is not specified. This parameter will be ignored when `items` is specified.</value>
        [DataMember(Name = "start_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

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
            sb.Append("class PaymentSchedulePatchRequest {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
            sb.Append("  PaymentGatewayId: ").Append(PaymentGatewayId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  PaymentMethodNumber: ").Append(PaymentMethodNumber).Append("\n");
            sb.Append("  RunHour: ").Append(RunHour).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  PaymentOptions: ").Append(PaymentOptions).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}