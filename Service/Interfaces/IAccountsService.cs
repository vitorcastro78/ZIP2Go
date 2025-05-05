using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Interface for managing account operations in the Zuora API.
    /// Provides methods for creating, retrieving, updating, and deleting accounts.
    /// </summary>
    public interface IAccountsService
    {
        /// <summary>
        /// Creates a new account in the system.
        /// </summary>
        /// <param name="body">The account creation request containing account details.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests.</param>
        /// <param name="async">Whether to process the request asynchronously.</param>
        /// <param name="expand">List of related objects to include in the response.</param>
        /// <returns>The newly created account.</returns>
        Account CreateAccount(AccountCreateRequest body, string zuoraTrackId, bool? async);

        /// <summary>
        /// Permanently deletes an account from the system.
        /// This operation cannot be undone.
        /// </summary>
        /// <param name="accountId">The unique identifier of the account to delete.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests.</param>
        /// <param name="async">Whether to process the request asynchronously.</param>
        void DeleteAccount(string accountId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Generates billing documents for an account.
        /// </summary>
        /// <param name="body">The billing document generation request.</param>
        /// <param name="accountId">The unique identifier of the account.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests.</param>
        /// <param name="async">Whether to process the request asynchronously.</param>
        /// <returns>The response containing generated billing documents.</returns>
        GenerateBillingDocumentsAccountResponse GenerateBillingDocuments(GenerateBillingDocumentsAccountRequest body, string accountId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Retrieves detailed information about a specific account.
        /// </summary>
        /// <param name="accountId">The unique identifier of the account to retrieve.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests.</param>
        /// <returns>The account details.</returns>
        Account GetAccount(string accountId, string zuoraTrackId, bool? async);

        Account GetAccountCached(string accountId);

        /// <summary>
        /// Lists all accounts in the system with pagination support.
        /// </summary>
        /// <param name="cursor">Cursor for pagination.</param>
        /// <param name="expand">List of related objects to include in the response.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests.</param>
        /// <returns>A paginated list of accounts.</returns>
        ListAccountResponse GetAccounts(string zuoraTrackId, bool? async);


        /// <summary>
        /// Previews an account before creation, showing future invoice and credit memo items.
        /// </summary>
        /// <param name="body">The account preview request.</param>
        /// <param name="accountId">The unique identifier of the account.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests.</param>
        /// <param name="async">Whether to process the request asynchronously.</param>
        /// <returns>The preview response containing future billing information.</returns>
        AccountPreviewResponse PreviewAccount(AccountPreviewRequest body, string accountId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Updates an existing account's information.
        /// </summary>
        /// <param name="body">The account update request containing modified account details.</param>
        /// <param name="accountId">The unique identifier of the account to update.</param>
        /// <param name="zuoraTrackId">A custom identifier for tracking API requests.</param>
        /// <param name="async">Whether to process the request asynchronously.</param>
        /// <returns>The updated account.</returns>
        Account UpdateAccount(AccountPatchRequest body, string accountId, string zuoraTrackId, bool? async);
    }
}