using RestSharp;

namespace Service.Client
{
    public interface IApiClient
    {
        string BasePath { get; set; }
        Dictionary<string, string> DefaultHeader { get; }
        RestClient RestClient { get; set; }
        string Base64Encode(string text);
        object ConvertType(object fromObject, Type toObject);
        void AddDefaultHeader(string key, string value);
        object CallApi(string path, Method method, Dictionary<string, string> queryParams, string postBody, bool? async = true);
        T CallApi<T>(string Id, string path, Method method, Dictionary<string, string>? queryParams, string postBody, bool? async = true);
        T ExecuteRequest<T>(string path, Dictionary<string, string> queryParams, string postBody);
        object Deserialize(string content, Type type, IList<Parameter> headers = null);
        string EscapeString(string str);
        string GetApiKeyWithPrefix(string apiKeyIdentifier);
        string GetToken();
        string ParameterToString(object obj);
        string Serialize(object obj);
        void UpdateParamsForAuth(Dictionary<string, string> queryParams, Dictionary<string, string> headerParams, string[] authSettings);
    }
}