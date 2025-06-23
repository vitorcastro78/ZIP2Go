using EasyCaching.Core;
using RestSharp;
using Service.Client;
using Service.Constants;
using Service.Models;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CreditMemosService : ICreditMemosService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditMemosService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public CreditMemosService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new Expands().CreditMemoExpand;
            filter = new List<string>
                {
                    "enabled.EQ:true",
                    "subscriptions.state.EQ:active",
                };
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="creditMemoId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public CreditMemo ApplyCreditMemo(ApplyUnapplyCreditMemo body, string creditMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ApplyCreditMemo");
            // verify the required parameter 'creditMemoId' is set
            if (creditMemoId == null) throw new ApiException(400, "Missing required parameter 'creditMemoId' when calling ApplyCreditMemo");

            var path =$"v2/credit_memos/{creditMemoId}/apply";
            
            path = path.Replace("{" + "creditMemoId" + "}", _apiClient.ParameterToString(creditMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ApplyCreditMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ApplyCreditMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (CreditMemo)_apiClient.Deserialize(response.Content, typeof(CreditMemo));
        }

         /// <summary>
         /// 
         /// </summary>
         /// <param name="creditMemoId"></param>
         /// <param name="zuoraTrackId"></param>
         /// <param name="async"></param>
         /// <returns></returns>
         /// <exception cref="ApiException"></exception>
        public CreditMemo CancelCreditMemo(string creditMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'creditMemoId' is set
            if (creditMemoId == null) throw new ApiException(400, "Missing required parameter 'creditMemoId' when calling CancelCreditMemo");

            var path =$"v2/credit_memos/{creditMemoId}/cancel";
            
            path = path.Replace("{" + "creditMemoId" + "}", _apiClient.ParameterToString(creditMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CancelCreditMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CancelCreditMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (CreditMemo)_apiClient.Deserialize(response.Content, typeof(CreditMemo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public CreditMemo CreateCreditMemo(CreditMemoCreateRequest body, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateCreditMemo");

            var path =$"v2/credit_memos";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateCreditMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateCreditMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (CreditMemo)_apiClient.Deserialize(response.Content, typeof(CreditMemo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="creditMemoId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <exception cref="ApiException"></exception>
        public void DeleteCreditMemo(string creditMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'creditMemoId' is set
            if (creditMemoId == null) throw new ApiException(400, "Missing required parameter 'creditMemoId' when calling DeleteCreditMemo");

            var path =$"v2/credit_memos/{creditMemoId}";
            
            path = path.Replace("{" + "creditMemoId" + "}", _apiClient.ParameterToString(creditMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemo>(path, Method.Delete, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteCreditMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteCreditMemo: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="creditMemoId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public CreditMemo GetCreditMemo(string creditMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'creditMemoId' is set
            if (creditMemoId == null) throw new ApiException(400, "Missing required parameter 'creditMemoId' when calling GetCreditMemo");

            var path =$"v2/credit_memos/{creditMemoId}";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter)); // query parameter

            // make the HTTP request
            return _apiClient.ExecuteRequest<CreditMemo>(path, queryParams, postBody);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public CreditMemoItemListResponse GetCreditMemoItems(string cursor, string zuoraTrackId, bool? async)
        {
            var path =$"v2/credit_memo_items";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            //if (cursor != null) queryParams.Add("cursor", _apiClient.ParameterToString(cursor)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemoItemListResponse>(path, Method.Get, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetCreditMemoItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCreditMemoItems: " + response.ErrorMessage, response.ErrorMessage);

            return (CreditMemoItemListResponse)_apiClient.Deserialize(response.Content, typeof(CreditMemoItemListResponse));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public void FillCreditMemosItemsCache(string zuoraTrackId, bool async)
        {
            var path = $"v2/credit_memo_items";


            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();


            string postBody = null;

            //if (cursor != null) queryParams.Add("cursor", _apiClient.ParameterToString(cursor)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter

            // make the HTTP request
         _apiClient.FillPersistentCache<CreditMemoItemListResponse>(path, queryParams, postBody);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        public CreditMemoListResponse GetCreditMemos(string cursor, string zuoraTrackId, bool? async)
        {
            var path =$"v2/credit_memos";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter));
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.ExecuteRequest<CreditMemoListResponse>(path, queryParams, postBody, true);
            return new CreditMemoListResponse();
        }

            /// <summary>
            ///     
            /// </summary>
            /// <param name="body"></param>
            /// <param name="creditMemoId"></param>
            /// <param name="zuoraTrackId"></param>
            /// <param name="async"></param>
            /// <returns></returns>
            /// <exception cref="ApiException"></exception>
        public CreditMemo PatchCreditMemo(CreditMemoPatchRequest body, string creditMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchCreditMemo");
            // verify the required parameter 'creditMemoId' is set
            if (creditMemoId == null) throw new ApiException(400, "Missing required parameter 'creditMemoId' when calling PatchCreditMemo");

            var path =$"v2/credit_memos/{creditMemoId}";
            
            path = path.Replace("{" + "creditMemoId" + "}", _apiClient.ParameterToString(creditMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemo>(path, Method.Patch, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PatchCreditMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PatchCreditMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (CreditMemo)_apiClient.Deserialize(response.Content, typeof(CreditMemo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="creditMemoId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public CreditMemo PostCreditMemo(string creditMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'creditMemoId' is set
            if (creditMemoId == null) throw new ApiException(400, "Missing required parameter 'creditMemoId' when calling PostCreditMemo");

            var path =$"v2/credit_memos/{creditMemoId}/post";
            
            path = path.Replace("{" + "creditMemoId" + "}", _apiClient.ParameterToString(creditMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PostCreditMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PostCreditMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (CreditMemo)_apiClient.Deserialize(response.Content, typeof(CreditMemo));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="creditMemoId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public CreditMemo UnapplyCreditMemo(ApplyUnapplyCreditMemo body, string creditMemoId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UnapplyCreditMemo");
            // verify the required parameter 'creditMemoId' is set
            if (creditMemoId == null) throw new ApiException(400, "Missing required parameter 'creditMemoId' when calling UnapplyCreditMemo");

            var path =$"v2/credit_memos/{creditMemoId}/unapply";
            
            path = path.Replace("{" + "creditMemoId" + "}", _apiClient.ParameterToString(creditMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UnapplyCreditMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UnapplyCreditMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (CreditMemo)_apiClient.Deserialize(response.Content, typeof(CreditMemo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="creditMemoId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <param name="zuoraEntityId"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public CreditMemo UnpostCreditMemo(string creditMemoId, string zuoraTrackId, bool? async, string zuoraEntityId)
        {
            // verify the required parameter 'creditMemoId' is set
            if (creditMemoId == null) throw new ApiException(400, "Missing required parameter 'creditMemoId' when calling UnpostCreditMemo");

            var path =$"v2/credit_memos/{creditMemoId}/unpost";
            
            path = path.Replace("{" + "creditMemoId" + "}", _apiClient.ParameterToString(creditMemoId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter
            // if (zuoraEntityId != null) headerParams.Add("zuora-entity-id", ApiClient.ParameterToString(zuoraEntityId)); // header parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<CreditMemo>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UnpostCreditMemo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UnpostCreditMemo: " + response.ErrorMessage, response.ErrorMessage);

            return (CreditMemo)_apiClient.Deserialize(response.Content, typeof(CreditMemo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        public void FillCreditMemosCache(string zuoraTrackId, bool async)
        {
            var path = $"v2/credit_memos";
            

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();


            string postBody = null;

            if (expand != null) queryParams.Add("expand[]", _apiClient.ParameterToString(expand)); // query parameter
            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (filter != null) queryParams.Add("filter[]", _apiClient.ParameterToString(filter));
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            // make the HTTP request
            _apiClient.FillPersistentCache<CreditMemoListResponse>(path, queryParams, postBody);

        }


        public CreditMemoListResponse GetCreditMemosCached()
        {
            return new CreditMemoListResponse
            {
                Data = _apiClient.RequestCachedResult<CreditMemo>()
            };
        }

        public CreditMemo GetCreditMemoCached(string creditMemoId) => _apiClient.RequestCachedResult<CreditMemo>(creditMemoId);
    }
}