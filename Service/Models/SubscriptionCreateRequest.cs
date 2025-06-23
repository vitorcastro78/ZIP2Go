using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace Service.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SubscriptionCreateRequest
    {
        [DataMember(Name = "account_id")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_id")]
        public string? account_id { get; set; }

        [DataMember(Name = "auto_renew")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auto_renew")]
        public bool? auto_renew { get; set; }

        [DataMember(Name = "initial_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initial_term")]
        public SubscriptionCreateTerm? initial_term { get; set; }

        [DataMember(Name = "renewal_term")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewal_term")]
        public SubscriptionCreateTerm? renewal_term { get; set; }

        [DataMember(Name = "start_on")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_on")]
        public SubscriptionCreateStart_On? start_on { get; set; }

        [DataMember(Name = "description")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string? description { get; set; }

        [DataMember(Name = "invoice_separately")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_separately")]
        public bool? invoice_separately { get; set; }

        [DataMember(Name = "custom_fields")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom_fields")]
        public SubscriptionCreateCustom_Fields? custom_fields { get; set; }

        [DataMember(Name = "subscription_plans")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscription_plans")]
        public SubscriptionCreateSubscription_Plans[]? subscription_plans { get; set; }

        public class SubscriptionCreateTerm
        {
            [DataMember(Name = "interval_count")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interval_count")]
            public int? interval_count { get; set; }

            [DataMember(Name = "interval")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interval")]
            public string? interval { get; set; }

            [DataMember(Name = "start_date")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_date")]
            public string? start_date { get; set; }

            [DataMember(Name = "type")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
            public string? type { get; set; }
        }

        public class SubscriptionCreateStart_On
        {
            [DataMember(Name = "contract_effective")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contract_effective")]
            public string? contract_effective { get; set; }

            [DataMember(Name = "service_activation")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service_activation")]
            public string? service_activation { get; set; }

            [DataMember(Name = "customer_acceptance")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customer_acceptance")]
            public string? customer_acceptance { get; set; }
        }

        public class SubscriptionCreateCustom_Fields
        {
        }

        public class SubscriptionCreateSubscription_Plans
        {
            [DataMember(Name = "plan_id")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plan_id")]
            public string? plan_id { get; set; }

            [DataMember(Name = "prices")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prices")]
            public SubscriptionCreatePrice[]? prices { get; set; }
        }

        public class SubscriptionCreatePrice
        {
            [DataMember(Name = "price_id")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "price_id")]
            public string? price_id { get; set; }

            [DataMember(Name = "amount")]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
            public int? amount { get; set; }
        }


    }



}