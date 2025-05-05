using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Headers
    {
        /// <summary>
        /// Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).
        /// </summary>
        /// <value>Include a `accept-encoding: gzip` header to compress responses, which can reduce the bandwidth required for a response. If specified, Zuora automatically compresses responses that contain over 1000 bytes. For more information about this header, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</value>
        [DataMember(Name = "accept-encoding")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accept-encoding")]
        public string AcceptEncoding { get; set; }

        /// <summary>
        /// Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora's infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.
        /// </summary>
        /// <value>Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora's infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</value>
        [DataMember(Name = "async")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "async")]
        public bool? Async { get; set; }

        /// <summary>
        /// Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).
        /// </summary>
        /// <value>Include a `content-encoding: gzip` header to compress a request. Upload a gzipped file for the payload if you specify this header. For more information, see [Request and Response Compression](https://developer.zuora.com/api-references/quickstart-api/tag/Request-and-Response-Compression/).</value>
        [DataMember(Name = "content-encoding")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content-encoding")]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).
        /// </summary>
        /// <value>Specify a unique idempotency key if you want to perform an idempotent POST or PATCH request. Do not use this header in other request types. This idempotency key should be a unique value, and the Zuora server identifies subsequent retries of the same request using this value. For more information, see [Idempotent Requests](https://developer.zuora.com/api-references/quickstart-api/tag/Idempotent-Requests/).</value>
        [DataMember(Name = "idempotency-key")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "idempotency-key")]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header.
        /// </summary>
        /// <value>An entity ID. If you have multi-entity enabled and the authorization token is valid for more than one entity, you must use this header to specify which entity to perform the operation on. If the authorization token is only valid for a single entity, or you do not have multi-entity enabled, you do not need to set this header.</value>
        [DataMember(Name = "zuora-entity-id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "zuora-entity-id")]
        public string ZuoraEntityId { get; set; }

        /// <summary>
        /// A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote (').
        /// </summary>
        /// <value>A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\"), or quote (').</value>
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
            sb.Append("class Headers {\n");
            sb.Append("  ZuoraTrackId: ").Append(ZuoraTrackId).Append("\n");
            sb.Append("  Async: ").Append(Async).Append("\n");
            sb.Append("  ZuoraEntityId: ").Append(ZuoraEntityId).Append("\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  AcceptEncoding: ").Append(AcceptEncoding).Append("\n");
            sb.Append("  ContentEncoding: ").Append(ContentEncoding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}