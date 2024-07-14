using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class QueryRunCreateRequest {
    /// <summary>
    /// The character used as delimiter to separate values in the output file.
    /// </summary>
    /// <value>The character used as delimiter to separate values in the output file.</value>
    [DataMember(Name="column_separator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column_separator")]
    public string ColumnSeparator { get; set; }

    /// <summary>
    /// If supplied, Zuora with compress the output file using the specified compression algorithm.
    /// </summary>
    /// <value>If supplied, Zuora with compress the output file using the specified compression algorithm.</value>
    [DataMember(Name="content_encoding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_encoding")]
    public string ContentEncoding { get; set; }

    /// <summary>
    /// Base64-encoded public key of a 1024-bit RSA key-pair. If you set this field, Zuora will encrypt the query results using the provided public key. You must use the corresponding private key to decrypt the query results.
    /// </summary>
    /// <value>Base64-encoded public key of a 1024-bit RSA key-pair. If you set this field, Zuora will encrypt the query results using the provided public key. You must use the corresponding private key to decrypt the query results.</value>
    [DataMember(Name="encryption_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encryption_key")]
    public string EncryptionKey { get; set; }

    /// <summary>
    /// The type of the file returned.
    /// </summary>
    /// <value>The type of the file returned.</value>
    [DataMember(Name="content_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_type")]
    public string ContentType { get; set; }

    /// <summary>
    /// The SQL statement of the query.
    /// </summary>
    /// <value>The SQL statement of the query.</value>
    [DataMember(Name="sql", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sql")]
    public string Sql { get; set; }

    /// <summary>
    /// If set to `true`, any deleted records are included in the response.
    /// </summary>
    /// <value>If set to `true`, any deleted records are included in the response.</value>
    [DataMember(Name="read_deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read_deleted")]
    public bool? ReadDeleted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QueryRunCreateRequest {\n");
      sb.Append("  ColumnSeparator: ").Append(ColumnSeparator).Append("\n");
      sb.Append("  ContentEncoding: ").Append(ContentEncoding).Append("\n");
      sb.Append("  EncryptionKey: ").Append(EncryptionKey).Append("\n");
      sb.Append("  ContentType: ").Append(ContentType).Append("\n");
      sb.Append("  Sql: ").Append(Sql).Append("\n");
      sb.Append("  ReadDeleted: ").Append(ReadDeleted).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
