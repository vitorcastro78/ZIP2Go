using EasyCaching.Core;
using RestSharp;
using Service.Interfaces;
using ZIP2GO.Client;
using ZIP2GO.Service.Models;
using System.Text;

namespace ZIP2GO.Service
{
    /// <summary>
    /// Serviço responsável por gerenciar itens de documentos de faturamento
    /// </summary>
    public class BillingDocumentItemsService : IBillingDocumentItemsService
    {
        private readonly IEasyCachingProvider _cache;
        private const string CACHE_KEY_PREFIX = "billing_document_items:";
        private const int CACHE_DURATION_MINUTES = 30;

        /// <summary>
        /// Inicializa uma nova instância do serviço de itens de documentos de faturamento
        /// </summary>
        /// <param name="cache">Provedor de cache</param>
        /// <param name="apiClient">Cliente da API (opcional)</param>
        public BillingDocumentItemsService(IEasyCachingProvider cache, ApiClient apiClient = null)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            ApiClient = apiClient ?? Configuration.DefaultApiClient;
        }

        /// <summary>
        /// Inicializa uma nova instância do serviço de itens de documentos de faturamento
        /// </summary>
        /// <param name="basePath">Caminho base da API</param>
        public BillingDocumentItemsService(string basePath)
        {
            if (string.IsNullOrEmpty(basePath))
                throw new ArgumentException("O caminho base não pode ser nulo ou vazio", nameof(basePath));

            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Obtém ou define o cliente da API
        /// </summary>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Obtém o caminho base do cliente da API
        /// </summary>
        /// <param name="basePath">O caminho base</param>
        /// <returns>O caminho base</returns>
        public string GetBasePath(string basePath)
        {
            return ApiClient.BasePath;
        }

        /// <summary>
        /// Lista os itens de documentos de faturamento
        /// </summary>
        /// <param name="cursor">Cursor para paginação</param>
        /// <param name="expand">Campos para expandir na resposta</param>
        /// <param name="filter">Filtros para aplicar na listagem</param>
        /// <param name="sort">Ordenação dos resultados</param>
        /// <param name="pageSize">Tamanho da página (1-99)</param>
        /// <param name="fields">Campos a serem retornados</param>
        /// <param name="taxationItemsFields">Campos dos itens de tributação a serem retornados</param>
        /// <param name="zuoraTrackId">ID de rastreamento da requisição</param>
        /// <param name="zuoraEntityIds">IDs das entidades Zuora</param>
        /// <param name="idempotencyKey">Chave de idempotência</param>
        /// <param name="acceptEncoding">Codificação de aceitação</param>
        /// <param name="contentEncoding">Codificação do conteúdo</param>
        /// <returns>Lista de itens de documentos de faturamento</returns>
        public BillingDocumentItemListResponse GetBillingDocumentItems(
            string cursor, 
            List<string> expand, 
            List<string> filter, 
            List<string> sort, 
            int? pageSize, 
            List<string> fields, 
            List<string> taxationItemsFields, 
            string zuoraTrackId, 
            string zuoraEntityIds, 
            string idempotencyKey, 
            string acceptEncoding, 
            string contentEncoding)
        {
            try
            {
                // Validação do tamanho da página
                if (pageSize.HasValue && (pageSize.Value < 1 || pageSize.Value > 99))
                    throw new ArgumentException("O tamanho da página deve estar entre 1 e 99", nameof(pageSize));

                // Gera chave de cache baseada nos parâmetros
                var cacheKey = GenerateCacheKey(cursor, expand, filter, sort, pageSize, fields, taxationItemsFields);

                // Tenta obter do cache
                var cachedResult = _cache.Get<BillingDocumentItemListResponse>(cacheKey);
                if (cachedResult != null)
                    return cachedResult;

            var path = "/billing_document_items";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

                if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor));
                if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand));
                if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter));
                if (sort != null) queryParams.Add("sort[]", ApiClient.ParameterToString(sort));
                if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize));
                if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields));
                if (taxationItemsFields != null) queryParams.Add("taxation_items.fields[]", ApiClient.ParameterToString(taxationItemsFields));
                if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId));
                if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds));
                if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey));
                if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding));
                if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding));

                // Faz a requisição HTTP
                var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, null, headerParams, new Dictionary<string, string>(), new Dictionary<string, FileParameter>(), new[] { "bearerAuth" });

                if (response.StatusCode >= HttpStatusCode.BadRequest)
                    throw new ApiException((int)response.StatusCode, $"Erro ao obter itens de documentos de faturamento: {response.Content}", response.Content);
                else if (response.StatusCode == 0)
                    throw new ApiException(0, $"Erro ao obter itens de documentos de faturamento: {response.ErrorMessage}", response.ErrorMessage);

                var result = (BillingDocumentItemListResponse)ApiClient.Deserialize(response.Content, typeof(BillingDocumentItemListResponse));

                // Armazena no cache
                _cache.Set(cacheKey, result, TimeSpan.FromMinutes(CACHE_DURATION_MINUTES));

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(500, $"Erro ao processar requisição de itens de documentos de faturamento: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Define o caminho base do cliente da API
        /// </summary>
        /// <param name="basePath">O caminho base</param>
        public void SetBasePath(string basePath)
        {
            if (string.IsNullOrEmpty(basePath))
                throw new ArgumentException("O caminho base não pode ser nulo ou vazio", nameof(basePath));

            ApiClient.BasePath = basePath;
        }

        private string GenerateCacheKey(string cursor, List<string> expand, List<string> filter, List<string> sort, int? pageSize, List<string> fields, List<string> taxationItemsFields)
        {
            var keyBuilder = new StringBuilder(CACHE_KEY_PREFIX);
            keyBuilder.Append(cursor ?? "null");
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", expand ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", filter ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", sort ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(pageSize?.ToString() ?? "null");
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", fields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", taxationItemsFields ?? new List<string>()));

            return keyBuilder.ToString();
        }
    }
}