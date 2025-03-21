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
    /// Controller para gerenciamento de histórico de pagamentos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentHistoryController : ControllerBaseApi
    {
        private readonly IPaymentHistoryService _paymentHistoryService;
        private readonly ILogger<PaymentHistoryController> _logger;

        public PaymentHistoryController(
            IPaymentHistoryService paymentHistoryService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<PaymentHistoryController> logger) : base(httpContext, cache, logger)
        {
            _paymentHistoryService = paymentHistoryService ?? throw new ArgumentNullException(nameof(paymentHistoryService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo registro de histórico de pagamento
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreatePaymentHistory")]
        [SwaggerResponse(statusCode: 201, type: typeof(PaymentHistory), description: "Registro de histórico de pagamento criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreatePaymentHistory([FromBody] PaymentHistoryCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do registro de histórico de pagamento");

                var result = await _paymentHistoryService.CreatePaymentHistoryAsync(request);
                _logger.LogInformation("Registro de histórico de pagamento criado com sucesso: {PaymentHistoryId}", result.Id);
                return Created($"/api/paymenthistory/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um registro de histórico de pagamento pelo ID
        /// </summary>
        [HttpGet("{paymentHistoryId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPaymentHistoryById")]
        [SwaggerResponse(statusCode: 200, type: typeof(PaymentHistory), description: "Registro de histórico de pagamento encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Registro de histórico de pagamento não encontrado")]
        public async Task<IActionResult> GetPaymentHistoryById([FromRoute] string paymentHistoryId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(paymentHistoryId, "registro de histórico de pagamento");

                var result = await _paymentHistoryService.GetPaymentHistoryByIdAsync(paymentHistoryId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os registros de histórico de pagamento
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPaymentHistory")]
        [SwaggerResponse(statusCode: 200, type: typeof(PaymentHistoryListResponse), description: "Lista de registros de histórico de pagamento")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetPaymentHistory(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _paymentHistoryService.GetPaymentHistoryAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um registro de histórico de pagamento
        /// </summary>
        [HttpPut("{paymentHistoryId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdatePaymentHistory")]
        [SwaggerResponse(statusCode: 200, type: typeof(PaymentHistory), description: "Registro de histórico de pagamento atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Registro de histórico de pagamento não encontrado")]
        public async Task<IActionResult> UpdatePaymentHistory(
            [FromRoute] string paymentHistoryId,
            [FromBody] PaymentHistoryUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(paymentHistoryId, "registro de histórico de pagamento");
                ValidateRequestBody(request, "atualização do registro de histórico de pagamento");

                var result = await _paymentHistoryService.UpdatePaymentHistoryAsync(paymentHistoryId, request);
                _logger.LogInformation("Registro de histórico de pagamento {PaymentHistoryId} atualizado com sucesso", paymentHistoryId);
                return Ok(result);
            });
        }
    }
} 