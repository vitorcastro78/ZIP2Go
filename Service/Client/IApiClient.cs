﻿using RestSharp;

namespace Service.Client
{
    public interface IApiClient
    {
        string BasePath { get; set; }

        Dictionary<string, string> DefaultHeader { get; }

        RestClient RestClient { get; set; }

        void AddDefaultHeader(string key, string value);

        string Base64Encode(string text);

        List<T> CallApi<T>();

        // RestResponse CallApi(string path, Method method, Dictionary<string, string> queryParams, string postBody, bool? async = true);

        RestResponse CallApi<T>(string path, RestSharp.Method method, Dictionary<string, string>? queryParams, string postBody, bool? async = true);

        object ConvertType(object fromObject, Type toObject);

        object Deserialize(string content, Type type, IList<Parameter> headers = null);

        string EscapeString(string str);

        void FillPersistentCache<T>(string path, Dictionary<string, string> queryParams, string postBody);
        T ExecuteRequest<T>(string path, Dictionary<string, string> queryParams, string postBody);

        void ExecuteRequest<T>(string path, Dictionary<string, string> queryParams, string postBody, bool NoResponse);

        string GetApiKeyWithPrefix(string apiKeyIdentifier);

        string GetToken();

        string ParameterToString(object obj);

        T RequestCachedResult<T>(string id);

        T RequestCachedResult<T>(string id, string secondFilter);

        List<T> RequestCachedResult<T>();
        List<T> RequestCachedResults<T>(string filter);

        string? Serialize(object obj);

        void UpdateParamsForAuth(Dictionary<string, string> queryParams, Dictionary<string, string> headerParams, string[] authSettings);
    }
}