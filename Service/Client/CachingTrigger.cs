using EasyCaching.Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zip2Go.Client;
using Zip2Go.Models;

namespace Service.Client
{
    public  class CachingTrigger
    {
        private readonly IEasyCachingProvider _cache;

        public CachingTrigger(IEasyCachingProvider cache)
        {
            _cache = cache;
        }

        public RestResponse SetCachingTrigger<T>(string path, Method method, RestResponse response)
        {
            Object obj = null;
            var timeSpan = TimeSpan.FromMinutes(20);
            if (response.IsSuccessful && method == Method.Post)
            {
                dynamic result = (T)new ApiClient().Deserialize(response.Content, typeof(T));
                _cache.Set(result.Id, result, timeSpan);
            }
            return response;
        }


        public T GetCachingTrigger<T>(string path, Method method, RestResponse response)
        {
                dynamic result = (T)new ApiClient().Deserialize(response.Content, typeof(T));
                var output = _cache.Get<T>(result.Id);
            
            return output;
        }

    }
}
