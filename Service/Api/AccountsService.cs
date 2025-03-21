using EasyCaching.Core;
using RestSharp;
using Service.Interfaces;
using ZIP2GO.Client;
using ZIP2GO.Service.Models;
using System.Text;

namespace ZIP2GO.Service
{
    /// <summary>
    /// Serviço responsável por gerenciar contas
    /// </summary>
    public class AccountsService : IAccountsService
    {
        private readonly IEasyCachingProvider _cache;
        private const string CACHE_KEY_PREFIX = "accounts:";
        private const int CACHE_DURATION_MINUTES = 30;

        /// <summary>
        /// Inicializa uma nova instância do serviço de contas
        /// </summary>
        /// <param name="cache">Provedor de cache</param>
        /// <param name="apiClient">Cliente da API (opcional)</param>
        public AccountsService(IEasyCachingProvider cache, ApiClient apiClient = null)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            ApiClient = apiClient ?? Configuration.DefaultApiClient;
        }

        /// <summary>
        /// Inicializa uma nova instância do serviço de contas
        /// </summary>
        /// <param name="basePath">Caminho base da API</param>
        public AccountsService(string basePath)
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
        /// Cria uma nova conta
        /// </summary>
        /// <param name="body">Dados da conta a ser criada</param>
        /// <param name="zuoraTrackId">ID de rastreamento da requisição</param>
        /// <param name="async">Se true, a requisição será assíncrona</param>
        /// <param name="zuoraEntityIds">IDs das entidades Zuora</param>
        /// <param name="idempotencyKey">Chave de idempotência</param>
        /// <param name="acceptEncoding">Codificação de aceitação</param>
        /// <param name="contentEncoding">Codificação do conteúdo</param>
        /// <param name="fields">Campos a serem retornados</param>
        /// <param name="subscriptionsFields">Campos das assinaturas a serem retornados</param>
        /// <param name="subscriptionPlansFields">Campos dos planos de assinatura a serem retornados</param>
        /// <param name="subscriptionItemsFields">Campos dos itens de assinatura a serem retornados</param>
        /// <param name="invoiceOwnerAccountFields">Campos da conta proprietária da fatura a serem retornados</param>
        /// <param name="planFields">Campos do plano a serem retornados</param>
        /// <param name="paymentMethodsFields">Campos dos métodos de pagamento a serem retornados</param>
        /// <param name="paymentsFields">Campos dos pagamentos a serem retornados</param>
        /// <param name="billingDocumentsFields">Campos dos documentos de faturamento a serem retornados</param>
        /// <param name="billingDocumentItemsFields">Campos dos itens de documentos de faturamento a serem retornados</param>
        /// <param name="billToFields">Campos do endereço de cobrança a serem retornados</param>
        /// <param name="soldToFields">Campos do endereço de venda a serem retornados</param>
        /// <param name="defaultPaymentMethodFields">Campos do método de pagamento padrão a serem retornados</param>
        /// <param name="usageRecordsFields">Campos dos registros de uso a serem retornados</param>
        /// <param name="invoicesFields">Campos das faturas a serem retornados</param>
        /// <param name="creditMemosFields">Campos das notas de crédito a serem retornados</param>
        /// <param name="debitMemosFields">Campos das notas de débito a serem retornados</param>
        /// <param name="prepaidBalanceFields">Campos do saldo pré-pago a serem retornados</param>
        /// <param name="transactionsFields">Campos das transações a serem retornados</param>
        /// <param name="expand">Campos para expandir na resposta</param>
        /// <param name="filter">Filtros para aplicar na listagem</param>
        /// <param name="pageSize">Tamanho da página (1-99)</param>
        /// <returns>Conta criada</returns>
        public Account CreateAccount(
            AccountCreateRequest body,
            string zuoraTrackId,
            bool? async,
            string zuoraEntityIds,
            string idempotencyKey,
            string acceptEncoding,
            string contentEncoding,
            List<string> fields,
            List<string> subscriptionsFields,
            List<string> subscriptionPlansFields,
            List<string> subscriptionItemsFields,
            List<string> invoiceOwnerAccountFields,
            List<string> planFields,
            List<string> paymentMethodsFields,
            List<string> paymentsFields,
            List<string> billingDocumentsFields,
            List<string> billingDocumentItemsFields,
            List<string> billToFields,
            List<string> soldToFields,
            List<string> defaultPaymentMethodFields,
            List<string> usageRecordsFields,
            List<string> invoicesFields,
            List<string> creditMemosFields,
            List<string> debitMemosFields,
            List<string> prepaidBalanceFields,
            List<string> transactionsFields,
            List<string> expand,
            List<string> filter,
            int? pageSize)
        {
            try
            {
                if (body == null)
                    throw new ArgumentNullException(nameof(body), "O corpo da requisição não pode ser nulo");

                if (pageSize.HasValue && (pageSize.Value < 1 || pageSize.Value > 99))
                    throw new ArgumentException("O tamanho da página deve estar entre 1 e 99", nameof(pageSize));

            var path = "/accounts";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

                if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields));
                if (subscriptionsFields != null) queryParams.Add("subscriptions.fields[]", ApiClient.ParameterToString(subscriptionsFields));
                if (subscriptionPlansFields != null) queryParams.Add("subscription_plans.fields[]", ApiClient.ParameterToString(subscriptionPlansFields));
                if (subscriptionItemsFields != null) queryParams.Add("subscription_items.fields[]", ApiClient.ParameterToString(subscriptionItemsFields));
                if (invoiceOwnerAccountFields != null) queryParams.Add("invoice_owner_account.fields[]", ApiClient.ParameterToString(invoiceOwnerAccountFields));
                if (planFields != null) queryParams.Add("plan.fields[]", ApiClient.ParameterToString(planFields));
                if (paymentMethodsFields != null) queryParams.Add("payment_methods.fields[]", ApiClient.ParameterToString(paymentMethodsFields));
                if (paymentsFields != null) queryParams.Add("payments.fields[]", ApiClient.ParameterToString(paymentsFields));
                if (billingDocumentsFields != null) queryParams.Add("billing_documents.fields[]", ApiClient.ParameterToString(billingDocumentsFields));
                if (billingDocumentItemsFields != null) queryParams.Add("billing_document_items.fields[]", ApiClient.ParameterToString(billingDocumentItemsFields));
                if (billToFields != null) queryParams.Add("bill_to.fields[]", ApiClient.ParameterToString(billToFields));
                if (soldToFields != null) queryParams.Add("sold_to.fields[]", ApiClient.ParameterToString(soldToFields));
                if (defaultPaymentMethodFields != null) queryParams.Add("default_payment_method.fields[]", ApiClient.ParameterToString(defaultPaymentMethodFields));
                if (usageRecordsFields != null) queryParams.Add("usage_records.fields[]", ApiClient.ParameterToString(usageRecordsFields));
                if (invoicesFields != null) queryParams.Add("invoices.fields[]", ApiClient.ParameterToString(invoicesFields));
                if (creditMemosFields != null) queryParams.Add("credit_memos.fields[]", ApiClient.ParameterToString(creditMemosFields));
                if (debitMemosFields != null) queryParams.Add("debit_memos.fields[]", ApiClient.ParameterToString(debitMemosFields));
                if (prepaidBalanceFields != null) queryParams.Add("prepaid_balance.fields[]", ApiClient.ParameterToString(prepaidBalanceFields));
                if (transactionsFields != null) queryParams.Add("transactions.fields[]", ApiClient.ParameterToString(transactionsFields));
                if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand));
                if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter));
                if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize));
                if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId));
                if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async));
                if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds));
                if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey));
                if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding));
                if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding));

                var postBody = ApiClient.Serialize(body);

                var response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, new Dictionary<string, string>(), new Dictionary<string, FileParameter>(), new[] { "bearerAuth" });

                if (response.StatusCode >= HttpStatusCode.BadRequest)
                    throw new ApiException((int)response.StatusCode, $"Erro ao criar conta: {response.Content}", response.Content);
                else if (response.StatusCode == 0)
                    throw new ApiException(0, $"Erro ao criar conta: {response.ErrorMessage}", response.ErrorMessage);

                var result = (Account)ApiClient.Deserialize(response.Content, typeof(Account));

                // Invalida o cache de listagem de contas
                _cache.RemoveByPrefix(CACHE_KEY_PREFIX);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(500, $"Erro ao processar requisição de criação de conta: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Exclui uma conta permanentemente
        /// </summary>
        /// <param name="accountId">Identificador da conta (número da conta ou ID)</param>
        /// <param name="zuoraTrackId">ID de rastreamento da requisição</param>
        /// <param name="async">Se true, a requisição será assíncrona</param>
        /// <param name="zuoraEntityIds">IDs das entidades Zuora</param>
        /// <param name="idempotencyKey">Chave de idempotência</param>
        /// <param name="acceptEncoding">Codificação de aceitação</param>
        /// <param name="contentEncoding">Codificação do conteúdo</param>
        public void DeleteAccount(
            string accountId,
            string zuoraTrackId,
            bool? async,
            string zuoraEntityIds,
            string idempotencyKey,
            string acceptEncoding,
            string contentEncoding)
        {
            try
            {
                if (string.IsNullOrEmpty(accountId))
                    throw new ArgumentException("O ID da conta não pode ser nulo ou vazio", nameof(accountId));

            var path = "/accounts/{account_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", ApiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

                if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId));
                if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async));
                if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds));
                if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey));
                if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding));
                if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding));

                var response = (RestResponse)ApiClient.CallApi(path, Method.Delete, queryParams, null, headerParams, new Dictionary<string, string>(), new Dictionary<string, FileParameter>(), new[] { "bearerAuth" });

                if (response.StatusCode >= HttpStatusCode.BadRequest)
                    throw new ApiException((int)response.StatusCode, $"Erro ao excluir conta: {response.Content}", response.Content);
                else if (response.StatusCode == 0)
                    throw new ApiException(0, $"Erro ao excluir conta: {response.ErrorMessage}", response.ErrorMessage);

                // Invalida o cache de listagem de contas e da conta específica
                _cache.RemoveByPrefix(CACHE_KEY_PREFIX);
                _cache.Remove($"{CACHE_KEY_PREFIX}{accountId}");
            }
            catch (Exception ex)
            {
                throw new ApiException(500, $"Erro ao processar requisição de exclusão de conta: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Gera documentos de faturamento para uma conta
        /// </summary>
        /// <param name="body">Dados para geração dos documentos</param>
        /// <param name="accountId">Identificador da conta (número da conta ou ID)</param>
        /// <param name="zuoraTrackId">ID de rastreamento da requisição</param>
        /// <param name="async">Se true, a requisição será assíncrona</param>
        /// <param name="zuoraEntityIds">IDs das entidades Zuora</param>
        /// <param name="idempotencyKey">Chave de idempotência</param>
        /// <param name="acceptEncoding">Codificação de aceitação</param>
        /// <param name="contentEncoding">Codificação do conteúdo</param>
        /// <returns>Resposta da geração dos documentos</returns>
        public GenerateBillingDocumentsAccountResponse GenerateBillingDocuments(
            GenerateBillingDocumentsAccountRequest body,
            string accountId,
            string zuoraTrackId,
            bool? async,
            string zuoraEntityIds,
            string idempotencyKey,
            string acceptEncoding,
            string contentEncoding)
        {
            try
            {
                if (body == null)
                    throw new ArgumentNullException(nameof(body), "O corpo da requisição não pode ser nulo");

                if (string.IsNullOrEmpty(accountId))
                    throw new ArgumentException("O ID da conta não pode ser nulo ou vazio", nameof(accountId));

            var path = "/accounts/{account_id}/bill";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", ApiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

                if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId));
                if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async));
                if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds));
                if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey));
                if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding));
                if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding));

                var postBody = ApiClient.Serialize(body);

                var response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, new Dictionary<string, string>(), new Dictionary<string, FileParameter>(), new[] { "bearerAuth" });

                if (response.StatusCode >= HttpStatusCode.BadRequest)
                    throw new ApiException((int)response.StatusCode, $"Erro ao gerar documentos de faturamento: {response.Content}", response.Content);
                else if (response.StatusCode == 0)
                    throw new ApiException(0, $"Erro ao gerar documentos de faturamento: {response.ErrorMessage}", response.ErrorMessage);

                var result = (GenerateBillingDocumentsAccountResponse)ApiClient.Deserialize(response.Content, typeof(GenerateBillingDocumentsAccountResponse));

                // Invalida o cache da conta
                _cache.Remove($"{CACHE_KEY_PREFIX}{accountId}");

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(500, $"Erro ao processar requisição de geração de documentos de faturamento: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Obtém uma conta pelo ID
        /// </summary>
        /// <param name="accountId">Identificador da conta (número da conta ou ID)</param>
        /// <param name="fields">Campos a serem retornados</param>
        /// <param name="subscriptionsFields">Campos das assinaturas a serem retornados</param>
        /// <param name="subscriptionPlansFields">Campos dos planos de assinatura a serem retornados</param>
        /// <param name="subscriptionItemsFields">Campos dos itens de assinatura a serem retornados</param>
        /// <param name="invoiceOwnerAccountFields">Campos da conta proprietária da fatura a serem retornados</param>
        /// <param name="planFields">Campos do plano a serem retornados</param>
        /// <param name="paymentMethodsFields">Campos dos métodos de pagamento a serem retornados</param>
        /// <param name="paymentsFields">Campos dos pagamentos a serem retornados</param>
        /// <param name="billingDocumentsFields">Campos dos documentos de faturamento a serem retornados</param>
        /// <param name="billingDocumentItemsFields">Campos dos itens de documentos de faturamento a serem retornados</param>
        /// <param name="billToFields">Campos do endereço de cobrança a serem retornados</param>
        /// <param name="soldToFields">Campos do endereço de venda a serem retornados</param>
        /// <param name="defaultPaymentMethodFields">Campos do método de pagamento padrão a serem retornados</param>
        /// <param name="usageRecordsFields">Campos dos registros de uso a serem retornados</param>
        /// <param name="invoicesFields">Campos das faturas a serem retornados</param>
        /// <param name="creditMemosFields">Campos das notas de crédito a serem retornados</param>
        /// <param name="debitMemosFields">Campos das notas de débito a serem retornados</param>
        /// <param name="prepaidBalanceFields">Campos do saldo pré-pago a serem retornados</param>
        /// <param name="transactionsFields">Campos das transações a serem retornados</param>
        /// <param name="expand">Campos para expandir na resposta</param>
        /// <param name="filter">Filtros para aplicar na listagem</param>
        /// <param name="pageSize">Tamanho da página (1-99)</param>
        /// <param name="zuoraTrackId">ID de rastreamento da requisição</param>
        /// <param name="zuoraEntityIds">IDs das entidades Zuora</param>
        /// <param name="idempotencyKey">Chave de idempotência</param>
        /// <param name="acceptEncoding">Codificação de aceitação</param>
        /// <param name="contentEncoding">Codificação do conteúdo</param>
        /// <returns>Conta encontrada</returns>
        public Account GetAccount(
            string accountId,
            List<string> fields,
            List<string> subscriptionsFields,
            List<string> subscriptionPlansFields,
            List<string> subscriptionItemsFields,
            List<string> invoiceOwnerAccountFields,
            List<string> planFields,
            List<string> paymentMethodsFields,
            List<string> paymentsFields,
            List<string> billingDocumentsFields,
            List<string> billingDocumentItemsFields,
            List<string> billToFields,
            List<string> soldToFields,
            List<string> defaultPaymentMethodFields,
            List<string> usageRecordsFields,
            List<string> invoicesFields,
            List<string> creditMemosFields,
            List<string> debitMemosFields,
            List<string> prepaidBalanceFields,
            List<string> transactionsFields,
            List<string> expand,
            List<string> filter,
            int? pageSize,
            string zuoraTrackId,
            string zuoraEntityIds,
            string idempotencyKey,
            string acceptEncoding,
            string contentEncoding)
        {
            try
            {
                if (string.IsNullOrEmpty(accountId))
                    throw new ArgumentException("O ID da conta não pode ser nulo ou vazio", nameof(accountId));

                if (pageSize.HasValue && (pageSize.Value < 1 || pageSize.Value > 99))
                    throw new ArgumentException("O tamanho da página deve estar entre 1 e 99", nameof(pageSize));

                // Gera chave de cache baseada nos parâmetros
                var cacheKey = GenerateCacheKey(accountId, fields, subscriptionsFields, subscriptionPlansFields, subscriptionItemsFields, invoiceOwnerAccountFields, planFields, paymentMethodsFields, paymentsFields, billingDocumentsFields, billingDocumentItemsFields, billToFields, soldToFields, defaultPaymentMethodFields, usageRecordsFields, invoicesFields, creditMemosFields, debitMemosFields, prepaidBalanceFields, transactionsFields, expand, filter, pageSize);

                // Tenta obter do cache
                var cachedResult = _cache.Get<Account>(cacheKey);
                if (cachedResult != null)
                    return cachedResult;

            var path = "/accounts/{account_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", ApiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

                if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields));
                if (subscriptionsFields != null) queryParams.Add("subscriptions.fields[]", ApiClient.ParameterToString(subscriptionsFields));
                if (subscriptionPlansFields != null) queryParams.Add("subscription_plans.fields[]", ApiClient.ParameterToString(subscriptionPlansFields));
                if (subscriptionItemsFields != null) queryParams.Add("subscription_items.fields[]", ApiClient.ParameterToString(subscriptionItemsFields));
                if (invoiceOwnerAccountFields != null) queryParams.Add("invoice_owner_account.fields[]", ApiClient.ParameterToString(invoiceOwnerAccountFields));
                if (planFields != null) queryParams.Add("plan.fields[]", ApiClient.ParameterToString(planFields));
                if (paymentMethodsFields != null) queryParams.Add("payment_methods.fields[]", ApiClient.ParameterToString(paymentMethodsFields));
                if (paymentsFields != null) queryParams.Add("payments.fields[]", ApiClient.ParameterToString(paymentsFields));
                if (billingDocumentsFields != null) queryParams.Add("billing_documents.fields[]", ApiClient.ParameterToString(billingDocumentsFields));
                if (billingDocumentItemsFields != null) queryParams.Add("billing_document_items.fields[]", ApiClient.ParameterToString(billingDocumentItemsFields));
                if (billToFields != null) queryParams.Add("bill_to.fields[]", ApiClient.ParameterToString(billToFields));
                if (soldToFields != null) queryParams.Add("sold_to.fields[]", ApiClient.ParameterToString(soldToFields));
                if (defaultPaymentMethodFields != null) queryParams.Add("default_payment_method.fields[]", ApiClient.ParameterToString(defaultPaymentMethodFields));
                if (usageRecordsFields != null) queryParams.Add("usage_records.fields[]", ApiClient.ParameterToString(usageRecordsFields));
                if (invoicesFields != null) queryParams.Add("invoices.fields[]", ApiClient.ParameterToString(invoicesFields));
                if (creditMemosFields != null) queryParams.Add("credit_memos.fields[]", ApiClient.ParameterToString(creditMemosFields));
                if (debitMemosFields != null) queryParams.Add("debit_memos.fields[]", ApiClient.ParameterToString(debitMemosFields));
                if (prepaidBalanceFields != null) queryParams.Add("prepaid_balance.fields[]", ApiClient.ParameterToString(prepaidBalanceFields));
                if (transactionsFields != null) queryParams.Add("transactions.fields[]", ApiClient.ParameterToString(transactionsFields));
                if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand));
                if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter));
                if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize));
                if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId));
                if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds));
                if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey));
                if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding));
                if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding));

                var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, null, headerParams, new Dictionary<string, string>(), new Dictionary<string, FileParameter>(), new[] { "bearerAuth" });

                if (response.StatusCode >= HttpStatusCode.BadRequest)
                    throw new ApiException((int)response.StatusCode, $"Erro ao obter conta: {response.Content}", response.Content);
                else if (response.StatusCode == 0)
                    throw new ApiException(0, $"Erro ao obter conta: {response.ErrorMessage}", response.ErrorMessage);

                var result = (Account)ApiClient.Deserialize(response.Content, typeof(Account));

                // Armazena no cache
                _cache.Set(cacheKey, result, TimeSpan.FromMinutes(CACHE_DURATION_MINUTES));

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(500, $"Erro ao processar requisição de obtenção de conta: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lista as contas
        /// </summary>
        /// <param name="cursor">Cursor para paginação</param>
        /// <param name="expand">Campos para expandir na resposta</param>
        /// <param name="filter">Filtros para aplicar na listagem</param>
        /// <param name="sort">Ordenação dos resultados</param>
        /// <param name="pageSize">Tamanho da página (1-99)</param>
        /// <param name="fields">Campos a serem retornados</param>
        /// <param name="subscriptionsFields">Campos das assinaturas a serem retornados</param>
        /// <param name="subscriptionPlansFields">Campos dos planos de assinatura a serem retornados</param>
        /// <param name="subscriptionItemsFields">Campos dos itens de assinatura a serem retornados</param>
        /// <param name="invoiceOwnerAccountFields">Campos da conta proprietária da fatura a serem retornados</param>
        /// <param name="planFields">Campos do plano a serem retornados</param>
        /// <param name="paymentMethodsFields">Campos dos métodos de pagamento a serem retornados</param>
        /// <param name="paymentsFields">Campos dos pagamentos a serem retornados</param>
        /// <param name="billingDocumentsFields">Campos dos documentos de faturamento a serem retornados</param>
        /// <param name="billingDocumentItemsFields">Campos dos itens de documentos de faturamento a serem retornados</param>
        /// <param name="billToFields">Campos do endereço de cobrança a serem retornados</param>
        /// <param name="soldToFields">Campos do endereço de venda a serem retornados</param>
        /// <param name="defaultPaymentMethodFields">Campos do método de pagamento padrão a serem retornados</param>
        /// <param name="usageRecordsFields">Campos dos registros de uso a serem retornados</param>
        /// <param name="invoicesFields">Campos das faturas a serem retornados</param>
        /// <param name="creditMemosFields">Campos das notas de crédito a serem retornados</param>
        /// <param name="debitMemosFields">Campos das notas de débito a serem retornados</param>
        /// <param name="prepaidBalanceFields">Campos do saldo pré-pago a serem retornados</param>
        /// <param name="transactionsFields">Campos das transações a serem retornados</param>
        /// <param name="zuoraTrackId">ID de rastreamento da requisição</param>
        /// <param name="zuoraEntityIds">IDs das entidades Zuora</param>
        /// <param name="idempotencyKey">Chave de idempotência</param>
        /// <param name="acceptEncoding">Codificação de aceitação</param>
        /// <param name="contentEncoding">Codificação do conteúdo</param>
        /// <returns>Lista de contas</returns>
        public ListAccountResponse GetAccounts(
            string cursor,
            List<string> expand,
            List<string> filter,
            List<string> sort,
            int? pageSize,
            List<string> fields,
            List<string> subscriptionsFields,
            List<string> subscriptionPlansFields,
            List<string> subscriptionItemsFields,
            List<string> invoiceOwnerAccountFields,
            List<string> planFields,
            List<string> paymentMethodsFields,
            List<string> paymentsFields,
            List<string> billingDocumentsFields,
            List<string> billingDocumentItemsFields,
            List<string> billToFields,
            List<string> soldToFields,
            List<string> defaultPaymentMethodFields,
            List<string> usageRecordsFields,
            List<string> invoicesFields,
            List<string> creditMemosFields,
            List<string> debitMemosFields,
            List<string> prepaidBalanceFields,
            List<string> transactionsFields,
            string zuoraTrackId,
            string zuoraEntityIds,
            string idempotencyKey,
            string acceptEncoding,
            string contentEncoding)
        {
            try
            {
                if (pageSize.HasValue && (pageSize.Value < 1 || pageSize.Value > 99))
                    throw new ArgumentException("O tamanho da página deve estar entre 1 e 99", nameof(pageSize));

                // Gera chave de cache baseada nos parâmetros
                var cacheKey = GenerateCacheKey(cursor, expand, filter, sort, pageSize, fields, subscriptionsFields, subscriptionPlansFields, subscriptionItemsFields, invoiceOwnerAccountFields, planFields, paymentMethodsFields, paymentsFields, billingDocumentsFields, billingDocumentItemsFields, billToFields, soldToFields, defaultPaymentMethodFields, usageRecordsFields, invoicesFields, creditMemosFields, debitMemosFields, prepaidBalanceFields, transactionsFields);

                // Tenta obter do cache
                var cachedResult = _cache.Get<ListAccountResponse>(cacheKey);
                if (cachedResult != null)
                    return cachedResult;

            var path = "/accounts";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

                if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor));
                if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand));
                if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter));
                if (sort != null) queryParams.Add("sort[]", ApiClient.ParameterToString(sort));
                if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize));
                if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields));
                if (subscriptionsFields != null) queryParams.Add("subscriptions.fields[]", ApiClient.ParameterToString(subscriptionsFields));
                if (subscriptionPlansFields != null) queryParams.Add("subscription_plans.fields[]", ApiClient.ParameterToString(subscriptionPlansFields));
                if (subscriptionItemsFields != null) queryParams.Add("subscription_items.fields[]", ApiClient.ParameterToString(subscriptionItemsFields));
                if (invoiceOwnerAccountFields != null) queryParams.Add("invoice_owner_account.fields[]", ApiClient.ParameterToString(invoiceOwnerAccountFields));
                if (planFields != null) queryParams.Add("plan.fields[]", ApiClient.ParameterToString(planFields));
                if (paymentMethodsFields != null) queryParams.Add("payment_methods.fields[]", ApiClient.ParameterToString(paymentMethodsFields));
                if (paymentsFields != null) queryParams.Add("payments.fields[]", ApiClient.ParameterToString(paymentsFields));
                if (billingDocumentsFields != null) queryParams.Add("billing_documents.fields[]", ApiClient.ParameterToString(billingDocumentsFields));
                if (billingDocumentItemsFields != null) queryParams.Add("billing_document_items.fields[]", ApiClient.ParameterToString(billingDocumentItemsFields));
                if (billToFields != null) queryParams.Add("bill_to.fields[]", ApiClient.ParameterToString(billToFields));
                if (soldToFields != null) queryParams.Add("sold_to.fields[]", ApiClient.ParameterToString(soldToFields));
                if (defaultPaymentMethodFields != null) queryParams.Add("default_payment_method.fields[]", ApiClient.ParameterToString(defaultPaymentMethodFields));
                if (usageRecordsFields != null) queryParams.Add("usage_records.fields[]", ApiClient.ParameterToString(usageRecordsFields));
                if (invoicesFields != null) queryParams.Add("invoices.fields[]", ApiClient.ParameterToString(invoicesFields));
                if (creditMemosFields != null) queryParams.Add("credit_memos.fields[]", ApiClient.ParameterToString(creditMemosFields));
                if (debitMemosFields != null) queryParams.Add("debit_memos.fields[]", ApiClient.ParameterToString(debitMemosFields));
                if (prepaidBalanceFields != null) queryParams.Add("prepaid_balance.fields[]", ApiClient.ParameterToString(prepaidBalanceFields));
                if (transactionsFields != null) queryParams.Add("transactions.fields[]", ApiClient.ParameterToString(transactionsFields));
                if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId));
                if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds));
                if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey));
                if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding));
                if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding));

                var response = (RestResponse)ApiClient.CallApi(path, Method.Get, queryParams, null, headerParams, new Dictionary<string, string>(), new Dictionary<string, FileParameter>(), new[] { "bearerAuth" });

                if (response.StatusCode >= HttpStatusCode.BadRequest)
                    throw new ApiException((int)response.StatusCode, $"Erro ao listar contas: {response.Content}", response.Content);
                else if (response.StatusCode == 0)
                    throw new ApiException(0, $"Erro ao listar contas: {response.ErrorMessage}", response.ErrorMessage);

                var result = (ListAccountResponse)ApiClient.Deserialize(response.Content, typeof(ListAccountResponse));

                // Armazena no cache
                _cache.Set(cacheKey, result, TimeSpan.FromMinutes(CACHE_DURATION_MINUTES));

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(500, $"Erro ao processar requisição de listagem de contas: {ex.Message}", ex);
            }
        }

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
        /// Previsualiza uma conta
        /// </summary>
        /// <param name="body">Dados da conta para previsualização</param>
        /// <param name="accountId">Identificador da conta (número da conta ou ID)</param>
        /// <param name="zuoraTrackId">ID de rastreamento da requisição</param>
        /// <param name="async">Se true, a requisição será assíncrona</param>
        /// <param name="zuoraEntityIds">IDs das entidades Zuora</param>
        /// <param name="idempotencyKey">Chave de idempotência</param>
        /// <param name="acceptEncoding">Codificação de aceitação</param>
        /// <param name="contentEncoding">Codificação do conteúdo</param>
        /// <returns>Previsualização da conta</returns>
        public AccountPreviewResponse PreviewAccount(
            AccountPreviewRequest body,
            string accountId,
            string zuoraTrackId,
            bool? async,
            string zuoraEntityIds,
            string idempotencyKey,
            string acceptEncoding,
            string contentEncoding)
        {
            try
            {
                if (body == null)
                    throw new ArgumentNullException(nameof(body), "O corpo da requisição não pode ser nulo");

                if (string.IsNullOrEmpty(accountId))
                    throw new ArgumentException("O ID da conta não pode ser nulo ou vazio", nameof(accountId));

            var path = "/accounts/{account_id}/preview";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", ApiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

                if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId));
                if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async));
                if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds));
                if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey));
                if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding));
                if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding));

                var postBody = ApiClient.Serialize(body);

                var response = (RestResponse)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, new Dictionary<string, string>(), new Dictionary<string, FileParameter>(), new[] { "bearerAuth" });

                if (response.StatusCode >= HttpStatusCode.BadRequest)
                    throw new ApiException((int)response.StatusCode, $"Erro ao previsualizar conta: {response.Content}", response.Content);
                else if (response.StatusCode == 0)
                    throw new ApiException(0, $"Erro ao previsualizar conta: {response.ErrorMessage}", response.ErrorMessage);

            return (AccountPreviewResponse)ApiClient.Deserialize(response.Content, typeof(AccountPreviewResponse));
            }
            catch (Exception ex)
            {
                throw new ApiException(500, $"Erro ao processar requisição de previsualização de conta: {ex.Message}", ex);
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

        /// <summary>
        /// Atualiza uma conta
        /// </summary>
        /// <param name="body">Dados da conta a serem atualizados</param>
        /// <param name="accountId">Identificador da conta (número da conta ou ID)</param>
        /// <param name="zuoraTrackId">ID de rastreamento da requisição</param>
        /// <param name="async">Se true, a requisição será assíncrona</param>
        /// <param name="zuoraEntityIds">IDs das entidades Zuora</param>
        /// <param name="idempotencyKey">Chave de idempotência</param>
        /// <param name="acceptEncoding">Codificação de aceitação</param>
        /// <param name="contentEncoding">Codificação do conteúdo</param>
        /// <param name="fields">Campos a serem retornados</param>
        /// <param name="subscriptionsFields">Campos das assinaturas a serem retornados</param>
        /// <param name="subscriptionPlansFields">Campos dos planos de assinatura a serem retornados</param>
        /// <param name="subscriptionItemsFields">Campos dos itens de assinatura a serem retornados</param>
        /// <param name="invoiceOwnerAccountFields">Campos da conta proprietária da fatura a serem retornados</param>
        /// <param name="planFields">Campos do plano a serem retornados</param>
        /// <param name="paymentMethodsFields">Campos dos métodos de pagamento a serem retornados</param>
        /// <param name="paymentsFields">Campos dos pagamentos a serem retornados</param>
        /// <param name="billingDocumentsFields">Campos dos documentos de faturamento a serem retornados</param>
        /// <param name="billingDocumentItemsFields">Campos dos itens de documentos de faturamento a serem retornados</param>
        /// <param name="billToFields">Campos do endereço de cobrança a serem retornados</param>
        /// <param name="soldToFields">Campos do endereço de venda a serem retornados</param>
        /// <param name="defaultPaymentMethodFields">Campos do método de pagamento padrão a serem retornados</param>
        /// <param name="usageRecordsFields">Campos dos registros de uso a serem retornados</param>
        /// <param name="invoicesFields">Campos das faturas a serem retornados</param>
        /// <param name="creditMemosFields">Campos das notas de crédito a serem retornados</param>
        /// <param name="debitMemosFields">Campos das notas de débito a serem retornados</param>
        /// <param name="prepaidBalanceFields">Campos do saldo pré-pago a serem retornados</param>
        /// <param name="transactionsFields">Campos das transações a serem retornados</param>
        /// <param name="expand">Campos para expandir na resposta</param>
        /// <param name="filter">Filtros para aplicar na listagem</param>
        /// <param name="pageSize">Tamanho da página (1-99)</param>
        /// <returns>Conta atualizada</returns>
        public Account UpdateAccount(
            AccountPatchRequest body,
            string accountId,
            string zuoraTrackId,
            bool? async,
            string zuoraEntityIds,
            string idempotencyKey,
            string acceptEncoding,
            string contentEncoding,
            List<string> fields,
            List<string> subscriptionsFields,
            List<string> subscriptionPlansFields,
            List<string> subscriptionItemsFields,
            List<string> invoiceOwnerAccountFields,
            List<string> planFields,
            List<string> paymentMethodsFields,
            List<string> paymentsFields,
            List<string> billingDocumentsFields,
            List<string> billingDocumentItemsFields,
            List<string> billToFields,
            List<string> soldToFields,
            List<string> defaultPaymentMethodFields,
            List<string> usageRecordsFields,
            List<string> invoicesFields,
            List<string> creditMemosFields,
            List<string> debitMemosFields,
            List<string> prepaidBalanceFields,
            List<string> transactionsFields,
            List<string> expand,
            List<string> filter,
            int? pageSize)
        {
            try
            {
                if (body == null)
                    throw new ArgumentNullException(nameof(body), "O corpo da requisição não pode ser nulo");

                if (string.IsNullOrEmpty(accountId))
                    throw new ArgumentException("O ID da conta não pode ser nulo ou vazio", nameof(accountId));

                if (pageSize.HasValue && (pageSize.Value < 1 || pageSize.Value > 99))
                    throw new ArgumentException("O tamanho da página deve estar entre 1 e 99", nameof(pageSize));

            var path = "/accounts/{account_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", ApiClient.ParameterToString(accountId));

            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();

                if (fields != null) queryParams.Add("fields[]", ApiClient.ParameterToString(fields));
                if (subscriptionsFields != null) queryParams.Add("subscriptions.fields[]", ApiClient.ParameterToString(subscriptionsFields));
                if (subscriptionPlansFields != null) queryParams.Add("subscription_plans.fields[]", ApiClient.ParameterToString(subscriptionPlansFields));
                if (subscriptionItemsFields != null) queryParams.Add("subscription_items.fields[]", ApiClient.ParameterToString(subscriptionItemsFields));
                if (invoiceOwnerAccountFields != null) queryParams.Add("invoice_owner_account.fields[]", ApiClient.ParameterToString(invoiceOwnerAccountFields));
                if (planFields != null) queryParams.Add("plan.fields[]", ApiClient.ParameterToString(planFields));
                if (paymentMethodsFields != null) queryParams.Add("payment_methods.fields[]", ApiClient.ParameterToString(paymentMethodsFields));
                if (paymentsFields != null) queryParams.Add("payments.fields[]", ApiClient.ParameterToString(paymentsFields));
                if (billingDocumentsFields != null) queryParams.Add("billing_documents.fields[]", ApiClient.ParameterToString(billingDocumentsFields));
                if (billingDocumentItemsFields != null) queryParams.Add("billing_document_items.fields[]", ApiClient.ParameterToString(billingDocumentItemsFields));
                if (billToFields != null) queryParams.Add("bill_to.fields[]", ApiClient.ParameterToString(billToFields));
                if (soldToFields != null) queryParams.Add("sold_to.fields[]", ApiClient.ParameterToString(soldToFields));
                if (defaultPaymentMethodFields != null) queryParams.Add("default_payment_method.fields[]", ApiClient.ParameterToString(defaultPaymentMethodFields));
                if (usageRecordsFields != null) queryParams.Add("usage_records.fields[]", ApiClient.ParameterToString(usageRecordsFields));
                if (invoicesFields != null) queryParams.Add("invoices.fields[]", ApiClient.ParameterToString(invoicesFields));
                if (creditMemosFields != null) queryParams.Add("credit_memos.fields[]", ApiClient.ParameterToString(creditMemosFields));
                if (debitMemosFields != null) queryParams.Add("debit_memos.fields[]", ApiClient.ParameterToString(debitMemosFields));
                if (prepaidBalanceFields != null) queryParams.Add("prepaid_balance.fields[]", ApiClient.ParameterToString(prepaidBalanceFields));
                if (transactionsFields != null) queryParams.Add("transactions.fields[]", ApiClient.ParameterToString(transactionsFields));
                if (expand != null) queryParams.Add("expand[]", ApiClient.ParameterToString(expand));
                if (filter != null) queryParams.Add("filter[]", ApiClient.ParameterToString(filter));
                if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize));
                if (zuoraTrackId != null) headerParams.Add("zuora-track-id", ApiClient.ParameterToString(zuoraTrackId));
                if (async != null) headerParams.Add("async", ApiClient.ParameterToString(async));
                if (zuoraEntityIds != null) headerParams.Add("zuora-entity-ids", ApiClient.ParameterToString(zuoraEntityIds));
                if (idempotencyKey != null) headerParams.Add("idempotency-key", ApiClient.ParameterToString(idempotencyKey));
                if (acceptEncoding != null) headerParams.Add("accept-encoding", ApiClient.ParameterToString(acceptEncoding));
                if (contentEncoding != null) headerParams.Add("content-encoding", ApiClient.ParameterToString(contentEncoding));

                var postBody = ApiClient.Serialize(body);

                var response = (RestResponse)ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, new Dictionary<string, string>(), new Dictionary<string, FileParameter>(), new[] { "bearerAuth" });

                if (response.StatusCode >= HttpStatusCode.BadRequest)
                    throw new ApiException((int)response.StatusCode, $"Erro ao atualizar conta: {response.Content}", response.Content);
                else if (response.StatusCode == 0)
                    throw new ApiException(0, $"Erro ao atualizar conta: {response.ErrorMessage}", response.ErrorMessage);

                var result = (Account)ApiClient.Deserialize(response.Content, typeof(Account));

                // Invalida o cache da conta e da listagem
                _cache.Remove($"{CACHE_KEY_PREFIX}{accountId}");
                _cache.RemoveByPrefix(CACHE_KEY_PREFIX);

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(500, $"Erro ao processar requisição de atualização de conta: {ex.Message}", ex);
            }
        }

        private string GenerateCacheKey(string accountId, List<string> fields, List<string> subscriptionsFields, List<string> subscriptionPlansFields, List<string> subscriptionItemsFields, List<string> invoiceOwnerAccountFields, List<string> planFields, List<string> paymentMethodsFields, List<string> paymentsFields, List<string> billingDocumentsFields, List<string> billingDocumentItemsFields, List<string> billToFields, List<string> soldToFields, List<string> defaultPaymentMethodFields, List<string> usageRecordsFields, List<string> invoicesFields, List<string> creditMemosFields, List<string> debitMemosFields, List<string> prepaidBalanceFields, List<string> transactionsFields, List<string> expand, List<string> filter, int? pageSize)
        {
            var keyBuilder = new StringBuilder(CACHE_KEY_PREFIX);
            keyBuilder.Append(accountId);
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", fields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", subscriptionsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", subscriptionPlansFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", subscriptionItemsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", invoiceOwnerAccountFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", planFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", paymentMethodsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", paymentsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", billingDocumentsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", billingDocumentItemsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", billToFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", soldToFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", defaultPaymentMethodFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", usageRecordsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", invoicesFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", creditMemosFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", debitMemosFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", prepaidBalanceFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", transactionsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", expand ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", filter ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(pageSize?.ToString() ?? "null");

            return keyBuilder.ToString();
        }

        private string GenerateCacheKey(string cursor, List<string> expand, List<string> filter, List<string> sort, int? pageSize, List<string> fields, List<string> subscriptionsFields, List<string> subscriptionPlansFields, List<string> subscriptionItemsFields, List<string> invoiceOwnerAccountFields, List<string> planFields, List<string> paymentMethodsFields, List<string> paymentsFields, List<string> billingDocumentsFields, List<string> billingDocumentItemsFields, List<string> billToFields, List<string> soldToFields, List<string> defaultPaymentMethodFields, List<string> usageRecordsFields, List<string> invoicesFields, List<string> creditMemosFields, List<string> debitMemosFields, List<string> prepaidBalanceFields, List<string> transactionsFields)
        {
            var keyBuilder = new StringBuilder(CACHE_KEY_PREFIX);
            keyBuilder.Append("list:");
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
            keyBuilder.Append(string.Join(",", subscriptionsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", subscriptionPlansFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", subscriptionItemsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", invoiceOwnerAccountFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", planFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", paymentMethodsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", paymentsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", billingDocumentsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", billingDocumentItemsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", billToFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", soldToFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", defaultPaymentMethodFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", usageRecordsFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", invoicesFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", creditMemosFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", debitMemosFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", prepaidBalanceFields ?? new List<string>()));
            keyBuilder.Append(":");
            keyBuilder.Append(string.Join(",", transactionsFields ?? new List<string>()));

            return keyBuilder.ToString();
        }
    }
}