using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Credit Card Reference Transaction. See Supported payment methods for payment gateways that support this type of payment method.
    /// </summary>
    [DataContract]
    public class AllOfpaymentMethodPatchRequestCcRef : CcRefUpdate
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
            sb.Append("class AllOfpaymentMethodPatchRequestCcRef {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}