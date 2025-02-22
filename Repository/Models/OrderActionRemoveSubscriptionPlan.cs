using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Specify this field to remove subscription plans from existing subscriptions.
    /// </summary>
    [DataContract]
    public class OrderActionRemoveSubscriptionPlan : SubscriptionRemovePlan
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
            sb.Append("class OrderActionRemoveSubscriptionPlan {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}