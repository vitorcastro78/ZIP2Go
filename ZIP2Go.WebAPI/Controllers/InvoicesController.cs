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
    /// Controller para gerenciamento de faturas
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBaseApi
    {
        private readonly IInvoicesService _invoicesService;
        private readonly ILogger<InvoicesController> _logger;

        public InvoicesController(
            IInvoicesService invoicesService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<InvoicesController> logger) : base(httpContext, cache, logger)
        {
            _invoicesService = invoicesService ?? throw new ArgumentNullException(nameof(invoicesService));
            _logger = logger;
        }

        /// <summary>
        /// Cria uma nova fatura
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateInvoice")]
        [SwaggerResponse(statusCode: 201, type: typeof(Invoice), description: "Fatura criada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateInvoice([FromBody] InvoiceCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação da fatura");

                var result = await _invoicesService.CreateInvoiceAsync(request);
                _logger.LogInformation("Fatura criada com sucesso: {InvoiceId}", result.Id);
                return Created($"/api/invoices/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém uma fatura pelo ID
        /// </summary>
        [HttpGet("{invoiceId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetInvoiceById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Invoice), description: "Fatura encontrada")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Fatura não encontrada")]
        public async Task<IActionResult> GetInvoiceById([FromRoute] string invoiceId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(invoiceId, "fatura");

                var result = await _invoicesService.GetInvoiceByIdAsync(invoiceId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todas as faturas
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetInvoices")]
        [SwaggerResponse(statusCode: 200, type: typeof(InvoiceListResponse), description: "Lista de faturas")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetInvoices(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _invoicesService.GetInvoicesAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza uma fatura
        /// </summary>
        [HttpPut("{invoiceId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateInvoice")]
        [SwaggerResponse(statusCode: 200, type: typeof(Invoice), description: "Fatura atualizada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Fatura não encontrada")]
        public async Task<IActionResult> UpdateInvoice(
            [FromRoute] string invoiceId,
            [FromBody] InvoiceUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(invoiceId, "fatura");
                ValidateRequestBody(request, "atualização da fatura");

                var result = await _invoicesService.UpdateInvoiceAsync(invoiceId, request);
                _logger.LogInformation("Fatura {InvoiceId} atualizada com sucesso", invoiceId);
                return Ok(result);
            });
        }
    }
} 