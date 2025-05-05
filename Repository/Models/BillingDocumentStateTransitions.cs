using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BillingDocumentStateTransitions
    {
        /// <summary>
        /// Gets or Sets CanceledTime
        /// </summary>
        [DataMember(Name = "canceled_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "canceled_time")]
        public string CanceledTime { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets PostedTime
        /// </summary>
        [DataMember(Name = "posted_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "posted_time")]
        public string PostedTime { get; set; }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            sb.Append("class AllOfbillingDocumentStateTransitions {\n");
            sb.Append("  PostedTime: ").Append(PostedTime).Append("\n");
            sb.Append("  CanceledTime: ").Append(CanceledTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}