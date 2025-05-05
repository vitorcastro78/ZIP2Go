using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// If the &#x60;type&#x60; of the payment method is &#x60;nz_becs_debit&#x60;, this hash contains details about the BECS-NZ bank account.
    /// </summary>
    [DataContract]
    public class NzBecsDebit
    {
        /// <summary>
        /// The bank account number of the account holder.
        /// </summary>
        /// <value>The bank account number of the account holder.</value>
        [DataMember(Name = "account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Identifier of the bank associated with this bank account.
        /// </summary>
        /// <value>Identifier of the bank associated with this bank account.</value>
        [DataMember(Name = "bank_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Identifier of the bank branch associated with this bank account.
        /// </summary>
        /// <value>Identifier of the bank branch associated with this bank account.</value>
        [DataMember(Name = "branch_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name = "mandate")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mandate")]
        public Mandate Mandate { get; set; }

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
            sb.Append("class NzBecsDebit {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}