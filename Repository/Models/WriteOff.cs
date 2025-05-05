using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WriteOff
    {
        /// <summary>
        /// The total billing document amount that is written off.
        /// </summary>
        /// <value>The total billing document amount that is written off.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public string Amount { get; set; }

        /// <summary>
        /// The credit memo number.
        /// </summary>
        /// <value>The credit memo number.</value>
        [DataMember(Name = "credit_memo_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo_number")]
        public string CreditMemoNumber { get; set; }

        /// <summary>
        /// Reasons for failure.
        /// </summary>
        /// <value>Reasons for failure.</value>
        [DataMember(Name = "failed_reason")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The related invoice.
        /// </summary>
        /// <value>The related invoice.</value>
        [DataMember(Name = "invoice")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice")]
        public Invoice Invoice { get; set; }

        /// <summary>
        /// The invoice number.
        /// </summary>
        /// <value>The invoice number.</value>
        [DataMember(Name = "invoice_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// The states of the transactions.
        /// </summary>
        /// <value>The states of the transactions.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public WriteOffState State { get; set; }

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
            sb.Append("class WriteOff {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FailedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CreditMemoNumber: ").Append(CreditMemoNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}