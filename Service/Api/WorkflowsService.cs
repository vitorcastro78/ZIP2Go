using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;
using EasyCaching.Core;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WorkflowsService : IWorkflowsService
    {
        public readonly IApiClient _apiClient;

        private readonly List<string> expand;

        private List<string> filter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsService"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of _apiClient (optional)</param>
        /// <returns></returns>
        public WorkflowsService(ApiClient apiClient)
        {
            _apiClient = apiClient;
            expand = new List<string>();
            filter = new List<string>();
        }


        /// <summary>
        /// Executes a specified workflow with the provided parameters and returns the result of the workflow execution.
        /// </summary>
        /// <remarks>The method sends a POST request to the API endpoint corresponding to the specified
        /// workflow ID.  If the <paramref name="async"/> parameter is set to <see langword="true"/>, the workflow will
        /// be executed asynchronously,  and the response will indicate the initiation of the workflow rather than its
        /// completion.</remarks>
        /// <param name="body">The request body containing the input parameters required to execute the workflow. This parameter cannot be
        /// <see langword="null"/>.</param>
        /// <param name="workflowId">The unique identifier of the workflow to be executed. This parameter cannot be <see langword="null"/>.</param>
        /// <param name="zuoraTrackId">An optional tracking identifier for the request, used for logging and tracing purposes.</param>
        /// <param name="async">A boolean value indicating whether the workflow should be executed asynchronously.  <see langword="true"/>
        /// to execute the workflow asynchronously; otherwise, <see langword="false"/>.</param>
        /// <returns>A <see cref="WorkflowRun"/> object containing the details of the executed workflow, including its status and
        /// any output data.</returns>
        /// <exception cref="ApiException">Thrown if the required parameters <paramref name="body"/> or <paramref name="workflowId"/> are not provided,
        /// or if an error occurs during the execution of the workflow.</exception>
        public WorkflowRun RunWorkflow(RunWorkflowRequest body, int? workflowId, string zuoraTrackId, bool? async)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RunWorkflow");
            // verify the required parameter 'workflowId' is set
            if (workflowId == null) throw new ApiException(400, "Missing required parameter 'workflowId' when calling RunWorkflow");

            var path =$"v2/workflows/{workflowId}/run";

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            
            
            string postBody = null;

            if (zuoraTrackId != null) headerParams.Add("zuora-track-id", _apiClient.ParameterToString(zuoraTrackId)); // header parameter
            if (async != null) headerParams.Add("async", _apiClient.ParameterToString(async)); // header parameter

            postBody = _apiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            RestResponse response = (RestResponse)_apiClient.CallApi<WorkflowRun>(path, Method.Post, queryParams, postBody);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling RunWorkflow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling RunWorkflow: " + response.ErrorMessage, response.ErrorMessage);

            return (WorkflowRun)_apiClient.Deserialize(response.Content, typeof(WorkflowRun));
        }

       
    }
}