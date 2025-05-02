using EasyCaching.Core;
using RestSharp;

namespace ZIP2GO.Service.Client
{
    public class CachingTrigger
    {
        private readonly IEasyCachingProvider _cache;

        public CachingTrigger(IEasyCachingProvider cache)
        {
            _cache = cache;
        }

        public dynamic GetCachingTrigger<T>(string Id)
        {
            return _cache.Get<T>(Id);
        }

        public RestResponse SetCachingTrigger<T>(Method method, RestResponse response)
        {
            var timeSpan = TimeSpan.FromMinutes(20);
            if (response.IsSuccessful && method == Method.Post)
            {
                dynamic result = (T)new ApiClient().Deserialize(response.Content, typeof(T));
                _cache.Set(result.Id, result, timeSpan);
            }
            return response;
        }
    }
}