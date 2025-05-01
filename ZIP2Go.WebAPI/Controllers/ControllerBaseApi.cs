using EasyCaching.Core;
using Microsoft.AspNetCore.Http.Connections.Features;
using Microsoft.AspNetCore.Mvc;


namespace ZIP2Go.WebAPI.Controllers
{
    public class ControllerBaseApi : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly IEasyCachingProvider _cache;
        public ControllerBaseApi(IHttpContextAccessor httpContextFeature, IEasyCachingProvider cache)
        {
            _httpContext = httpContextFeature;
            _cache = cache;
            new Context().SubscriptionApiKey = _httpContext.HttpContext.Request.Headers.FirstOrDefault(f => f.Key == "subscription-api-key").Value;
            _cache.Set<string>("subscription-api-key", "subscription-api-key", TimeSpan.FromMinutes(20));
        }

       

    }

    public class Context
    {
        public string SubscriptionApiKey
        {
            get; set;
        }

    
    }
}
