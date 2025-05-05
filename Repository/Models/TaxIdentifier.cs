using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// An object that contains the VAT Identification number.
    /// </summary>
    [DataContract]
    public class TaxIdentifier
    {
        /// <summary>
        /// Value Added Tax (VAT) ID. Each VAT ID must begin with the code of the country code and followed by a block of digits or characters.
        /// </summary>
        /// <value>Value Added Tax (VAT) ID. Each VAT ID must begin with the code of the country code and followed by a block of digits or characters.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

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
            sb.Append("class TaxIdentifier {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}