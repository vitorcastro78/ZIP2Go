using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// The billing document settings for the customer.
    /// </summary>
    [DataContract]
    public class AllOfdebitMemoBillingDocumentSettings : FlexibleBillingDocumentSettings
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
            sb.Append("class AllOfdebitMemoBillingDocumentSettings {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}