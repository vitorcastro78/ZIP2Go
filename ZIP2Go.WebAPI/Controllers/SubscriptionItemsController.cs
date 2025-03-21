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
    /// Controller para gerenciamento de itens de assinatura
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionItemsController : ControllerBaseApi
    {
        private readonly ISubscriptionItemsService _subscriptionItemsService;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IEasyCachingProvider _cache;
        private readonly ILogger<SubscriptionItemsController> _logger;

        public SubscriptionItemsController(
            ISubscriptionItemsService subscriptionItemsService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<SubscriptionItemsController> logger) : base(httpContext, cache, logger)
        {
            _subscriptionItemsService = subscriptionItemsService ?? throw new ArgumentNullException(nameof(subscriptionItemsService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo item de assinatura
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateSubscriptionItem")]
        [SwaggerResponse(statusCode: 201, type: typeof(SubscriptionItem), description: "Item de assinatura criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateSubscriptionItem([FromBody] SubscriptionItemCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do item de assinatura");

                var result = await _subscriptionItemsService.CreateSubscriptionItemAsync(request);
                _logger.LogInformation("Item de assinatura criado com sucesso: {SubscriptionItemId}", result.Id);
                return Created($"/api/subscriptionitems/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um item de assinatura pelo ID
        /// </summary>
        [HttpGet("{subscriptionItemId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptionItemById")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubscriptionItem), description: "Item de assinatura encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Item de assinatura não encontrado")]
        public async Task<IActionResult> GetSubscriptionItemById([FromRoute] string subscriptionItemId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(subscriptionItemId, "item de assinatura");

                var result = await _subscriptionItemsService.GetSubscriptionItemByIdAsync(subscriptionItemId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os itens de assinatura
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSubscriptionItems")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubscriptionItemListResponse), description: "Lista de itens de assinatura")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetSubscriptionItems(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _subscriptionItemsService.GetSubscriptionItemsAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um item de assinatura
        /// </summary>
        [HttpPut("{subscriptionItemId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateSubscriptionItem")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubscriptionItem), description: "Item de assinatura atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Item de assinatura não encontrado")]
        public async Task<IActionResult> UpdateSubscriptionItem(
            [FromRoute] string subscriptionItemId,
            [FromBody] SubscriptionItemUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(subscriptionItemId, "item de assinatura");
                ValidateRequestBody(request, "atualização do item de assinatura");

                var result = await _subscriptionItemsService.UpdateSubscriptionItemAsync(subscriptionItemId, request);
                _logger.LogInformation("Item de assinatura {SubscriptionItemId} atualizado com sucesso", subscriptionItemId);
                return Ok(result);
            });
        }
    }
} 