using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class OrderPreviewResponse
    {
        /// <summary>
        /// Gets or Sets BillingDocuments
        /// </summary>
        [DataMember(Name = "billing_documents")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_documents")]
        public List<AllOforderPreviewResponseBillingDocumentsItems> BillingDocuments { get; set; }

        /// <summary>
        /// The order line items on this order.
        /// </summary>
        /// <value>The order line items on this order.</value>
        [DataMember(Name = "line_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "line_items")]
        public List<AllOforderPreviewResponseLineItemsItems> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name = "subscriptions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptions")]
        public List<AllOforderPreviewResponseSubscriptionsItems> Subscriptions { get; set; }

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
            sb.Append("class OrderPreviewResponse {\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  BillingDocuments: ").Append(BillingDocuments).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}