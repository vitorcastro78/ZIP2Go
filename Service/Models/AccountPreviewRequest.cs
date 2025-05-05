using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class AccountPreviewRequest
    {
        /// <summary>
        /// Any combination of one-time, recurring, and usage.
        /// </summary>
        /// <value>Any combination of one-time, recurring, and usage.</value>
        [DataMember(Name = "exclude")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exclude")]
        public string Exclude { get; set; }

        /// <summary>
        /// Indicates whether to include items in the draft status.
        /// </summary>
        /// <value>Indicates whether to include items in the draft status.</value>
        [DataMember(Name = "include_draft_items")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "include_draft_items")]
        public bool? IncludeDraftItems { get; set; }

        /// <summary>
        /// Indicates whether to include evergreen subscriptions.
        /// </summary>
        /// <value>Indicates whether to include evergreen subscriptions.</value>
        [DataMember(Name = "include_evergreen_subscriptions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "include_evergreen_subscriptions")]
        public bool? IncludeEvergreenSubscriptions { get; set; }

        /// <summary>
        /// The target date is used to determine which charges to bill. All unbilled charges as of or prior to the target date are included. Zuora automatically keeps track of all charges that need to be billed and that have not been billed prior to the target date.
        /// </summary>
        /// <value>The target date is used to determine which charges to bill. All unbilled charges as of or prior to the target date are included. Zuora automatically keeps track of all charges that need to be billed and that have not been billed prior to the target date.</value>
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
            sb.Append("class AccountPreviewRequest {\n");
            sb.Append("  Exclude: ").Append(Exclude).Append("\n");
            sb.Append("  IncludeDraftItems: ").Append(IncludeDraftItems).Append("\n");
            sb.Append("  IncludeEvergreenSubscriptions: ").Append(IncludeEvergreenSubscriptions).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}