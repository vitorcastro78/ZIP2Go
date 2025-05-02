using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
    /// </summary>
    [DataContract]
    public class CustomFields : Dictionary<string, Object>
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
            sb.Append("class CustomFields {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}