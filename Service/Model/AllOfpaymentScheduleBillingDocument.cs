using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The billing document with which the payment schedule is associated. Note: This field is optional. If you have the Standalone Payment feature enabled, you can leave this field blank and set standalone to true to create standalone payments. You can also choose to create unapplied payments by leaving this object blank and setting standalone to false. If Standalone Payment is not enabled, leaving this object unspecified will create unapplied payments.
  /// </summary>
  [DataContract]
  public class AllOfpaymentScheduleBillingDocument : PaymentScheduleBillingDocumentResponse {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AllOfpaymentScheduleBillingDocument {\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
