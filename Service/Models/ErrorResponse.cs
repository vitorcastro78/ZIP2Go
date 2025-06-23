using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ErrorResponse
    {
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errors")]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Retryable
        /// </summary>
        [DataMember(Name = "retryable")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "retryable")]
        public bool? Retryable { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

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
            sb.Append("class ErrorResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Retryable: ").Append(Retryable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}