namespace Service.Client
{
    public class ZuoraOptions
    {
        public string BaseUrl { get; set; }

        public string ClientDefaultZuoraVersion { get; set; }

        public string ClientID { get; set; }

        public string ClientSecret { get; set; }

        public IDictionary<string, CountrySection> CountrySections { get; set; }

        public IDictionary<string, string> EndpointSpecificVersions { get; set; } = new Dictionary<string, string>();

        public string Password { get; set; }

        public PromotionSection Promotion { get; set; }

        public string UserId { get; set; }

        public IDictionary<string, WorkFlowSection> WorkflowSections { get; set; }

        public string ZuoraEntityId { get; set; }

        public string ZuoraIdempotencyKey { get; set; }

        public Guid ZuoraTrackId { get; set; } = Guid.NewGuid();

        public class CountrySection
        {
            public HostedPage HostedPageACH { get; set; }

            public string HostedPageBasicUrl { get; set; }

            public HostedPage HostedPageCreditCard { get; set; }

            public HostedPage HostedPageiDeal { get; set; }

            public HostedPage HostedPagePayPal { get; set; }

            public HostedPage HostedPageSEPA { get; set; }

            public IDictionary<string, LocaleSection> LocaleSections { get; set; }

            public string PaymentGateway { get; set; }

            public string SequenceSetID { get; set; }
        }

        public class HostedPage
        {
            public string Gateway { get; set; }

            public string PageId { get; set; }
        }

        public class LocaleSection
        {
            public string CommunicationProfile { get; set; }

            public string InvoiceTemplate { get; set; }
        }

        public class PromotionSection
        {
            public PromotionSection()
            {
            }

            public PromotionSection(string baseUrl, string userName, string password)
            {
                BaseUrl = baseUrl;
                UserName = userName;
                Password = password;
            }

            public string BaseUrl { get; set; }

            public string Password { get; set; }

            public string UserName { get; set; }
        }

        public class WorkFlowSection
        {
            public string WorkflowId { get; set; }
        }
    }
}