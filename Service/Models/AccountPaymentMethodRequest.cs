using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AccountPaymentMethodRequest
    {
        /// <summary>
        /// The customer account associated with this payment method.
        /// </summary>
        /// <value>The customer account associated with this payment method.</value>
        [DataMember(Name = "account")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account")]
        public AllOfaccountPaymentMethodRequestAccount Account { get; set; }

        /// <summary>
        /// A customer account identifier.
        /// </summary>
        /// <value>A customer account identifier.</value>
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets AchDebit
        /// </summary>
        [DataMember(Name = "ach_debit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ach_debit")]
        public AchDebit AchDebit { get; set; }

        /// <summary>
        /// Gets or Sets ApplePay
        /// </summary>
        [DataMember(Name = "apple_pay")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apple_pay")]
        public ApplePay ApplePay { get; set; }

        /// <summary>
        /// Gets or Sets AuBecsDebit
        /// </summary>
        [DataMember(Name = "au_becs_debit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "au_becs_debit")]
        public AuBecsDebit AuBecsDebit { get; set; }

        /// <summary>
        /// Gets or Sets AutogiroDebit
        /// </summary>
        [DataMember(Name = "autogiro_debit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "autogiro_debit")]
        public AutogiroDebit AutogiroDebit { get; set; }

        /// <summary>
        /// Gets or Sets BacsDebit
        /// </summary>
        [DataMember(Name = "bacs_debit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bacs_debit")]
        public BacsDebit BacsDebit { get; set; }

        /// <summary>
        /// The first six or eight digits of the payment method's number, such as the credit card number or account number. Banks use this number to identify a payment method.
        /// </summary>
        /// <value>The first six or eight digits of the payment method's number, such as the credit card number or account number. Banks use this number to identify a payment method.</value>
        [DataMember(Name = "bank_identification_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_identification_number")]
        public string BankIdentificationNumber { get; set; }

        /// <summary>
        /// Gets or Sets BetalingsDebit
        /// </summary>
        [DataMember(Name = "betalings_debit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "betalings_debit")]
        public BetalingsDebit BetalingsDebit { get; set; }

        /// <summary>
        /// Gets or Sets BillingDetails
        /// </summary>
        [DataMember(Name = "billing_details")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_details")]
        public BillingDetails BillingDetails { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "card")]
        public Card Card { get; set; }

        /// <summary>
        /// Gets or Sets CcRef
        /// </summary>
        [DataMember(Name = "cc_ref")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cc_ref")]
        public CcRef CcRef { get; set; }

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
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public OneOfaccountPaymentMethodRequestCustomObjects CustomObjects { get; set; }

        /// <summary>
        /// The custom type of the payment method from Universal Payment Connector.
        /// </summary>
        /// <value>The custom type of the payment method from Universal Payment Connector.</value>
        [DataMember(Name = "custom_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_type")]
        public string CustomType { get; set; }

        /// <summary>
        /// Identifier of the device browser session.
        /// </summary>
        /// <value>Identifier of the device browser session.</value>
        [DataMember(Name = "device_session_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "device_session_id")]
        public string DeviceSessionId { get; set; }

        /// <summary>
        /// Gets or Sets GooglePay
        /// </summary>
        [DataMember(Name = "google_pay")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "google_pay")]
        public GooglePay GooglePay { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The IP address from which the Mandate was accepted by the customer.
        /// </summary>
        /// <value>The IP address from which the Mandate was accepted by the customer.</value>
        [DataMember(Name = "ip_address")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Maximum number of consecutive failed retry payment attempts using this payment method before retries are stopped.
        /// </summary>
        /// <value>Maximum number of consecutive failed retry payment attempts using this payment method before retries are stopped.</value>
        [DataMember(Name = "maximum_payment_attempts")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximum_payment_attempts")]
        public decimal? MaximumPaymentAttempts { get; set; }

        /// <summary>
        /// Gets or Sets NzBecsDebit
        /// </summary>
        [DataMember(Name = "nz_becs_debit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nz_becs_debit")]
        public NzBecsDebit NzBecsDebit { get; set; }

        /// <summary>
        /// Gets or Sets PadDebit
        /// </summary>
        [DataMember(Name = "pad_debit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pad_debit")]
        public PadDebit PadDebit { get; set; }

        /// <summary>
        /// The retry interval in hours.
        /// </summary>
        /// <value>The retry interval in hours.</value>
        [DataMember(Name = "payment_retry_interval")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_retry_interval")]
        public int? PaymentRetryInterval { get; set; }

        /// <summary>
        /// Gets or Sets PaypalAdaptive
        /// </summary>
        [DataMember(Name = "paypal_adaptive")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paypal_adaptive")]
        public PaypalAdaptive PaypalAdaptive { get; set; }

        /// <summary>
        /// Gets or Sets PaypalExpress
        /// </summary>
        [DataMember(Name = "paypal_express")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paypal_express")]
        public PaypalExpress PaypalExpress { get; set; }

        /// <summary>
        /// Gets or Sets PaypalExpressNative
        /// </summary>
        [DataMember(Name = "paypal_express_native")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paypal_express_native")]
        public PaypalExpressNative PaypalExpressNative { get; set; }

        /// <summary>
        /// Gets or Sets SepaDebit
        /// </summary>
        [DataMember(Name = "sepa_debit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sepa_debit")]
        public SepaDebit SepaDebit { get; set; }

        /// <summary>
        /// The type of the payment method. An additional hash is included on the payment method with a name matching this value. It contains additional information specific to the payment method type.
        /// </summary>
        /// <value>The type of the payment method. An additional hash is included on the payment method with a name matching this value. It contains additional information specific to the payment method type.</value>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

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
            sb.Append("class AccountPaymentMethodRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CustomType: ").Append(CustomType).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  BillingDetails: ").Append(BillingDetails).Append("\n");
            sb.Append("  MaximumPaymentAttempts: ").Append(MaximumPaymentAttempts).Append("\n");
            sb.Append("  PaymentRetryInterval: ").Append(PaymentRetryInterval).Append("\n");
            sb.Append("  DeviceSessionId: ").Append(DeviceSessionId).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  BankIdentificationNumber: ").Append(BankIdentificationNumber).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  PaypalExpressNative: ").Append(PaypalExpressNative).Append("\n");
            sb.Append("  PaypalExpress: ").Append(PaypalExpress).Append("\n");
            sb.Append("  PaypalAdaptive: ").Append(PaypalAdaptive).Append("\n");
            sb.Append("  SepaDebit: ").Append(SepaDebit).Append("\n");
            sb.Append("  CcRef: ").Append(CcRef).Append("\n");
            sb.Append("  ApplePay: ").Append(ApplePay).Append("\n");
            sb.Append("  GooglePay: ").Append(GooglePay).Append("\n");
            sb.Append("  AchDebit: ").Append(AchDebit).Append("\n");
            sb.Append("  BetalingsDebit: ").Append(BetalingsDebit).Append("\n");
            sb.Append("  AutogiroDebit: ").Append(AutogiroDebit).Append("\n");
            sb.Append("  BacsDebit: ").Append(BacsDebit).Append("\n");
            sb.Append("  AuBecsDebit: ").Append(AuBecsDebit).Append("\n");
            sb.Append("  NzBecsDebit: ").Append(NzBecsDebit).Append("\n");
            sb.Append("  PadDebit: ").Append(PadDebit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}