using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// A new payment method for the account.
    /// </summary>
    [DataContract]
    public class AllOfaccountCreateRequestPaymentMethod : AccountPaymentMethodRequest
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
            sb.Append("class AllOfaccountCreateRequestPaymentMethod {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}