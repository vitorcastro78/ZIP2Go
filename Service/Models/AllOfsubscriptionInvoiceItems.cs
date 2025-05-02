using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// List of invoice items.
    /// </summary>
    [DataContract]
    public class AllOfsubscriptionInvoiceItems : InvoiceItemListResponse
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
            sb.Append("class AllOfsubscriptionInvoiceItems {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}