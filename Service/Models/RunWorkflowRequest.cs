using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class RunWorkflowRequest
    {
        /// <summary>
        /// Include parameters that you want to pass to the workflow. For the parameters to be recognized and picked up by tasks in the workflow, you need to define the parameters first.
        /// </summary>
        /// <value>Include parameters that you want to pass to the workflow. For the parameters to be recognized and picked up by tasks in the workflow, you need to define the parameters first.</value>
        [DataMember(Name = "input_parameters")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "input_parameters")]
        public Dictionary<string, Object> InputParameters { get; set; }

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
            sb.Append("class RunWorkflowRequest {\n");
            sb.Append("  InputParameters: ").Append(InputParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}