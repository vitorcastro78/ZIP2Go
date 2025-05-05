using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ResponseHeaders
    {
        /// <summary>
        /// The request limit quota for the time window closest to exhaustion. See [rate limits](https://developer.zuora.com/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.
        /// </summary>
        /// <value>The request limit quota for the time window closest to exhaustion. See [rate limits](https://developer.zuora.com/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.</value>
        [DataMember(Name = "ratelimit-limit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ratelimit-limit")]
        public string RatelimitLimit { get; set; }

        /// <summary>
        /// The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://developer.zuora.com/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.
        /// </summary>
        /// <value>The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://developer.zuora.com/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.</value>
        [DataMember(Name = "ratelimit-remaining")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ratelimit-remaining")]
        public decimal? RatelimitRemaining { get; set; }

        /// <summary>
        /// The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://developer.zuora.com/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.
        /// </summary>
        /// <value>The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://developer.zuora.com/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.</value>
        [DataMember(Name = "ratelimit-reset")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ratelimit-reset")]
        public decimal? RatelimitReset { get; set; }

        /// <summary>
        /// Zuora’s internal identifier for this request.
        /// </summary>
        /// <value>Zuora’s internal identifier for this request.</value>
        [DataMember(Name = "zuora-request-id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "zuora-request-id")]
        public string ZuoraRequestId { get; set; }

        /// <summary>
        /// A user-supplied identifier for this request. If you supply a `zuora-track-id` as a request header, Zuora returns the `zuora-track-id` as a response header.
        /// </summary>
        /// <value>A user-supplied identifier for this request. If you supply a `zuora-track-id` as a request header, Zuora returns the `zuora-track-id` as a response header. </value>
        [DataMember(Name = "zuora-track-id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "zuora-track-id")]
        public string ZuoraTrackId { get; set; }

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
            sb.Append("class ResponseHeaders {\n");
            sb.Append("  RatelimitLimit: ").Append(RatelimitLimit).Append("\n");
            sb.Append("  RatelimitRemaining: ").Append(RatelimitRemaining).Append("\n");
            sb.Append("  RatelimitReset: ").Append(RatelimitReset).Append("\n");
            sb.Append("  ZuoraRequestId: ").Append(ZuoraRequestId).Append("\n");
            sb.Append("  ZuoraTrackId: ").Append(ZuoraTrackId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}