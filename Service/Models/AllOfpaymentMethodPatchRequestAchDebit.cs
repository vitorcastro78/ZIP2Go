using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// If this is an ach_debit payment method, this hash contains details about the ACH debit bank account.
    /// </summary>
    [DataContract]
    public class AllOfpaymentMethodPatchRequestAchDebit : AchDebitUpdate
    {
        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
            sb.Append("class AllOfpaymentMethodPatchRequestAchDebit {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}