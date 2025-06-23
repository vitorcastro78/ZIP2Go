using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Identifier of the account that owns the subscription.
    /// </summary>
    [DataContract]
    public class AllOfsubscriptionCancelResponseInvoiceOwnerAccount : Account
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
            sb.Append("class AllOfsubscriptionCancelResponseInvoiceOwnerAccount {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}