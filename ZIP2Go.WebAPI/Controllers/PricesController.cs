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
    /// Controller para gerenciamento de preços
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PricesController : ControllerBaseApi
    {
        private readonly IPricesService _pricesService;
        private readonly ILogger<PricesController> _logger;

        public PricesController(
            IPricesService pricesService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<PricesController> logger) : base(httpContext, cache, logger)
        {
            _pricesService = pricesService ?? throw new ArgumentNullException(nameof(pricesService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo preço
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreatePrice")]
        [SwaggerResponse(statusCode: 201, type: typeof(Price), description: "Preço criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreatePrice([FromBody] PriceCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do preço");

                var result = await _pricesService.CreatePriceAsync(request);
                _logger.LogInformation("Preço criado com sucesso: {PriceId}", result.Id);
                return Created($"/api/prices/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um preço pelo ID
        /// </summary>
        [HttpGet("{priceId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPriceById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Price), description: "Preço encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Preço não encontrado")]
        public async Task<IActionResult> GetPriceById([FromRoute] string priceId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(priceId, "preço");

                var result = await _pricesService.GetPriceByIdAsync(priceId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os preços
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPrices")]
        [SwaggerResponse(statusCode: 200, type: typeof(PriceListResponse), description: "Lista de preços")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetPrices(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _pricesService.GetPricesAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um preço
        /// </summary>
        [HttpPut("{priceId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdatePrice")]
        [SwaggerResponse(statusCode: 200, type: typeof(Price), description: "Preço atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Preço não encontrado")]
        public async Task<IActionResult> UpdatePrice(
            [FromRoute] string priceId,
            [FromBody] PriceUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(priceId, "preço");
                ValidateRequestBody(request, "atualização do preço");

                var result = await _pricesService.UpdatePriceAsync(priceId, request);
                _logger.LogInformation("Preço {PriceId} atualizado com sucesso", priceId);
                return Ok(result);
            });
        }
    }
} 