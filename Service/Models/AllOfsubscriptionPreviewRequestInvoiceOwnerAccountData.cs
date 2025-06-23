using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// The information of the new account that owns the invoice associated with this subscription. If you specify this field, do not specify &#x60;invoice_owner_account_id&#x60;.
    /// </summary>
    [DataContract]
    public class AllOfsubscriptionPreviewRequestInvoiceOwnerAccountData : AccountCreateRequest
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
            sb.Append("class AllOfsubscriptionPreviewRequestInvoiceOwnerAccountData {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}