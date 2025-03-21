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
    /// Controller para gerenciamento de transações
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBaseApi
    {
        private readonly ITransactionsService _transactionsService;
        private readonly ILogger<TransactionsController> _logger;

        public TransactionsController(
            ITransactionsService transactionsService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<TransactionsController> logger) : base(httpContext, cache, logger)
        {
            _transactionsService = transactionsService ?? throw new ArgumentNullException(nameof(transactionsService));
            _logger = logger;
        }

        /// <summary>
        /// Cria uma nova transação
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateTransaction")]
        [SwaggerResponse(statusCode: 201, type: typeof(Transaction), description: "Transação criada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateTransaction([FromBody] TransactionCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação da transação");

                var result = await _transactionsService.CreateTransactionAsync(request);
                _logger.LogInformation("Transação criada com sucesso: {TransactionId}", result.Id);
                return Created($"/api/transactions/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém uma transação pelo ID
        /// </summary>
        [HttpGet("{transactionId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTransactionById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Transaction), description: "Transação encontrada")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Transação não encontrada")]
        public async Task<IActionResult> GetTransactionById([FromRoute] string transactionId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(transactionId, "transação");

                var result = await _transactionsService.GetTransactionByIdAsync(transactionId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todas as transações
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetTransactions")]
        [SwaggerResponse(statusCode: 200, type: typeof(TransactionListResponse), description: "Lista de transações")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetTransactions(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _transactionsService.GetTransactionsAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza uma transação
        /// </summary>
        [HttpPut("{transactionId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateTransaction")]
        [SwaggerResponse(statusCode: 200, type: typeof(Transaction), description: "Transação atualizada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Transação não encontrada")]
        public async Task<IActionResult> UpdateTransaction(
            [FromRoute] string transactionId,
            [FromBody] TransactionUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(transactionId, "transação");
                ValidateRequestBody(request, "atualização da transação");

                var result = await _transactionsService.UpdateTransactionAsync(transactionId, request);
                _logger.LogInformation("Transação {TransactionId} atualizada com sucesso", transactionId);
                return Ok(result);
            });
        }
    }
} 