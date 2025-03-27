using ZIP2GO.Service.Client.Auth0Management.Models;

namespace ZIP2GO.Service.Client.Auth0Management
{
    public interface IAuth0Service
    {
        string CreateUser(Auth0AccountRequest userCreate);

        void UpdateUser(Auth0AccountRequest userUpdate);

        Task<Auth0AccountResponse> GetUserByAuth0Id(string id);

        Auth0AccountResponse GetUserByEmail(string email);

        Task<IEnumerable<Auth0AccountResponse>> GetUsersByEmailAsync(string email);

        IEnumerable<Auth0AccountResponse> GetUsersByRole(string role);

        IEnumerable<Auth0AccountResponse> GetUsersByIds(string[] ids);

        void DeleteUser(string auth0Id);

        Task EnableUserAsync(Auth0AccountRequest userUpdate);

        IEnumerable<Auth0AccountResponse> GetUsersByResellerAdminAuth0Id(string resellerAdminAuth0Id);

        (IEnumerable<Auth0AccountResponse>, int totalItems) GetUsersByResellerAdminAuth0Id(string resellerAdminAuth0Id, int pageSize, int page);
        
        Task<Auth0AccountResponse> GetUserByAccountId(string accountId);
    }
}