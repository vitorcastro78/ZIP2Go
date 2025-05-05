using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BillRunPreview
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
        /// Human-readable identifier for this object.
        /// </summary>
        /// <value>Human-readable identifier for this object.</value>
        [DataMember(Name = "billing_preview_run_number")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_preview_run_number")]
        public string BillingPreviewRunNumber { get; set; }

        /// <summary>
        /// Charge type or types to be excluded from this bill run preview.
        /// </summary>
        /// <value>Charge type or types to be excluded from this bill run preview.</value>
        [DataMember(Name = "charges_excluded")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "charges_excluded")]
        public List<string> ChargesExcluded { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public string CreatedById { get; set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// The custom objects associated with a Zuora standard object.
        /// </summary>
        /// <value>The custom objects associated with a Zuora standard object.</value>
        [DataMember(Name = "custom_objects")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_objects")]
        public CustomObject CustomObjects { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "file")]
        public BillRunPreviewFile File { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

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
        /// The number of the customer accounts included in the bill run preview job.
        /// </summary>
        /// <value>The number of the customer accounts included in the bill run preview job.</value>
        [DataMember(Name = "number_of_accounts")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_accounts")]
        public decimal? NumberOfAccounts { get; set; }

        /// <summary>
        /// The number of the customer accounts whose bill run preview job succeeded.
        /// </summary>
        /// <value>The number of the customer accounts whose bill run preview job succeeded.</value>
        [DataMember(Name = "number_of_accounts_succeeded")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_accounts_succeeded")]
        public decimal? NumberOfAccountsSucceeded { get; set; }

        /// <summary>
        /// The state of the bill run preview.
        /// </summary>
        /// <value>The state of the bill run preview.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StateTransitions
        /// </summary>
        [DataMember(Name = "state_transitions")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state_transitions")]
        public BillRunPreviewStateTransitions StateTransitions { get; set; }

        /// <summary>
        /// All unbilled items on or before this date are included in this bill run.
        /// </summary>
        /// <value>All unbilled items on or before this date are included in this bill run.</value>
        [DataMember(Name = "target_date")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target_date")]
        public DateTime? TargetDate { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name = "updated_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_by_id")]
        public string UpdatedById { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name = "updated_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updated_time")]
        public DateTime? UpdatedTime { get; set; }

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
            sb.Append("class BillRunPreview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedById: ").Append(UpdatedById).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("  AssumeRenewal: ").Append(AssumeRenewal).Append("\n");
            sb.Append("  Batches: ").Append(Batches).Append("\n");
            sb.Append("  ChargesExcluded: ").Append(ChargesExcluded).Append("\n");
            sb.Append("  IncludeDraftItems: ").Append(IncludeDraftItems).Append("\n");
            sb.Append("  IncludeEvergreenSubscriptions: ").Append(IncludeEvergreenSubscriptions).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  StateTransitions: ").Append(StateTransitions).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  BillingPreviewRunNumber: ").Append(BillingPreviewRunNumber).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  NumberOfAccountsSucceeded: ").Append(NumberOfAccountsSucceeded).Append("\n");
            sb.Append("  NumberOfAccounts: ").Append(NumberOfAccounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}