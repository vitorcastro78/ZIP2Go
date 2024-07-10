using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LineItemsPreviewResponseMrr {
    /// <summary>
    /// Gets or Sets GrossAmount
    /// </summary>
    [DataMember(Name="gross_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gross_amount")]
    public decimal? GrossAmount { get; set; }

    /// <summary>
    /// Gets or Sets NetAmount
    /// </summary>
    [DataMember(Name="net_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "net_amount")]
    public decimal? NetAmount { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LineItemsPreviewResponseMrr {\n");
      sb.Append("  GrossAmount: ").Append(GrossAmount).Append("\n");
      sb.Append("  NetAmount: ").Append(NetAmount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
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
