using EasyCaching.Core;
using RestSharp;
using Service.Client;
using Service.Constants;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Api
{
    public class CustomizedServices
    {
        public readonly IApiClient _apiClient;

        private List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public CustomizedServices(ApiClient apiClient)
        {
            _apiClient = apiClient;

        }

        public RestResponse GetSubscriptionsByAccountId(string accountId, string zuoraTrackId, bool? async)
        {
            expand = new Expands().SubscriptionsExpand;

            filter = new List<string>
                {
                    $"account_id.EQ:{accountId}",
                    "state.EQ:active",
                };

            var path = $"v2/subscriptions";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            return _apiClient.CallApi<Subscription>(path, Method.Get, queryParams, postBody, true);
        }

        public RestResponse GetInvoicesByAccountId(string accountId, string zuoraTrackId, bool? async)
        {
            expand = new Expands().InvoicesExpand;

            filter = new List<string>
                {
                    $"account_id.EQ:{accountId}",
                    "state.EQ:posted",
                };

            var path = $"v2/invoices";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            return _apiClient.CallApi<Subscription>(path, Method.Get, queryParams, postBody, true);
        }
    }
}