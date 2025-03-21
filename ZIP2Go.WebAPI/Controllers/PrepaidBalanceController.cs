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
    /// Controller para gerenciamento de saldo pré-pago
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PrepaidBalanceController : ControllerBaseApi
    {
        private readonly IPrepaidBalanceService _prepaidBalanceService;
        private readonly ILogger<PrepaidBalanceController> _logger;

        public PrepaidBalanceController(
            IPrepaidBalanceService prepaidBalanceService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<PrepaidBalanceController> logger) : base(httpContext, cache, logger)
        {
            _prepaidBalanceService = prepaidBalanceService ?? throw new ArgumentNullException(nameof(prepaidBalanceService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo saldo pré-pago
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreatePrepaidBalance")]
        [SwaggerResponse(statusCode: 201, type: typeof(PrepaidBalance), description: "Saldo pré-pago criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreatePrepaidBalance([FromBody] PrepaidBalanceCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do saldo pré-pago");

                var result = await _prepaidBalanceService.CreatePrepaidBalanceAsync(request);
                _logger.LogInformation("Saldo pré-pago criado com sucesso: {PrepaidBalanceId}", result.Id);
                return Created($"/api/prepaid-balance/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um saldo pré-pago pelo ID
        /// </summary>
        [HttpGet("{prepaidBalanceId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPrepaidBalanceById")]
        [SwaggerResponse(statusCode: 200, type: typeof(PrepaidBalance), description: "Saldo pré-pago encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Saldo pré-pago não encontrado")]
        public async Task<IActionResult> GetPrepaidBalanceById([FromRoute] string prepaidBalanceId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(prepaidBalanceId, "saldo pré-pago");

                var result = await _prepaidBalanceService.GetPrepaidBalanceByIdAsync(prepaidBalanceId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os saldos pré-pagos
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPrepaidBalances")]
        [SwaggerResponse(statusCode: 200, type: typeof(PrepaidBalanceListResponse), description: "Lista de saldos pré-pagos")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetPrepaidBalances(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _prepaidBalanceService.GetPrepaidBalancesAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um saldo pré-pago
        /// </summary>
        [HttpPut("{prepaidBalanceId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdatePrepaidBalance")]
        [SwaggerResponse(statusCode: 200, type: typeof(PrepaidBalance), description: "Saldo pré-pago atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Saldo pré-pago não encontrado")]
        public async Task<IActionResult> UpdatePrepaidBalance(
            [FromRoute] string prepaidBalanceId,
            [FromBody] PrepaidBalanceUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(prepaidBalanceId, "saldo pré-pago");
                ValidateRequestBody(request, "atualização do saldo pré-pago");

                var result = await _prepaidBalanceService.UpdatePrepaidBalanceAsync(prepaidBalanceId, request);
                _logger.LogInformation("Saldo pré-pago {PrepaidBalanceId} atualizado com sucesso", prepaidBalanceId);
                return Ok(result);
            });
        }
    }
} 