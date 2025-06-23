using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;
using EasyCaching.Core;
using Service.Constants;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DebitMemosService : IDebitMemosService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;
        private readonly List<string> expandItems;
        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="DebitMemosService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public DebitMemosService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().DebitMemoExpand;
            expandItems = new Expands().DebitMemoItemExpand;
            filter = new List<string>
                {
                    "enabled.EQ:true",
                    "subscriptions.state.EQ:active",
                };
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="debitMemoId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public DebitMemo CancelDebitMemo(string debitMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'debitMemoId' is set
            if (debitMemoId == null) throw new ApiException(400, "Missing required parameter 'debitMemoId' when calling CancelDebitMemo");

            var path =$"v2/debit_memos/{debitMemoId}/cancel";
            
            path = path.Replace("{" + "debitMemoId" + "}", _apiClient.ParameterToString(debitMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;


            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<DebitMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CancelDebitMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CancelDebitMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (DebitMemo)_apiClient.Deserialize(response.Content, typeof(DebitMemo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public DebitMemo CreateDebitMemo(DebitMemoCreateRequest body, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateDebitMemo");

            var path =$"v2/debit_memos";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<DebitMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateDebitMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateDebitMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (DebitMemo)_apiClient.Deserialize(response.Content, typeof(DebitMemo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="debitMemoId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <exception cref="ApiException"></exception>
        public void DeleteDebitMemo(string debitMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'debitMemoId' is set
            if (debitMemoId == null) throw new ApiException(400, "Missing required parameter 'debitMemoId' when calling DeleteDebitMemo");

            var path =$"v2/debit_memos/{debitMemoId}";
            
            path = path.Replace("{" + "debitMemoId" + "}", _apiClient.ParameterToString(debitMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<DebitMemo>(path, Method.Delete, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteDebitMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteDebitMemo: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }


        /// <summary>
        ///     
        /// </summary>
        /// <param name="debitMemoId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public DebitMemo GetDebitMemo(string debitMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'debitMemoId' is set
            if (debitMemoId == null) throw new ApiException(400, "Missing required parameter 'debitMemoId' when calling GetDebitMemo");

            var path =$"v2/debit_memos/{debitMemoId}";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            // make the HTTP request
            return _apiClient.ExecuteRequest<DebitMemo>(path, queryParams, postBody);
        }

         /// <summary>
         /// Retrieves a list of debit memo items based on the specified parameters.
         /// </summary>
         /// <remarks>This method interacts with the Zuora API to retrieve debit memo items. The results
         /// can be paginated using the  <paramref name="cursor"/> parameter. If <paramref name="async"/> is set to <see
         /// langword="true"/>, the response  may indicate that the operation is still in progress.</remarks>
         /// <param name="cursor">A string representing the pagination cursor for retrieving the next set of results.  Pass null or an empty
         /// string to retrieve the first page of results.</param>
         /// <param name="zuoraTrackId">A unique identifier used for tracking the request in Zuora. This parameter is optional.</param>
         /// <param name="async">A boolean value indicating whether the request should be processed asynchronously.  If <see
         /// langword="true"/>, the request is processed asynchronously; otherwise, it is processed synchronously.</param>
         /// <returns>A <see cref="DebitMemoItemListResponse"/> object containing the list of debit memo items and associated
         /// metadata.</returns>
        public DebitMemoItemListResponse GetDebitMemoItems(string zuoraTrackId, bool? async)
        {
            var path =$"v2/debit_memo_items";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expandItems != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expandItems)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.ExecuteRequest<DebitMemoItemListResponse>(path, queryParams, postBody, true);
            return new DebitMemoItemListResponse();
        }

        public DebitMemoListResponse GetDebitMemos(string zuoraTrackId, bool? async)
        {
            var path =$"v2/debit_memos";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;


            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter));
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.ExecuteRequest<DebitMemoListResponse>(path, queryParams, postBody, true);
            return new DebitMemoListResponse();
        }

        public DebitMemo PatchDebitMemo(DebitMemoPatchRequest body, string debitMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchDebitMemo");
            // verify the required parameter 'debitMemoId' is set
            if (debitMemoId == null) throw new ApiException(400, "Missing required parameter 'debitMemoId' when calling PatchDebitMemo");

            var path =$"v2/debit_memos/{debitMemoId}";
            
            path = path.Replace("{" + "debitMemoId" + "}", _apiClient.ParameterToString(debitMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter));
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<DebitMemo>(path, Method.Patch, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PatchDebitMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PatchDebitMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (DebitMemo)_apiClient.Deserialize(response.Content, typeof(DebitMemo));
        }

        public DebitMemo PayDebitMemo(PayDebitMemoRequest body, string debitMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PayDebitMemo");
            // verify the required parameter 'debitMemoId' is set
            if (debitMemoId == null) throw new ApiException(400, "Missing required parameter 'debitMemoId' when calling PayDebitMemo");

            var path =$"v2/debit_memos/{debitMemoId}/pay";
            
            path = path.Replace("{" + "debitMemoId" + "}", _apiClient.ParameterToString(debitMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<DebitMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PayDebitMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PayDebitMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (DebitMemo)_apiClient.Deserialize(response.Content, typeof(DebitMemo));
        }

        public DebitMemo PostsDebitMemo(string debitMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'debitMemoId' is set
            if (debitMemoId == null) throw new ApiException(400, "Missing required parameter 'debitMemoId' when calling PostsDebitMemo");

            var path =$"v2/debit_memos/{debitMemoId}/post";
            
            path = path.Replace("{" + "debitMemoId" + "}", _apiClient.ParameterToString(debitMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<DebitMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PostsDebitMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PostsDebitMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (DebitMemo)_apiClient.Deserialize(response.Content, typeof(DebitMemo));
        }

        public DebitMemo UnpostsDebitMemo(string debitMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'debitMemoId' is set
            if (debitMemoId == null) throw new ApiException(400, "Missing required parameter 'debitMemoId' when calling UnpostsDebitMemo");

            var path =$"v2/debit_memos/{debitMemoId}/unpost";
            
            path = path.Replace("{" + "debitMemoId" + "}", _apiClient.ParameterToString(debitMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<DebitMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UnpostsDebitMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UnpostsDebitMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (DebitMemo)_apiClient.Deserialize(response.Content, typeof(DebitMemo));
        }

        public void FillDebitMemosCache(string zuoraTrackId, bool async)
        {
            var path = $"v2/debit_memos";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            //if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter));
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.FillPersistentCache<DebitMemoListResponse>(path, queryParams, postBody);

        }

        public void FillDebitMemosItemsCache(string zuoraTrackId, bool async)
        {
            var path = $"v2/debit_memo_items";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            //if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter));
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.FillPersistentCache<DebitMemoItemListResponse>(path, queryParams, postBody);

        }

        public DebitMemoListResponse GetDebitMemosCached()
        {
            return new DebitMemoListResponse
            {
                Data = _apiClient.RequestCachedResult<DebitMemo>()
            };
        }

        public DebitMemo GetDebitMemoCached(string debitMemoId)
        { 
            return _apiClient.RequestCachedResult<DebitMemo>(debitMemoId); 
        }
    }
}