using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// If the &#x60;type&#x60; of the payment method is &#x60;ach_debit&#x60;, this hash contains details about the ACH bank account.
    /// </summary>
    [DataContract]
    public class AchDebit
    {
        /// <summary>
        /// The nine-digit routing number or ABA number used by banks.
        /// </summary>
        /// <value>The nine-digit routing number or ABA number used by banks.</value>
        [DataMember(Name = "bank_aba_code")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_aba_code")]
        public string BankAbaCode { get; set; }

        /// <summary>
        /// The name of the account holder, which can be either a person or a company.
        /// </summary>
        /// <value>The name of the account holder, which can be either a person or a company.</value>
        [DataMember(Name = "bank_account_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_account_name")]
        public string BankAccountName { get; set; }

        /// <summary>
        /// The bank account number of the account holder.
        /// </summary>
        /// <value>The bank account number of the account holder.</value>
        [DataMember(Name = "bank_account_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_account_number")]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The type of bank account associated with the payment method.
        /// </summary>
        /// <value>The type of bank account associated with the payment method.</value>
        [DataMember(Name = "bank_account_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// Name of the bank associated with this bank account.
        /// </summary>
        /// <value>Name of the bank associated with this bank account.</value>
        [DataMember(Name = "bank_name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_name")]
        public string BankName { get; set; }

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
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AchDebit {\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("  BankAbaCode: ").Append(BankAbaCode).Append("\n");
            sb.Append("  BankAccountName: ").Append(BankAccountName).Append("\n");
            sb.Append("  BankAccountType: ").Append(BankAccountType).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}