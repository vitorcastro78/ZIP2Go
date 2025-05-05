using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// File containing the results of the bill run preview.
    /// </summary>
    [DataContract]
    public class BillRunPreviewFile
    {
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The URL from which a zipped CSV file may be downloaded. This file contains the preview invoice item data and credit memo item data for the specified customer accounts.
        /// </summary>
        /// <value>The URL from which a zipped CSV file may be downloaded. This file contains the preview invoice item data and credit memo item data for the specified customer accounts.</value>
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
            sb.Append("class BillRunPreviewFile {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}