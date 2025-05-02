using EasyCaching.Core;
using Microsoft.AspNetCore.Mvc;

namespace ZIP2Go.WebAPI.Controllers
{
    public class Context
    {
        public string SubscriptionApiKey
        {
            get; set;
        }
    }

    public class ControllerBaseApi : ControllerBase
    {
        private readonly IEasyCachingProvider _cache;

        private readonly IHttpContextAccessor _httpContext;

        public ControllerBaseApi(IHttpContextAccessor httpContextFeature, IEasyCachingProvider cache)
        {
            _httpContext = httpContextFeature;
            _cache = cache;
            new Context().SubscriptionApiKey = _httpContext.HttpContext.Request.Headers.FirstOrDefault(f => f.Key == "subscription-api-key").Value;
            _cache.Set<string>("subscription-api-key", "subscription-api-key", TimeSpan.FromMinutes(20));
        }
    }
}