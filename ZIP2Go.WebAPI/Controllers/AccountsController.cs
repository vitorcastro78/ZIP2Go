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
    /// Controller para gerenciamento de contas
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBaseApi
    {
        private readonly IAccountsService _accountsService;
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(
            IAccountsService accountsService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<AccountsController> logger) : base(httpContext, cache, logger)
        {
            _accountsService = accountsService ?? throw new ArgumentNullException(nameof(accountsService));
            _logger = logger;
        }

        /// <summary>
        /// Cria uma nova conta
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateAccount")]
        [SwaggerResponse(statusCode: 201, type: typeof(Account), description: "Conta criada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateAccount([FromBody] AccountCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação da conta");

                var result = await _accountsService.CreateAccountAsync(request);
                _logger.LogInformation("Conta criada com sucesso: {AccountId}", result.Id);
                return Created($"/api/accounts/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém uma conta pelo ID
        /// </summary>
        [HttpGet("{accountId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetAccountById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Account), description: "Conta encontrada")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Conta não encontrada")]
        public async Task<IActionResult> GetAccountById([FromRoute] string accountId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(accountId, "conta");

                var result = await _accountsService.GetAccountByIdAsync(accountId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todas as contas
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetAccounts")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountListResponse), description: "Lista de contas")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetAccounts(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _accountsService.GetAccountsAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza uma conta
        /// </summary>
        [HttpPut("{accountId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateAccount")]
        [SwaggerResponse(statusCode: 200, type: typeof(Account), description: "Conta atualizada com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Conta não encontrada")]
        public async Task<IActionResult> UpdateAccount(
            [FromRoute] string accountId,
            [FromBody] AccountUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(accountId, "conta");
                ValidateRequestBody(request, "atualização da conta");

                var result = await _accountsService.UpdateAccountAsync(accountId, request);
                _logger.LogInformation("Conta {AccountId} atualizada com sucesso", accountId);
                return Ok(result);
            });
        }
    }
} 