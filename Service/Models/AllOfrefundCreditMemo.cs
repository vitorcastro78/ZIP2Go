using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// The related credit memo.
    /// </summary>
    [DataContract]
    public class AllOfrefundCreditMemo : RefundCreditMemoRequest
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
            sb.Append("class AllOfrefundCreditMemo {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}