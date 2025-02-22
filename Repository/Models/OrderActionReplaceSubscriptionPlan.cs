using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Specify this field to replace existing subscription plans with new plans.
    /// </summary>
    [DataContract]
    public class OrderActionReplaceSubscriptionPlan : SubscriptionReplacePlan
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
            sb.Append("class AllOforderActionReplaceSubscriptionPlan {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}