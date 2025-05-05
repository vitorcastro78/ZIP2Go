using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class RefundCreditMemoRequest
    {
        /// <summary>
        /// Refund amount.
        /// </summary>
        /// <value>Refund amount.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The items to which the credit memo is applied.
        /// </summary>
        /// <value>The items to which the credit memo is applied.</value>
        [DataMember(Name = "credit_memo_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo_items")]
        public List<RefundCreditMemoItemRequest> CreditMemoItems { get; set; }

        /// <summary>
        /// Identifier of the credit memo taxation item
        /// </summary>
        /// <value>Identifier of the credit memo taxation item</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The items to which the credit memo is applied.
        /// </summary>
        /// <value>The items to which the credit memo is applied.</value>
        [DataMember(Name = "taxation_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxation_items")]
        public List<RefundCreditMemoItemRequest> TaxationItems { get; set; }

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
            sb.Append("class RefundCreditMemoRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreditMemoItems: ").Append(CreditMemoItems).Append("\n");
            sb.Append("  TaxationItems: ").Append(TaxationItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}