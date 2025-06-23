using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// A reference to the consent agreement you have with your customer.
    /// </summary>
    [DataContract]
    public class AllOfcardMandateCustomerAcceptance : CustomerAcceptanceMandate
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
            sb.Append("class AllOfcardMandateCustomerAcceptance {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}