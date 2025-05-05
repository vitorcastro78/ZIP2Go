using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WorkflowRun
    {
        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "created_time")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The unique ID of an active version.
        /// </summary>
        /// <value>The unique ID of an active version.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the workflow definition.
        /// </summary>
        /// <value>The name of the workflow definition.</value>
        [DataMember(Name = "name")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Identifier of the original Workflow version.
        /// </summary>
        /// <value>Identifier of the original Workflow version.</value>
        [DataMember(Name = "original_workflow_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "original_workflow_id")]
        public int? OriginalWorkflowId { get; set; }

        /// <summary>
        /// The status of an active version.
        /// </summary>
        /// <value>The status of an active version.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// The type of the active version. Currently the only valid value is `Workflow::Setup`.
        /// </summary>
        /// <value>The type of the active version. Currently the only valid value is `Workflow::Setup`.</value>
        [DataMember(Name = "type")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedTime
        /// </summary>
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
            sb.Append("class WorkflowRun {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  OriginalWorkflowId: ").Append(OriginalWorkflowId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}