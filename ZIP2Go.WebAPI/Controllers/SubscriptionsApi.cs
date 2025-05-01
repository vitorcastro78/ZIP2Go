using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZIP2GO.Service.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

using ZIP2GO.WebAPI.Attributes;
using ZIP2GO.WebAPI.Security;
using Service.Interfaces;
using EasyCaching.Core;
using ZIP2Go.WebAPI.Controllers;

namespace ZIP2GO.WebAPI.Controllers
{
    [ApiController]
    public class SubscriptionsApiController : ControllerBaseApi
    {
        private readonly ISubscriptionsService _subscriptionsService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEasyCachingProvider _cacheProvider;

        public SubscriptionsApiController(
            ISubscriptionsService subscriptionsService,
            IHttpContextAccessor httpContextAccessor,
            IEasyCachingProvider cache) : base(httpContextAccessor, cache)
        {
            _subscriptionsService = subscriptionsService ?? throw new ArgumentNullException(nameof(subscriptionsService));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            _cacheProvider = cache ?? throw new ArgumentNullException(nameof(cache));
        }

        [HttpPost]
        [Route("/v2/subscriptions/{subscription_id}/activate")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ActivateSubscription")]
        [SwaggerResponse(statusCode: 200, type: typeof(Subscription), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> ActivateSubscription([FromBody] SubscriptionActivateRequest body, [FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }

        [HttpPost]
        [Route("/v2/subscriptions/{subscription_id}/cancel")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CancelSubscription")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubscriptionCancelResponse), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> CancelSubscription([FromBody] CancelSubscriptionRequest body, [FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }

        [HttpPost]
        [Route("/v2/subscriptions")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateSubscription")]
        [SwaggerResponse(statusCode: 201, type: typeof(Subscription), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> CreateSubscription([FromBody] SubscriptionCreateRequest body)
        {
            return new ObjectResult(null);
        }

        [HttpGet]
        [Route("/v2/subscriptions/{subscription_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptionByKey")]
        public async Task<IActionResult> GetSubscriptionByKey([FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }

        [HttpGet]
        [Route("/v2/subscriptions/{subscription_id}/versions")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptionByVersion")]
        public async Task<IActionResult> GetSubscriptionByVersion([FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }

        [HttpGet]
        [Route("/v2/subscriptions")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptions")]
        public async Task<IActionResult> GetSubscriptions()
        {
            return new ObjectResult(null);
        }

        [HttpPatch]
        [Route("/v2/subscriptions/{subscription_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PatchSubscription")]
        public async Task<IActionResult> PatchSubscription([FromBody] SubscriptionPatchRequest body, [FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }

        [HttpPost]
        [Route("/v2/subscriptions/{subscription_id}/pause")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PauseSubscription")]
        public async Task<IActionResult> PauseSubscription([FromBody] PauseSubscriptionRequest body, [FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }

        [HttpPost]
        [Route("/v2/subscriptions/{subscription_id}/preview")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PreviewExistingSubscription")]
        public async Task<IActionResult> PreviewExistingSubscription([FromBody] SubscriptionPreviewExistingRequest body, [FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }

        [HttpPost]
        [Route("/v2/subscriptions/preview")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PreviewSubscription")]
        public async Task<IActionResult> PreviewSubscription([FromBody] SubscriptionPreviewRequest body)
        {
            return new ObjectResult(null);
        }

        [HttpPost]
        [Route("/v2/subscriptions/{subscription_id}/resume")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ResumeSubscription")]
        public async Task<IActionResult> ResumeSubscription([FromBody] ResumeSubscriptionRequest body, [FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }

        [HttpPost]
        [Route("/v2/subscriptions/{subscription_id}/keep")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UncancelSubscription")]
        public async Task<IActionResult> UncancelSubscription([FromBody] SubscriptionPatchRequest body, [FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }
    }
} 
