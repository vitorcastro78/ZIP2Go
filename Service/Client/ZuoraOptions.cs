namespace ZIP2GO.Service.Client
{
    public class ZuoraOptions
    {
        public class WorkFlowSection
        {
            public string WorkflowId { get; set; }
        }

        public class CountrySection
        {
            public string PaymentGateway { get; set; }

            public IDictionary<string, LocaleSection> LocaleSections { get; set; }

            public string HostedPageBasicUrl { get; set; }

            public HostedPage HostedPageCreditCard { get; set; }

            public HostedPage HostedPageSEPA { get; set; }

            public HostedPage HostedPageACH { get; set; }

            public HostedPage HostedPageiDeal { get; set; }

            public HostedPage HostedPagePayPal { get; set; }

            public string SequenceSetID { get; set; }
        }

        public class LocaleSection
        {
            public string InvoiceTemplate { get; set; }

            public string CommunicationProfile { get; set; }
        }

        public class HostedPage
        {
            public string PageId { get; set; }

            public string Gateway { get; set; }
        }

        public class PromotionSection
        {
            public string BaseUrl { get; set; }

            public string UserName { get; set; }

            public string Password { get; set; }

            public PromotionSection()
            {
            }

            public PromotionSection(string baseUrl, string userName, string password)
            {
                BaseUrl = baseUrl;
                UserName = userName;
                Password = password;
            }
        }

        public string BaseUrl { get; set; }

        public string UserId { get; set; }

        public string Password { get; set; }

        public string ClientSecret { get; set; }

        public string ClientID { get; set; }

        public IDictionary<string, CountrySection> CountrySections { get; set; }

        public IDictionary<string, string> EndpointSpecificVersions { get; set; } = new Dictionary<string, string>();

        public string ZuoraEntityId { get; set; }

        public string ZuoraIdempotencyKey { get; set; }

        public Guid ZuoraTrackId { get; set; } = Guid.NewGuid();

        public string ClientDefaultZuoraVersion { get; set; }

        public IDictionary<string, WorkFlowSection> WorkflowSections { get; set; }

        public PromotionSection Promotion { get; set; }
    }
}