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
    /// Controller para gerenciamento de endereços de cobrança
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BillToController : ControllerBaseApi
    {
        private readonly IBillToService _billToService;
        private readonly ILogger<BillToController> _logger;

        public BillToController(
            IBillToService billToService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<BillToController> logger) : base(httpContext, cache, logger)
        {
            _billToService = billToService ?? throw new ArgumentNullException(nameof(billToService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo endereço de cobrança
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateBillTo")]
        [SwaggerResponse(statusCode: 201, type: typeof(BillTo), description: "Endereço de cobrança criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateBillTo([FromBody] BillToCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do endereço de cobrança");

                var result = await _billToService.CreateBillToAsync(request);
                _logger.LogInformation("Endereço de cobrança criado com sucesso: {BillToId}", result.Id);
                return Created($"/api/billto/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um endereço de cobrança pelo ID
        /// </summary>
        [HttpGet("{billToId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetBillToById")]
        [SwaggerResponse(statusCode: 200, type: typeof(BillTo), description: "Endereço de cobrança encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Endereço de cobrança não encontrado")]
        public async Task<IActionResult> GetBillToById([FromRoute] string billToId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(billToId, "endereço de cobrança");

                var result = await _billToService.GetBillToByIdAsync(billToId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os endereços de cobrança
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetBillTo")]
        [SwaggerResponse(statusCode: 200, type: typeof(BillToListResponse), description: "Lista de endereços de cobrança")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetBillTo(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _billToService.GetBillToAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um endereço de cobrança
        /// </summary>
        [HttpPut("{billToId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateBillTo")]
        [SwaggerResponse(statusCode: 200, type: typeof(BillTo), description: "Endereço de cobrança atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Endereço de cobrança não encontrado")]
        public async Task<IActionResult> UpdateBillTo(
            [FromRoute] string billToId,
            [FromBody] BillToUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(billToId, "endereço de cobrança");
                ValidateRequestBody(request, "atualização do endereço de cobrança");

                var result = await _billToService.UpdateBillToAsync(billToId, request);
                _logger.LogInformation("Endereço de cobrança {BillToId} atualizado com sucesso", billToId);
                return Ok(result);
            });
        }
    }
} 