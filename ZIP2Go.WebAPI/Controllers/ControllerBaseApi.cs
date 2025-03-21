using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EasyCaching.Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ZIP2GO.WebAPI.Controllers
{
    /// <summary>
    /// Classe base para controllers da API com funcionalidades comuns
    /// </summary>
    public abstract class ControllerBaseApi : ControllerBase
    {
        protected readonly IHttpContextAccessor _httpContext;
        protected readonly IEasyCachingProvider _cache;
        protected readonly ILogger _logger;

        protected ControllerBaseApi(
            IHttpContextAccessor httpContext,
            IEasyCachingProvider cache,
            ILogger logger)
        {
            _httpContext = httpContext ?? throw new ArgumentNullException(nameof(httpContext));
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Executa uma operação com cache
        /// </summary>
        protected async Task<IActionResult> ExecuteWithCacheAsync<T>(
            string cacheKey,
            Func<Task<T>> operation,
            TimeSpan? cacheDuration = null)
        {
            try
            {
                var cachedResult = await _cache.GetAsync<T>(cacheKey);
                if (cachedResult != null)
                {
                    _logger.LogInformation("Retornando resultado do cache para a chave: {CacheKey}", cacheKey);
                    return Ok(cachedResult);
                }

                var result = await operation();
                if (result != null)
                {
                    await _cache.SetAsync(cacheKey, result, cacheDuration ?? TimeSpan.FromMinutes(30));
                    _logger.LogInformation("Resultado armazenado em cache com a chave: {CacheKey}", cacheKey);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao executar operação com cache para a chave: {CacheKey}", cacheKey);
                return StatusCode(500, new ErrorResponse { Message = "Erro ao processar a requisição com cache" });
            }
        }

        /// <summary>
        /// Executa uma operação com tratamento de erros
        /// </summary>
        protected async Task<IActionResult> ExecuteWithErrorHandlingAsync(Func<Task<IActionResult>> operation)
        {
            try
            {
                return await operation();
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Erro de validação: {Message}", ex.Message);
                return BadRequest(new ErrorResponse { Message = ex.Message });
            }
            catch (UnauthorizedAccessException ex)
            {
                _logger.LogWarning(ex, "Acesso não autorizado: {Message}", ex.Message);
                return StatusCode(401, new ErrorResponse { Message = "Acesso não autorizado" });
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogWarning(ex, "Recurso não encontrado: {Message}", ex.Message);
                return NotFound(new ErrorResponse { Message = "Recurso não encontrado" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro interno ao processar a requisição: {Message}", ex.Message);
                return StatusCode(500, new ErrorResponse { Message = "Erro interno ao processar a requisição" });
            }
        }

        /// <summary>
        /// Valida parâmetros de paginação
        /// </summary>
        protected void ValidatePaginationParameters(int? pageSize)
        {
            if (pageSize.HasValue && (pageSize.Value < 1 || pageSize.Value > 99))
            {
                throw new ArgumentException("O tamanho da página deve estar entre 1 e 99");
            }
        }

        /// <summary>
        /// Valida ID de recurso
        /// </summary>
        protected void ValidateResourceId(string id, string resourceName)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException($"O ID do {resourceName} é obrigatório");
            }
        }

        /// <summary>
        /// Valida corpo da requisição
        /// </summary>
        protected void ValidateRequestBody<T>(T request, string resourceName)
        {
            if (request == null)
            {
                throw new ArgumentException($"O corpo da requisição para {resourceName} é obrigatório");
            }
        }
    }
} 