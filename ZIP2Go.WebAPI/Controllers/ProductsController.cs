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
    /// Controller para gerenciamento de produtos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBaseApi
    {
        private readonly IProductsService _productsService;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(
            IProductsService productsService,
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger<ProductsController> logger) : base(httpContext, cache, logger)
        {
            _productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));
            _logger = logger;
        }

        /// <summary>
        /// Cria um novo produto
        /// </summary>
        [HttpPost]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateProduct")]
        [SwaggerResponse(statusCode: 201, type: typeof(Product), description: "Produto criado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> CreateProduct([FromBody] ProductCreateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateRequestBody(request, "criação do produto");

                var result = await _productsService.CreateProductAsync(request);
                _logger.LogInformation("Produto criado com sucesso: {ProductId}", result.Id);
                return Created($"/api/products/{result.Id}", result);
            });
        }

        /// <summary>
        /// Obtém um produto pelo ID
        /// </summary>
        [HttpGet("{productId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetProductById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Product), description: "Produto encontrado")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Produto não encontrado")]
        public async Task<IActionResult> GetProductById([FromRoute] string productId)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(productId, "produto");

                var result = await _productsService.GetProductByIdAsync(productId);
                return Ok(result);
            });
        }

        /// <summary>
        /// Lista todos os produtos
        /// </summary>
        [HttpGet]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetProducts")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProductListResponse), description: "Lista de produtos")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        public async Task<IActionResult> GetProducts(
            [FromQuery] string cursor = null,
            [FromQuery][Range(1, 99)] int? pageSize = null)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                var result = await _productsService.GetProductsAsync(cursor, pageSize);
                return Ok(result);
            });
        }

        /// <summary>
        /// Atualiza um produto
        /// </summary>
        [HttpPut("{productId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateProduct")]
        [SwaggerResponse(statusCode: 200, type: typeof(Product), description: "Produto atualizado com sucesso")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Requisição inválida")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Não autorizado")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Produto não encontrado")]
        public async Task<IActionResult> UpdateProduct(
            [FromRoute] string productId,
            [FromBody] ProductUpdateRequest request)
        {
            return await ExecuteWithErrorHandlingAsync(async () =>
            {
                ValidateResourceId(productId, "produto");
                ValidateRequestBody(request, "atualização do produto");

                var result = await _productsService.UpdateProductAsync(productId, request);
                _logger.LogInformation("Produto {ProductId} atualizado com sucesso", productId);
                return Ok(result);
            });
        }
    }
} 