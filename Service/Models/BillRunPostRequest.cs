using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BillRunPostRequest
    {
        /// <summary>
        /// The date printed on the invoice.
        /// </summary>
        /// <value>The date printed on the invoice.</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_date")]
        public DateTime? InvoiceDate { get; set; }

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
            sb.Append("class BillRunPostRequest {\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}