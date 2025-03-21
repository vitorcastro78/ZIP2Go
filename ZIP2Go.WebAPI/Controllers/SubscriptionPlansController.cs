using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZIP2GO.Service.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using ZIP2GO.WebAPI.Attributes;
using ZIP2GO.WebAPI.Security;
using Microsoft.Extensions.Logging;
using EasyCaching.Core;

namespace ZIP2GO.WebAPI.Controllers
{
    /// <summary>
    /// Controller para gerenciamento de planos de assinatura
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionPlansController : ControllerBaseApi
    {
        private readonly ISubscriptionPlansService _subscriptionPlansService;
        private readonly ILogger<SubscriptionPlansController> _logger;

        public SubscriptionPlansController(
            ISubscriptionPlansService subscriptionPlansService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<SubscriptionPlansController> logger) : base(httpContext, cache, logger)
        {
            _subscriptionPlansService = subscriptionPlansService ?? throw new ArgumentNullException(nameof(subscriptionPlansService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo plano de assinatura
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateSubscriptionPlan")]
        [SwaggerResponse(statusCode: 201, type: typeof(SubscriptionPlan), description: "Plano de assinatura criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateSubscriptionPlan([FromBody] SubscriptionPlanCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do plano de assinatura");

                var result = await _subscriptionPlansService.CreateSubscriptionPlanAsync(request);
                _logger.LogInformation("Plano de assinatura criado com sucesso: {SubscriptionPlanId}", result.Id);
                return Created($"/api/subscriptionplans/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um plano de assinatura pelo ID
        /// </summary>
        [HttpGet("{subscriptionPlanId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptionPlanById")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubscriptionPlan), description: "Plano de assinatura encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Plano de assinatura não encontrado")]
        public async Task<IActionResult> GetSubscriptionPlanById([FromRoute] string subscriptionPlanId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(subscriptionPlanId, "plano de assinatura");

                var result = await _subscriptionPlansService.GetSubscriptionPlanByIdAsync(subscriptionPlanId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os planos de assinatura
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptionPlans")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubscriptionPlanListResponse), description: "Lista de planos de assinatura")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetSubscriptionPlans(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _subscriptionPlansService.GetSubscriptionPlansAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um plano de assinatura
        /// </summary>
        [HttpPut("{subscriptionPlanId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateSubscriptionPlan")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubscriptionPlan), description: "Plano de assinatura atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Plano de assinatura não encontrado")]
        public async Task<IActionResult> UpdateSubscriptionPlan(
            [FromRoute] string subscriptionPlanId,
            [FromBody] SubscriptionPlanUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(subscriptionPlanId, "plano de assinatura");
                ValidateRequestBody(request, "atualização do plano de assinatura");

                var result = await _subscriptionPlansService.UpdateSubscriptionPlanAsync(subscriptionPlanId, request);
                _logger.LogInformation("Plano de assinatura {SubscriptionPlanId} atualizado com sucesso", subscriptionPlanId);
                return Ok(result);
            });
        }
    }
} 