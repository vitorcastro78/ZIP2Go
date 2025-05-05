using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace ZIP2GO.Repository.Models
{
    /// <summary>
    /// Container for the contract effective, service activation, and customer acceptance dates of the order action or subscription.  &lt;ul&gt;  &lt;li&gt; If [Zuora is configured to require service activation](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) and the &#x60;service_activation&#x60; field is not set for a &#x60;subscription_plans&#x60; order action or the \&quot;Create a subscription\&quot; operation, a &#x60;pending&#x60; order and/or a &#x60;pending_activation&#x60; subscription are created.&lt;/li&gt;   &lt;li&gt; If [Zuora is configured to require customer acceptance](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Customer_Acceptance_of_Orders.3F) and the &#x60;customer_acceptance&#x60; field is not set for a &#x60;subscription_plans&#x60; order action or the \&quot;Create a subscription\&quot; operation, a &#x60;pending&#x60; order and/or a &#x60;pending_acceptance&#x60; subscription are created. At the same time, if the service activation date field is also required and not set, a &#x60;pending&#x60; order and/or a &#x60;pending_activation&#x60; subscription are created instead.&lt;/li&gt;   &lt;li&gt; If [Zuora is configured to require service activation](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) and the &#x60;service_activation&#x60; field is not set for any of the following order actions or the \&quot;Update a subscription\&quot; operation, a &#x60;pending&#x60; order is created. The subscription status is not impacted. **Note**: This feature is in Limited Availability. If you want to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com/).   &lt;ul&gt;   &lt;li&gt;&#x60;add_subscription_plans&#x60;&lt;/li&gt;   &lt;li&gt;&#x60;update_subscription_plans&#x60;&lt;/li&gt;   &lt;li&gt;&#x60;remove_subscription_plans&#x60;&lt;/li&gt;   &lt;li&gt;&#x60;renew&#x60;&lt;/li&gt;   &lt;li&gt;&#x60;terms&#x60;&lt;/li&gt;   &lt;/li&gt;&lt;/ul&gt;   &lt;/li&gt;   &lt;li&gt; If [Zuora is configured to require customer acceptance](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Customer_Acceptance_of_Orders.3F) and the &#x60;customer_acceptance&#x60; field is not set for any of the following order actions or the \&quot;Update a subscription\&quot; operation, a &#x60;pending&#x60; order is created. The subscription status is not impacted. Note: This feature is in Limited Availability. If you want to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com/).     &lt;ul&gt;     &lt;li&gt;&#x60;add_subscription_plans&#x60;&lt;/li&gt;     &lt;li&gt;&#x60;update_subscription_plans&#x60;&lt;/li&gt;     &lt;li&gt;&#x60;remove_subscription_plans&#x60;&lt;/li&gt;     &lt;li&gt;&#x60;renew&#x60;&lt;/li&gt;     &lt;li&gt;&#x60;terms&#x60;&lt;/li&gt;     &lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    [DataContract]
    public class StartOn
    {
        /// <summary>
        /// Effective contract date for this subscription, in the `yyyy-mm-dd` format.
        /// </summary>
        /// <value>Effective contract date for this subscription, in the `yyyy-mm-dd` format.</value>
        [DataMember(Name = "contract_effective")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contract_effective")]
        public DateTime? ContractEffective { get; set; }

        /// <summary>
        /// The date on which the services or products within a subscription have been accepted by the customer, in the `yyyy-mm-dd` format.      <ul>       <li> If [Zuora is configured to require customer acceptance](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Customer_Acceptance_of_Orders.3F) and the `customer_acceptance` field is not set for a `subscription_plans` order action or the \"Create a subscription\" operation, a `pending` order and/or a `pending_acceptance` subscription are created. At the same time, if the service activation date field is also required and not set, a `pending` order and/or a `pending_activation` subscription are created instead.</li>       <li>       If [Zuora is configured to require customer acceptance](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Customer_Acceptance_of_Orders.3F) and the `customer_acceptance` field is not set for any of the following order actions or the \"Update a subscription\" operation, a `pending` order is created. The subscription status is not impacted. **Note**: This feature is in Limited Availability. If you want to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com/).       <ul>       <li>`add_subscription_plans`</li>       <li>`update_subscription_plans`</li>       <li>`remove_subscription_plans`</li>       <li>`renew`</li>       <li>`terms`</li>       </ul></li>       </ul>
        /// </summary>
        /// <value>The date on which the services or products within a subscription have been accepted by the customer, in the `yyyy-mm-dd` format.      <ul>       <li> If [Zuora is configured to require customer acceptance](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Customer_Acceptance_of_Orders.3F) and the `customer_acceptance` field is not set for a `subscription_plans` order action or the \"Create a subscription\" operation, a `pending` order and/or a `pending_acceptance` subscription are created. At the same time, if the service activation date field is also required and not set, a `pending` order and/or a `pending_activation` subscription are created instead.</li>       <li>       If [Zuora is configured to require customer acceptance](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Customer_Acceptance_of_Orders.3F) and the `customer_acceptance` field is not set for any of the following order actions or the \"Update a subscription\" operation, a `pending` order is created. The subscription status is not impacted. **Note**: This feature is in Limited Availability. If you want to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com/).       <ul>       <li>`add_subscription_plans`</li>       <li>`update_subscription_plans`</li>       <li>`remove_subscription_plans`</li>       <li>`renew`</li>       <li>`terms`</li>       </ul></li>       </ul>       </value>
        [DataMember(Name = "customer_acceptance")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customer_acceptance")]
        public DateTime? CustomerAcceptance { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name = "id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The date on which the services or products within a subscription have been activated and access has been provided to the customer, as the `yyyy-mm-dd` format.       <ul>        <li> If [Zuora is configured to require service activation](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) and the `service_activation` field is not set for a `subscription_plans` order action or the \"Create a subscription\" operation, a `pending` order and/or a `pending_activation` subscription are created.</li>         <li> If [Zuora is configured to require service activation](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) and the `service_activation` field is not set for any of the following order actions or the \"Update a subscription\" operation, a `pending` order is created. The subscription status is not impacted. **Note**: This feature is in Limited Availability. If you want to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com/).         <ul>           <li>`add_subscription_plans`</li>           <li>`update_subscription_plans`</li>           <li>`remove_subscription_plans`</li>           <li>`renew`</li>           <li>`terms`</li>           </ul>           </li>         </ul>
        /// </summary>
        /// <value>The date on which the services or products within a subscription have been activated and access has been provided to the customer, as the `yyyy-mm-dd` format.       <ul>        <li> If [Zuora is configured to require service activation](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) and the `service_activation` field is not set for a `subscription_plans` order action or the \"Create a subscription\" operation, a `pending` order and/or a `pending_activation` subscription are created.</li>         <li> If [Zuora is configured to require service activation](https://knowledgecenter.zuora.com/CB_Billing/Billing_Settings/Define_Default_Subscription_Settings#Require_Service_Activation_of_Orders.3F) and the `service_activation` field is not set for any of the following order actions or the \"Update a subscription\" operation, a `pending` order is created. The subscription status is not impacted. **Note**: This feature is in Limited Availability. If you want to have access to the feature, submit a request at [Zuora Global Support](https://support.zuora.com/).         <ul>           <li>`add_subscription_plans`</li>           <li>`update_subscription_plans`</li>           <li>`remove_subscription_plans`</li>           <li>`renew`</li>           <li>`terms`</li>           </ul>           </li>         </ul></value>
        [DataMember(Name = "service_activation")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_activation")]
        public DateTime? ServiceActivation { get; set; }

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
            sb.Append("class StartOn {\n");
            sb.Append("  ContractEffective: ").Append(ContractEffective).Append("\n");
            sb.Append("  ServiceActivation: ").Append(ServiceActivation).Append("\n");
            sb.Append("  CustomerAcceptance: ").Append(CustomerAcceptance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}