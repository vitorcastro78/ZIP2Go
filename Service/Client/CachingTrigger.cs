using EasyCaching.Core;
using RestSharp;

namespace Service.Client
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
            return _cache.Get<T>(Id).Value;
        }

        public dynamic SetCachingTrigger<T>(Method method, RestResponse response)
        {
            dynamic result = null;
            var timeSpan = TimeSpan.FromMinutes(20);
            if (response.IsSuccessful && method == Method.Post)
            {
                 result = (T)new ApiClient(string.Empty, _cache).Deserialize(response.Content, typeof(T));
                _cache.Set(result.Id, result, timeSpan);
            }
            return result;
        }
    }
}