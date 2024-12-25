using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ZIP2Go.Models {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SubscriptionPreviewActionsResponse {
    /// <summary>
    /// Identifier of the action.
    /// </summary>
    /// <value>Identifier of the action.</value>
    [DataMember(Name="action_id", EmitDefaultValue=false)]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action_id")]
    public string ActionId { get; set; }

    /// <summary>
    /// The action associated with this metric.
    /// </summary>
    /// <value>The action associated with this metric.</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// The sequence number of the action.
    /// </summary>
    /// <value>The sequence number of the action.</value>
    [DataMember(Name="sequence", EmitDefaultValue=false)]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sequence")]
    public int? Sequence { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionItems
    /// </summary>
    [DataMember(Name="subscription_items", EmitDefaultValue=false)]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_items")]
    public List<AllOfsubscriptionPreviewActionsResponseSubscriptionItemsItems> SubscriptionItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionPreviewActionsResponse {\n");
      sb.Append("  ActionId: ").Append(ActionId).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  Sequence: ").Append(Sequence).Append("\n");
      sb.Append("  SubscriptionItems: ").Append(SubscriptionItems).Append("\n");
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
