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
    /// Controller para gerenciamento de períodos de validade
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ValidityPeriodsController : ControllerBaseApi
    {
        private readonly IValidityPeriodsService _validityPeriodsService;
        private readonly ILogger<ValidityPeriodsController> _logger;

        public ValidityPeriodsController(
            IValidityPeriodsService validityPeriodsService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<ValidityPeriodsController> logger) : base(httpContext, cache, logger)
        {
            _validityPeriodsService = validityPeriodsService ?? throw new ArgumentNullException(nameof(validityPeriodsService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo período de validade
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateValidityPeriod")]
        [SwaggerResponse(statusCode: 201, type: typeof(ValidityPeriod), description: "Período de validade criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateValidityPeriod([FromBody] ValidityPeriodCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do período de validade");

                var result = await _validityPeriodsService.CreateValidityPeriodAsync(request);
                _logger.LogInformation("Período de validade criado com sucesso: {ValidityPeriodId}", result.Id);
                return Created($"/api/validityperiods/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um período de validade pelo ID
        /// </summary>
        [HttpGet("{validityPeriodId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetValidityPeriodById")]
        [SwaggerResponse(statusCode: 200, type: typeof(ValidityPeriod), description: "Período de validade encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Período de validade não encontrado")]
        public async Task<IActionResult> GetValidityPeriodById([FromRoute] string validityPeriodId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(validityPeriodId, "período de validade");

                var result = await _validityPeriodsService.GetValidityPeriodByIdAsync(validityPeriodId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os períodos de validade
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetValidityPeriods")]
        [SwaggerResponse(statusCode: 200, type: typeof(ValidityPeriodListResponse), description: "Lista de períodos de validade")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetValidityPeriods(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _validityPeriodsService.GetValidityPeriodsAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um período de validade
        /// </summary>
        [HttpPut("{validityPeriodId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateValidityPeriod")]
        [SwaggerResponse(statusCode: 200, type: typeof(ValidityPeriod), description: "Período de validade atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Período de validade não encontrado")]
        public async Task<IActionResult> UpdateValidityPeriod(
            [FromRoute] string validityPeriodId,
            [FromBody] ValidityPeriodUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(validityPeriodId, "período de validade");
                ValidateRequestBody(request, "atualização do período de validade");

                var result = await _validityPeriodsService.UpdateValidityPeriodAsync(validityPeriodId, request);
                _logger.LogInformation("Período de validade {ValidityPeriodId} atualizado com sucesso", validityPeriodId);
                return Ok(result);
            });
        }
    }
} 