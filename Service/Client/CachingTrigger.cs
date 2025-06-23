using EasyCaching.Core;
using RestSharp;

namespace Service.Client
{
    public class CachingTrigger : ICachingTrigger
    {
        private readonly IEasyCachingProvider _cache;

        public CachingTrigger(IEasyCachingProvider cache)
        {
            _cache = cache;
        }

        public void FillCache(dynamic result)
        {
            foreach (var item in result.Data)
            {
                var name = item.GetType().Name;
                _cache.SetAsync<dynamic>($"{name}_{item.Id}", item, TimeSpan.FromHours(12));
            }
        }

        public void FillCachePostResult(dynamic result)
        {
            var name = result.GetType().Name;
            _cache.SetAsync<dynamic>($"{name}_{result.Id}", result, TimeSpan.FromHours(12));
        }

        public void SetCache(dynamic result)
        {
            _cache.SetAsync<dynamic>($"{result.Id}", result, TimeSpan.FromHours(12));
        }

        public T GetCahe<T>(string id)
        {
            return _cache.Get<T>($"{id}").Value;
        }
    }
}