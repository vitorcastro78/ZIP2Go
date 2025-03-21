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
    /// Controller para gerenciamento de pagamentos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBaseApi
    {
        private readonly IPaymentsService _paymentsService;
        private readonly ILogger<PaymentsController> _logger;

        public PaymentsController(
            IPaymentsService paymentsService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<PaymentsController> logger) : base(httpContext, cache, logger)
        {
            _paymentsService = paymentsService ?? throw new ArgumentNullException(nameof(paymentsService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo pagamento
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreatePayment")]
        [SwaggerResponse(statusCode: 201, type: typeof(Payment), description: "Pagamento criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreatePayment([FromBody] PaymentCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do pagamento");

                var result = await _paymentsService.CreatePaymentAsync(request);
                _logger.LogInformation("Pagamento criado com sucesso: {PaymentId}", result.Id);
                return Created($"/api/payments/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um pagamento pelo ID
        /// </summary>
        [HttpGet("{paymentId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPaymentById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Payment), description: "Pagamento encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Pagamento não encontrado")]
        public async Task<IActionResult> GetPaymentById([FromRoute] string paymentId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(paymentId, "pagamento");

                var result = await _paymentsService.GetPaymentByIdAsync(paymentId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os pagamentos
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPayments")]
        [SwaggerResponse(statusCode: 200, type: typeof(PaymentListResponse), description: "Lista de pagamentos")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetPayments(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _paymentsService.GetPaymentsAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um pagamento
        /// </summary>
        [HttpPut("{paymentId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdatePayment")]
        [SwaggerResponse(statusCode: 200, type: typeof(Payment), description: "Pagamento atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Pagamento não encontrado")]
        public async Task<IActionResult> UpdatePayment(
            [FromRoute] string paymentId,
            [FromBody] PaymentUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(paymentId, "pagamento");
                ValidateRequestBody(request, "atualização do pagamento");

                var result = await _paymentsService.UpdatePaymentAsync(paymentId, request);
                _logger.LogInformation("Pagamento {PaymentId} atualizado com sucesso", paymentId);
                return Ok(result);
            });
        }
    }
} 