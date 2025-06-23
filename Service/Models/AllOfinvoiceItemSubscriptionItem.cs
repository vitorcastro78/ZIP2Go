using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// The expandable subscription item associated with this billing document item.
    /// </summary>
    [DataContract]
    public class AllOfinvoiceItemSubscriptionItem : SubscriptionItem
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
            sb.Append("class AllOfinvoiceItemSubscriptionItem {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}