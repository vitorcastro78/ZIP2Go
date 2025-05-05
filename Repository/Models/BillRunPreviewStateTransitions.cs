using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// The timestamps at which the object&#x27;s state was updated.
    /// </summary>
    [DataContract]
    public class BillRunPreviewStateTransitions
    {
        /// <summary>
        /// The time when the bill run preview completed.
        /// </summary>
        /// <value>The time when the bill run preview completed.</value>
        [DataMember(Name = "complete_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complete_time")]
        public DateTime? CompleteTime { get; set; }

        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The time when the bill run preview started.
        /// </summary>
        /// <value>The time when the bill run preview started.</value>
        [DataMember(Name = "processing_start_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processing_start_time")]
        public DateTime? ProcessingStartTime { get; set; }

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
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillRunPreviewStateTransitions {\n");
            sb.Append("  CompleteTime: ").Append(CompleteTime).Append("\n");
            sb.Append("  ProcessingStartTime: ").Append(ProcessingStartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}