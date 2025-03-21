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
    /// Controller para gerenciamento de planos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PlansController : ControllerBaseApi
    {
        private readonly IPlansService _plansService;
        private readonly ILogger<PlansController> _logger;

        public PlansController(
            IPlansService plansService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<PlansController> logger) : base(httpContext, cache, logger)
        {
            _plansService = plansService ?? throw new ArgumentNullException(nameof(plansService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo plano
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreatePlan")]
        [SwaggerResponse(statusCode: 201, type: typeof(Plan), description: "Plano criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreatePlan([FromBody] PlanCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do plano");

                var result = await _plansService.CreatePlanAsync(request);
                _logger.LogInformation("Plano criado com sucesso: {PlanId}", result.Id);
                return Created($"/api/plans/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um plano pelo ID
        /// </summary>
        [HttpGet("{planId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPlanById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Plan), description: "Plano encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Plano não encontrado")]
        public async Task<IActionResult> GetPlanById([FromRoute] string planId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(planId, "plano");

                var result = await _plansService.GetPlanByIdAsync(planId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os planos
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPlans")]
        [SwaggerResponse(statusCode: 200, type: typeof(PlanListResponse), description: "Lista de planos")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetPlans(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _plansService.GetPlansAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um plano
        /// </summary>
        [HttpPut("{planId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdatePlan")]
        [SwaggerResponse(statusCode: 200, type: typeof(Plan), description: "Plano atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Plano não encontrado")]
        public async Task<IActionResult> UpdatePlan(
            [FromRoute] string planId,
            [FromBody] PlanUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(planId, "plano");
                ValidateRequestBody(request, "atualização do plano");

                var result = await _plansService.UpdatePlanAsync(planId, request);
                _logger.LogInformation("Plano {PlanId} atualizado com sucesso", planId);
                return Ok(result);
            });
        }
    }
} 