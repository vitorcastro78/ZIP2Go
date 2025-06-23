using Microsoft.Extensions.Logging;
using RestSharp;
using Service.Client;
using Service.Constants;
using Service.Interfaces;
using Service.Models;

namespace Service
{
    /// <summary>
    /// Service responsible for managing accounts in the system.
    /// Provides methods for creating, updating, deleting, and querying accounts.
    /// </summary>
    public class AccountsService : IAccountsService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public AccountsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().AccountExpand;
            filter = new List<string>
                {
                    "enabled.EQ:true",
                    "subscriptions.state.EQ:active",
                };
        }

        /// <summary>
        /// Creates a new account in the system.
        /// </summary>
        /// <param name="body">Account data to be created</param>
        /// <param name="zuoraTrackId">Custom identifier for tracking API requests</param>
        /// <param name="async">Indicates if the operation should be asynchronous</param>
        /// <returns>The created account</returns>
        /// <exception cref="ApiException">Thrown when the API request fails</exception>
        public Account CreateAccount(AccountCreateRequest body, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAccount");

            var path = $"v2/accounts";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            string PostBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
            PostBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Account>(path, Method.Post, queryParams, PostBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAccount: " + response.ErrorMessage, response.ErrorMessage);

            return (Account)_apiClient.Deserialize(response.Content, typeof(Account));
        }

        /// <summary>
        /// Deletes an existing account from the system.
        /// </summary>
        /// <remarks>This operation is permanent and cannot be undone.</remarks>
        /// <param name="accountId">ID of the account to be deleted</param>
        /// <param name="zuoraTrackId">Custom identifier for tracking API requests</param>
        /// <param name="async">Indicates if the operation should be asynchronous</param>
        /// <exception cref="ApiException">Thrown when the API request fails</exception>
        /// <exception cref="ArgumentNullException">Thrown when accountId is null or empty</exception>
        public void DeleteAccount(string accountId, string zuoraTrackId, bool? async)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentNullException(nameof(accountId), "Account ID cannot be null or empty");

            var path = $"v2/accounts/{accountId}";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            string PostBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            try
            {
                // make the HTTP request
                RestResponse response = (RestResponse)_apiClient.CallApi<Account>(path, Method.Delete, queryParams, PostBody);

                if (((int)response.StatusCode) >= 400)
                    throw new ApiException((int)response.StatusCode, $"Error calling DeleteAccount: {response.Content}", response.Content);
                else if (((int)response.StatusCode) == 0)
                    throw new ApiException((int)response.StatusCode, $"Error calling DeleteAccount: {response.ErrorMessage}", response.ErrorMessage);
            }
            catch (Exception ex) when (ex is not ApiException)
            {
                throw new ApiException(500, "An unexpected error occurred while deleting the account", ex);
            }
        }

        /// <summary>
        /// Generate billing documents for an account Creates billing documents for an account.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accountId">Identifier for the account, either &#x60;account_number&#x60; or &#x60;accountId&#x60;</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests. If you set a value for this header, Zuora returns the same value in the response header. This header enables you to track your API calls to assist with troubleshooting in the event of an issue. The value of this field must use the US-ASCII character set and must not include any of the following characters: colon (:), semicolon (;), double quote (\&quot;), or quote (&#x27;).</param>
        /// <param name="async">Making asynchronous requests allows you to scale your applications more efficiently by leveraging Zuora&#x27;s infrastructure to enqueue and execute requests for you without blocking. These requests also use built-in retry semantics, which makes them much less likely to fail for non-deterministic reasons, even in extreme high-throughput scenarios. Meanwhile, when you send a request to one of these endpoints, you can expect to receive a response in less than 150 milliseconds and these calls are unlikely to trigger rate limit errors. If set to true, Zuora returns a 202 Accepted response, and the response body contains only a request ID.</param>
        /// <returns>GenerateBillingDocumentsAccountResponse</returns>
        public GenerateBillingDocumentsAccountResponse GenerateBillingDocuments(GenerateBillingDocumentsAccountRequest body, string accountId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GenerateBillingDocuments");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GenerateBillingDocuments");

            var path = $"v2/accounts/{accountId}/bill";
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string PostBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            PostBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<GenerateBillingDocumentsAccountResponse>(path, Method.Get, queryParams, PostBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GenerateBillingDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GenerateBillingDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return (GenerateBillingDocumentsAccountResponse)_apiClient.Deserialize(response.Content, typeof(GenerateBillingDocumentsAccountResponse));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public Account GetAccount(string accountId, string zuoraTrackId, bool? async)
        {
            if (accountId == null) throw new ApiException(400, $"Missing required parameter accountId when calling GetAccount");

            var path = $"v2/accounts/{accountId}";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter));

            return _apiClient.ExecuteRequest<Account>(path, queryParams, postBody);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public Account GetAccountCached(string accountId)
        {
            return _apiClient.RequestCachedResult<Account>(accountId); 
        }

        /// <summary>
        /// List accounts Returns a dictionary with a data property that contains an array of accounts, starting after the cursor, if used. Each entry in the array is a separate account object. If no more accounts are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <returns>ListAccountResponse</returns>
        public ListAccountResponse GetAccountsCached()
        {
            return new ListAccountResponse
            {
                Data = _apiClient.RequestCachedResult<Account>()
                    .Where(f => f.AccountNumber != null)
                    .ToList()
            };
        }


        /// <summary>
        /// List accounts Returns a dictionary with a data property that contains an array of accounts, starting after the cursor, if used. Each entry in the array is a separate account object. If no more accounts are available, the resulting array will be empty. This request should never return an error.
        /// </summary>
        /// <returns>ListAccountResponse</returns>
        public void FillAccountsCache(string zuoraTrackId, bool? async)
        {
            var path = $"v2/accounts";
            
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

            //if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            //if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            _apiClient.FillPersistentCache<ListAccountResponse>(path, queryParams, null);
        }

        /// <summary>
        /// Previews an account before creation.
        /// </summary>
        /// <param name="body">Account data to preview</param>
        /// <param name="accountId">ID of the account to preview</param>
        /// <param name="zuoraTrackId">Custom identifier for tracking API requests</param>
        /// <param name="async">Indicates if the operation should be asynchronous</param>
        /// <returns>Preview response containing account details</returns>
        /// <exception cref="ApiException">Thrown when the API request fails</exception>
        public AccountPreviewResponse PreviewAccount(AccountPreviewRequest body, string accountId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PreviewAccount");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling PreviewAccount");

            var path = $"v2/accounts/{accountId}/preview";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string PostBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            PostBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<AccountPreviewResponse>(path, Method.Post, queryParams, PostBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PreviewAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PreviewAccount: " + response.ErrorMessage, response.ErrorMessage);

            return (AccountPreviewResponse)_apiClient.Deserialize(response.Content, typeof(AccountPreviewResponse));
        }

        /// <summary>
        /// Updates an existing account's data.
        /// </summary>
        /// <param name="body">Updated account data</param>
        /// <param name="accountId">ID of the account to update</param>
        /// <param name="zuoraTrackId">Custom identifier for tracking API requests</param>
        /// <param name="async">Indicates if the operation should be asynchronous</param>
        /// <returns>The updated account</returns>
        /// <exception cref="ApiException">Thrown when the API request fails</exception>
        public Account UpdateAccount(AccountPatchRequest body, string accountId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateAccount");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateAccount");

            var path = $"v2/accounts/{accountId}";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string PostBody = null;


            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            PostBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<Account>(path, Method.Patch, queryParams, PostBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAccount: " + response.ErrorMessage, response.ErrorMessage);

            return (Account)_apiClient.Deserialize(response.Content, typeof(Account));
        }
    }
}