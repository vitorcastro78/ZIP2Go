using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZIP2GO.Service.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using ZIP2GO.WebAPI.Attributes;
using ZIP2GO.WebAPI.Security;
using Microsoft.Extensions.Logging;
using EasyCaching.Core;

namespace ZIP2GO.WebAPI.Controllers
{
    /// <summary>
    /// Controller para gerenciamento de assinaturas
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionsController : ControllerBaseApi
    {
        private readonly ISubscriptionsService _subscriptionsService;
        private readonly ILogger<SubscriptionsController> _logger;

        public SubscriptionsController(
            ISubscriptionsService subscriptionsService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<SubscriptionsController> logger) : base(httpContext, cache, logger)
        {
            _subscriptionsService = subscriptionsService ?? throw new ArgumentNullException(nameof(subscriptionsService));
            _logger = logger;
        }

        /// <summary>
        /// Ativa uma assinatura
        /// </summary>
        [HttpPost("{subscriptionId}/activate")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ActivateSubscription")]
        [SwaggerResponse(statusCode: 200, type: typeof(Subscription), description: "Assinatura ativada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Assinatura não encontrada")]
        public async Task<IActionResult> ActivateSubscription(
            [FromRoute] string subscriptionId,
            [FromBody] SubscriptionActivateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(subscriptionId, "assinatura");
                ValidateRequestBody(request, "ativação da assinatura");

                var result = await _subscriptionsService.ActivateSubscriptionAsync(subscriptionId, request);
                _logger.LogInformation("Assinatura {SubscriptionId} ativada com sucesso", subscriptionId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Cancela uma assinatura
        /// </summary>
        [HttpPost("{subscriptionId}/cancel")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CancelSubscription")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubscriptionCancelResponse), description: "Assinatura cancelada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Assinatura não encontrada")]
        public async Task<IActionResult> CancelSubscription(
            [FromRoute] string subscriptionId,
            [FromBody] CancelSubscriptionRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(subscriptionId, "assinatura");
                ValidateRequestBody(request, "cancelamento da assinatura");

                var result = await _subscriptionsService.CancelSubscriptionAsync(subscriptionId, request);
                _logger.LogInformation("Assinatura {SubscriptionId} cancelada com sucesso", subscriptionId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Cria uma nova assinatura
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateSubscription")]
        [SwaggerResponse(statusCode: 201, type: typeof(Subscription), description: "Assinatura criada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateSubscription([FromBody] SubscriptionCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação da assinatura");

                var result = await _subscriptionsService.CreateSubscriptionAsync(request);
                _logger.LogInformation("Assinatura criada com sucesso: {SubscriptionId}", result.Id);
                return Created($"/api/subscriptions/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém uma assinatura pelo ID
        /// </summary>
        [HttpGet("{subscriptionId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptionById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Subscription), description: "Assinatura encontrada")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Assinatura não encontrada")]
        public async Task<IActionResult> GetSubscriptionById([FromRoute] string subscriptionId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(subscriptionId, "assinatura");

                var result = await _subscriptionsService.GetSubscriptionByIdAsync(subscriptionId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todas as assinaturas
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptions")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubscriptionListResponse), description: "Lista de assinaturas")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetSubscriptions(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _subscriptionsService.GetSubscriptionsAsync(cursor, pageSize);
                return Ok(result);
            });
        }
    }
} 