using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PaymentTransactions
    {
        /// <summary>
        /// The payment transaction amount.
        /// </summary>
        /// <value>The payment transaction amount.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public List<string> Amount { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The number of the payment.
        /// </summary>
        /// <value>The number of the payment.</value>
        [DataMember(Name = "payment_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_number")]
        public string PaymentNumber { get; set; }

        /// <summary>
        /// The related payments.
        /// </summary>
        /// <value>The related payments.</value>
        [DataMember(Name = "payments")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payments")]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// The state of the payment.
        /// </summary>
        /// <value>The state of the payment.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public TransactionsState State { get; set; }

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
            sb.Append("class PaymentTransactions {\n");
            sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}