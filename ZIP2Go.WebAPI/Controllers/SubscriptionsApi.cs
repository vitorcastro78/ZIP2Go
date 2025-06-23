using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Service;
using Service.Interfaces;
using Service.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using ZIP2GO.WebAPI.Attributes;
using ZIP2GO.WebAPI.Security;

namespace ZIP2GO.WebAPI.Controllers
{
    /// <summary>
    /// Controller responsible for managing subscriptions in the system.
    /// Provides endpoints for creating, updating, deleting, and querying subscriptions.
    /// </summary>
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISubscriptionsService _subscriptionsService;

        /// <summary>
        /// Initializes a new instance of the subscriptions controller.
        /// </summary>
        /// <param name="subscriptionsService">Service for managing subscriptions</param>
        /// <param name="httpContextAccessor">HTTP context accessor</param>
        /// <param name="cache">Cache provider</param>
        /// <exception cref="ArgumentNullException">Thrown when any dependency is null</exception>
        public SubscriptionsController(
            ISubscriptionsService subscriptionsService)
        {
            _subscriptionsService = subscriptionsService ?? throw new ArgumentNullException(nameof(subscriptionsService));
        }

        /// <summary>
        /// Cancels an active subscription.
        /// </summary>
        /// <param name="subscriptionId">ID of the subscription to cancel</param>
        /// <returns>The cancelled subscription details</returns>
        /// <response code="200">Subscription cancelled successfully</response>
        /// <response code="404">Subscription not found</response>
        /// <response code="400">Subscription cannot be cancelled</response>
        [HttpPost]
        [Route("/subscriptions/{subscriptionId}/cancel")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CancelSubscription")]
        public async Task<IActionResult> CancelSubscription([FromBody] CancelSubscriptionRequest body, [FromRoute][Required] string subscriptionId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _subscriptionsService.CancelSubscription(body, subscriptionId, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="body">Subscription data to create</param>
        /// <returns>The newly created subscription</returns>
        /// <response code="201">Subscription created successfully</response>
        /// <response code="400">Invalid subscription data</response>
        [HttpPost]
        [Route("/subscriptions")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateSubscription")]
        public async Task<IActionResult> CreateSubscription([FromBody] SubscriptionCreateRequest body, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _subscriptionsService.CreateSubscription(body, zuoraTrackId, async);     
            return Ok(result);
        }

        /// <summary>
        /// Retrieves a subscription by its ID.
        /// </summary>
        /// <param name="subscriptionId">The unique identifier of the subscription</param>
        /// <returns>The requested subscription details</returns>
        /// <response code="200">Subscription found and returned</response>
        /// <response code="404">Subscription not found</response>
        [HttpGet]
        [Route("/subscriptions/{subscriptionId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscription")]
        public async Task<IActionResult> GetSubscription([FromRoute][Required] string subscriptionId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            if (string.IsNullOrEmpty(subscriptionId)) return BadRequest("subscriptionId cannot be null");
            if (string.IsNullOrEmpty(zuoraTrackId)) return BadRequest("zuoraTrackId cannot be null");

            var subscription = _subscriptionsService.GetSubscriptionCached(subscriptionId);

            if (subscription is null) subscription = _subscriptionsService.GetSubscriptionByKey(subscriptionId, zuoraTrackId, async);

            return Ok(subscription);
        }

        /// <summary>
        /// Retrieves a subscription by its ID.
        /// </summary>
        /// <param name="subscriptionId">The unique identifier of the subscription</param>
        /// <returns>The requested subscription details</returns>
        /// <response code="200">Subscription found and returned</response>
        /// <response code="404">Subscription not found</response>
        [HttpGet]
        [Route("/subscriptions/account/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscription")]
        public async Task<IActionResult> GetSubscriptionByAccountId([FromRoute][Required] string id, [FromQuery] string zuoraTrackId, bool async = true)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest("subscriptionId cannot be null");
            if (string.IsNullOrEmpty(zuoraTrackId)) return BadRequest("zuoraTrackId cannot be null");

            var subscription = _subscriptionsService.GetSubscriptionsCachedByAccountId(id);

            if (!subscription.Data.Any())
            { 
                subscription = _subscriptionsService.GetSubscriptionByAccountId(id, zuoraTrackId, async); 
            }

            return Ok(subscription);
        }

        /// <summary>
        /// Retrieves a list of all subscriptions.
        /// </summary>
        /// <returns>A paginated list of subscriptions</returns>
        /// <response code="200">List of subscriptions retrieved successfully</response>
        [HttpGet]
        [Route("/subscriptions")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptions")]
        public async Task<IActionResult> GetSubscriptions([FromQuery] string zuoraTrackId, bool async = true)
        {
            var subscriptions = _subscriptionsService.GetSubscriptionsCached();

            if (subscriptions.Data.Count() == 0) subscriptions = _subscriptionsService.GetSubscriptions(zuoraTrackId, async);

            return Ok(subscriptions);
        }

        /// <summary>
        /// Renews an existing subscription.
        /// </summary>
        /// <param name="subscriptionId">ID of the subscription to renew</param>
        /// <returns>The renewed subscription details</returns>
        /// <response code="200">Subscription renewed successfully</response>
        /// <response code="404">Subscription not found</response>
        /// <response code="400">Subscription cannot be renewed</response>
        [HttpPost]
        [Route("/subscriptions/{subscriptionId}/renew")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("RenewSubscription")]
        public async Task<IActionResult> RenewSubscription([FromRoute][Required] string subscriptionId)
        {
            return new ObjectResult(null);
        }


        /// <summary>
        /// Renews an existing subscription.
        /// </summary>
        /// <param name="subscriptionId">ID of the subscription to renew</param>
        /// <returns>The renewed subscription details</returns>
        /// <response code="200">Subscription renewed successfully</response>
        /// <response code="404">Subscription not found</response>
        /// <response code="400">Subscription cannot be renewed</response>
        [HttpPost]
        [Route("/subscriptions/{subscriptionId}/activate")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ActivateSubscription")]
        public async Task<IActionResult> ActivateSubscription([FromBody] SubscriptionActivateRequest body, [FromRoute][Required] string subscriptionId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _subscriptionsService.ActivateSubscription(body,subscriptionId, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Updates an existing subscription.
        /// </summary>
        /// <param name="body">Updated subscription data</param>
        /// <param name="subscriptionId">ID of the subscription to update</param>
        /// <returns>The updated subscription information</returns>
        /// <response code="200">Subscription updated successfully</response>
        /// <response code="404">Subscription not found</response>
        [HttpPatch]
        [Route("/subscriptions/{subscriptionId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateSubscription")]
        public async Task<IActionResult> UpdateSubscription([FromBody] SubscriptionPatchRequest body, [FromRoute][Required] string subscriptionId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _subscriptionsService.PatchSubscription(body, subscriptionId, zuoraTrackId, async);
            return Ok(result);
        }
    }
}