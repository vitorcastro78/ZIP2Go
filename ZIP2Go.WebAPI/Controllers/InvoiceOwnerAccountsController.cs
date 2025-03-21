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
    /// Controller para gerenciamento de contas proprietárias de faturas
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceOwnerAccountsController : ControllerBaseApi
    {
        private readonly IInvoiceOwnerAccountsService _invoiceOwnerAccountsService;
        private readonly ILogger<InvoiceOwnerAccountsController> _logger;

        public InvoiceOwnerAccountsController(
            IInvoiceOwnerAccountsService invoiceOwnerAccountsService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<InvoiceOwnerAccountsController> logger) : base(httpContext, cache, logger)
        {
            _invoiceOwnerAccountsService = invoiceOwnerAccountsService ?? throw new ArgumentNullException(nameof(invoiceOwnerAccountsService));
            _logger = logger;
        }

        /// <summary>
        /// Cria uma nova conta proprietária de fatura
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateInvoiceOwnerAccount")]
        [SwaggerResponse(statusCode: 201, type: typeof(InvoiceOwnerAccount), description: "Conta proprietária de fatura criada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateInvoiceOwnerAccount([FromBody] InvoiceOwnerAccountCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação da conta proprietária de fatura");

                var result = await _invoiceOwnerAccountsService.CreateInvoiceOwnerAccountAsync(request);
                _logger.LogInformation("Conta proprietária de fatura criada com sucesso: {InvoiceOwnerAccountId}", result.Id);
                return Created($"/api/invoiceowneraccounts/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém uma conta proprietária de fatura pelo ID
        /// </summary>
        [HttpGet("{invoiceOwnerAccountId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetInvoiceOwnerAccountById")]
        [SwaggerResponse(statusCode: 200, type: typeof(InvoiceOwnerAccount), description: "Conta proprietária de fatura encontrada")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Conta proprietária de fatura não encontrada")]
        public async Task<IActionResult> GetInvoiceOwnerAccountById([FromRoute] string invoiceOwnerAccountId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(invoiceOwnerAccountId, "conta proprietária de fatura");

                var result = await _invoiceOwnerAccountsService.GetInvoiceOwnerAccountByIdAsync(invoiceOwnerAccountId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todas as contas proprietárias de fatura
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetInvoiceOwnerAccounts")]
        [SwaggerResponse(statusCode: 200, type: typeof(InvoiceOwnerAccountListResponse), description: "Lista de contas proprietárias de fatura")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetInvoiceOwnerAccounts(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _invoiceOwnerAccountsService.GetInvoiceOwnerAccountsAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza uma conta proprietária de fatura
        /// </summary>
        [HttpPut("{invoiceOwnerAccountId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateInvoiceOwnerAccount")]
        [SwaggerResponse(statusCode: 200, type: typeof(InvoiceOwnerAccount), description: "Conta proprietária de fatura atualizada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Conta proprietária de fatura não encontrada")]
        public async Task<IActionResult> UpdateInvoiceOwnerAccount(
            [FromRoute] string invoiceOwnerAccountId,
            [FromBody] InvoiceOwnerAccountUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(invoiceOwnerAccountId, "conta proprietária de fatura");
                ValidateRequestBody(request, "atualização da conta proprietária de fatura");

                var result = await _invoiceOwnerAccountsService.UpdateInvoiceOwnerAccountAsync(invoiceOwnerAccountId, request);
                _logger.LogInformation("Conta proprietária de fatura {InvoiceOwnerAccountId} atualizada com sucesso", invoiceOwnerAccountId);
                return Ok(result);
            });
        }
    }
} 