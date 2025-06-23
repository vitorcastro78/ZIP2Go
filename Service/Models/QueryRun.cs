using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    /// Query run information.
    /// </summary>
    [DataContract]
    public class QueryRun
    {
        /// <summary>
        /// The character used as delimiter to separate values in the output file.
        /// </summary>
        /// <value>The character used as delimiter to separate values in the output file.</value>
        [DataMember(Name = "column_separator")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "column_separator")]
        public string ColumnSeparator { get; set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object.
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object.</value>
        [DataMember(Name = "created_by_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "created_by_id")]
        public string CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "file")]
        public QueryRunFile File { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The number of rows in the output file.
        /// </summary>
        /// <value>The number of rows in the output file.</value>
        [DataMember(Name = "number_of_rows")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number_of_rows")]
        public decimal? NumberOfRows { get; set; }

        /// <summary>
        /// The time taken to process the query in milliseconds.
        /// </summary>
        /// <value>The time taken to process the query in milliseconds.</value>
        [DataMember(Name = "processing_duration")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processing_duration")]
        public decimal? ProcessingDuration { get; set; }

        /// <summary>
        /// The remaining number of times Zuora will attempt the query before terminating the query and setting the state to `failed`.
        /// </summary>
        /// <value>The remaining number of times Zuora will attempt the query before terminating the query and setting the state to `failed`.</value>
        [DataMember(Name = "remaining_attempts")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remaining_attempts")]
        public decimal? RemainingAttempts { get; set; }

        /// <summary>
        /// The SQL statement of the query.
        /// </summary>
        /// <value>The SQL statement of the query.</value>
        [DataMember(Name = "sql")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sql")]
        public string Sql { get; set; }

        /// <summary>
        /// The query's execution state, which will be completed for successful runs.
        /// </summary>
        /// <value>The query's execution state, which will be completed for successful runs.</value>
        [DataMember(Name = "state")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO-8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO-8601 UTC format.</value>
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
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRun {\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sql: ").Append(Sql).Append("\n");
            sb.Append("  RemainingAttempts: ").Append(RemainingAttempts).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  NumberOfRows: ").Append(NumberOfRows).Append("\n");
            sb.Append("  ProcessingDuration: ").Append(ProcessingDuration).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ColumnSeparator: ").Append(ColumnSeparator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}