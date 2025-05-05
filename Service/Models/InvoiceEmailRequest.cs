using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class InvoiceEmailRequest
    {
        /// <summary>
        /// An arbitrary list of comma-separated email addresses. Note: this parameter will be ignored if use_email_template is true.
        /// </summary>
        /// <value>An arbitrary list of comma-separated email addresses. Note: this parameter will be ignored if use_email_template is true.</value>
        [DataMember(Name = "email")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Indicates whether to email an invoice based on your email template settings. If you set this field to true, the invoice is sent to the email addresses specified in the To Email field of the email template.
        /// </summary>
        /// <value>Indicates whether to email an invoice based on your email template settings. If you set this field to true, the invoice is sent to the email addresses specified in the To Email field of the email template.</value>
        [DataMember(Name = "use_email_template")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "use_email_template")]
        public bool? UseEmailTemplate { get; set; }

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
            sb.Append("class InvoiceEmailRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  UseEmailTemplate: ").Append(UseEmailTemplate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}