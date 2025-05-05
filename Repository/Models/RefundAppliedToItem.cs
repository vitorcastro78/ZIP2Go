using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class RefundAppliedToItem
    {
        /// <summary>
        /// The amount of the payment that is applied to the specific billing document item.
        /// </summary>
        /// <value>The amount of the payment that is applied to the specific billing document item.</value>
        [DataMember(Name = "amount")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Identifier of an invoice or a debit memo item.
        /// </summary>
        /// <value>Identifier of an invoice or a debit memo item.</value>
        [DataMember(Name = "credit_memo_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_memo_item_id")]
        public string CreditMemoItemId { get; set; }

        /// <summary>
        /// Identifier of the payment application item.
        /// </summary>
        /// <value>Identifier of the payment application item.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Identifier of a taxation item.
        /// </summary>
        /// <value>Identifier of a taxation item.</value>
        [DataMember(Name = "taxation_item_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxation_item_id")]
        public string TaxationItemId { get; set; }

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
            sb.Append("class RefundAppliedToItemResponse {\n");
            sb.Append("  CreditMemoItemId: ").Append(CreditMemoItemId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TaxationItemId: ").Append(TaxationItemId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}