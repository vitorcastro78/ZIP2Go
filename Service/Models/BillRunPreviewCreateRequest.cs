using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BillRunPreviewCreateRequest
    {
        /// <summary>
        /// Indicates whether to generate a preview of future invoice items and credit memo items with the assumption that the subscriptions are renewed. **all**: The assumption is applied to all the subscriptions. Zuora generates preview invoice item data and credit memo item data from the first day of the customer's next billing period to the target date. **auto_renew_only**: The assumption is applied to the subscriptions that have auto_renew enabled. Zuora generates preview invoice item data and credit memo item data from the first day of the customer's next billing period to the target date.
        /// </summary>
        /// <value>Indicates whether to generate a preview of future invoice items and credit memo items with the assumption that the subscriptions are renewed. **all**: The assumption is applied to all the subscriptions. Zuora generates preview invoice item data and credit memo item data from the first day of the customer's next billing period to the target date. **auto_renew_only**: The assumption is applied to the subscriptions that have auto_renew enabled. Zuora generates preview invoice item data and credit memo item data from the first day of the customer's next billing period to the target date.</value>
        [DataMember(Name = "assume_renewal")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assume_renewal")]
        public string AssumeRenewal { get; set; }

        /// <summary>
        /// Identifiers of the customer account batches to be included in this bill run preview.
        /// </summary>
        /// <value>Identifiers of the customer account batches to be included in this bill run preview.</value>
        [DataMember(Name = "batches")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "batches")]
        public List<string> Batches { get; set; }

        /// <summary>
        /// Charge type or types to be excluded from this bill run preview.
        /// </summary>
        /// <value>Charge type or types to be excluded from this bill run preview.</value>
        [DataMember(Name = "charges_excluded")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "charges_excluded")]
        public List<string> ChargesExcluded { get; set; }

        /// <summary>
        /// If true, draft items will be included in this bill run preview.
        /// </summary>
        /// <value>If true, draft items will be included in this bill run preview.</value>
        [DataMember(Name = "include_draft_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "include_draft_items")]
        public bool? IncludeDraftItems { get; set; }

        /// <summary>
        /// If true, evergreen subscriptions will be included in this bill run preview.
        /// </summary>
        /// <value>If true, evergreen subscriptions will be included in this bill run preview.</value>
        [DataMember(Name = "include_evergreen_subscriptions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "include_evergreen_subscriptions")]
        public bool? IncludeEvergreenSubscriptions { get; set; }

        /// <summary>
        /// All unbilled items on or before this date are included in this bill run.
        /// </summary>
        /// <value>All unbilled items on or before this date are included in this bill run.</value>
        [DataMember(Name = "target_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target_date")]
        public DateTime? TargetDate { get; set; }

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
            sb.Append("class BillRunPreviewCreateRequest {\n");
            sb.Append("  AssumeRenewal: ").Append(AssumeRenewal).Append("\n");
            sb.Append("  Batches: ").Append(Batches).Append("\n");
            sb.Append("  ChargesExcluded: ").Append(ChargesExcluded).Append("\n");
            sb.Append("  IncludeDraftItems: ").Append(IncludeDraftItems).Append("\n");
            sb.Append("  IncludeEvergreenSubscriptions: ").Append(IncludeEvergreenSubscriptions).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}