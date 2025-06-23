using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// The information of the new account that owns the subscription. The subscription owner account can be different from the invoice owner account. If you specify this field, do not specify &#x60;account_id&#x60;.
    /// </summary>
    [DataContract]
    public class AllOfpostSubscriptionOrderRequestAccountData : AccountCreateRequest
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
            sb.Append("class AllOfpostSubscriptionOrderRequestAccountData {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}