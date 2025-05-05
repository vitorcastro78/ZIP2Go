using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// The file object representing the results of the query.
    /// </summary>
    [DataContract]
    public class QueryRunFile
    {
        /// <summary>
        /// The type of the file returned.
        /// </summary>
        /// <value>The type of the file returned.</value>
        [DataMember(Name = "content_type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The type of file.
        /// </summary>
        /// <value>The type of file.</value>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The URL from which the file can be downloaded
        /// </summary>
        /// <value>The URL from which the file can be downloaded</value>
        [DataMember(Name = "url")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "url")]
        public string Url { get; set; }

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
            sb.Append("class QueryRunFile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}