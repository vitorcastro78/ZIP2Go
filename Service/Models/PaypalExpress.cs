using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Models {

  /// <summary>
  /// If it is a &#x60;paypal_express&#x60; payment method, this hash contains details about the PayPal Express payment method.
  /// </summary>
  [DataContract]
  public class PaypalExpress {
    /// <summary>
    /// Identifier of a PayPal billing agreement. For example, I-1TJ3GAGG82Y9.
    /// </summary>
    /// <value>Identifier of a PayPal billing agreement. For example, I-1TJ3GAGG82Y9.</value>
    [DataMember(Name="baid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baid")]
    public string Baid { get; set; }

    /// <summary>
    /// Email address associated with the payment method
    /// </summary>
    /// <value>Email address associated with the payment method</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaypalExpress {\n");
      sb.Append("  Baid: ").Append(Baid).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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
