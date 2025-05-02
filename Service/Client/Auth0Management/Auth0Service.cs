using Auth0.AuthenticationApi;
using Auth0.AuthenticationApi.Models;
using Auth0.ManagementApi;
using Auth0.ManagementApi.Models;
using Auth0.ManagementApi.Paging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Service.Client.Auth0Management.Models;

namespace Service.Client.Auth0Management
{
    public class Auth0Service : IAuth0Service
    {
        public const int MAX_AUTH0_PAGESIZE = 100;

        private readonly Auth0Options _auth0Options;

        private readonly AuthenticationApiClient _authClient;

        private readonly ManagementApiClient _managementClient;

        public Auth0Service(IOptionsSnapshot<Auth0Options> auth0Options)
        {
            _auth0Options = auth0Options.Value;

            _authClient = new AuthenticationApiClient(_auth0Options.Domain);
            _managementClient = GetManagementClient();
        }

        private AccessTokenResponse managementToken { get; set; }

        public string CreateUser(Auth0AccountRequest userRequest)
        {
            userRequest.SetRoleId(userRequest.RoleId ?? GetRoleId(userRequest.Role));

            UserCreateRequest userCreateRequest = new UserCreateRequest
            {
                Email = userRequest.Email,
                FullName = userRequest.FullName,
                Password = userRequest.Password,
                Connection = _auth0Options.Connection, //Required
                Blocked = false,
                EmailVerified = true,
                VerifyEmail = false,
                AppMetadata = userRequest.Metadata?.Clone(),
                FirstName = userRequest.FirstName,
                LastName = userRequest.LastName
            };

            try
            {
                var user = _managementClient.Users.CreateAsync(userCreateRequest).Result;

                if (string.IsNullOrWhiteSpace(user.UserId))
                    return null;

                _managementClient.Roles.AssignUsersAsync(userRequest.RoleId, new AssignUsersRequest() { Users = new string[] { user.UserId } });

                return user.UserId;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void DeleteUser(string auth0Id)
        {
            _managementClient.Users.DeleteAsync(auth0Id);
        }

        public async Task EnableUserAsync(Auth0AccountRequest userUpdate)
        {
            UserUpdateRequest userUpdateRequest = new UserUpdateRequest
            {
                Blocked = userUpdate.Blocked
            };

            await _managementClient.Users.UpdateAsync(userUpdate.Auth0Id, userUpdateRequest);
        }

        public async Task<Auth0AccountResponse> GetUserByAccountId(string accountId)
        {
            GetUsersRequest getUsersRequest = new GetUsersRequest()
            {
                Query = $"app_metadata.ResellerAdminAccountId:\"{accountId}\""
            };

            var auth0users = await _managementClient.Users.GetAllAsync(getUsersRequest, new PaginationInfo(pageNo: 0, perPage: 1));

            var userResponse = auth0users.Select(u =>
            {
                string resellerAdminAuth0Id = ((JObject)u.AppMetadata)?.SelectToken("ResellerAdminAuth0Id")?.ToString();
                string resellerAdminAccountNumber = ((JObject)u.AppMetadata)?.SelectToken("ResellerAdminAccountNumber")?.ToString();
                string resellerAdminAccountId = ((JObject)u.AppMetadata)?.SelectToken("ResellerAdminAccountId")?.ToString();
                string resellerCurrency = ((JObject)u.AppMetadata)?.SelectToken("ResellerCurrency")?.ToString();

                return new Auth0AccountResponse(u.UserId, u.Email, u.FullName, u.CreatedAt)
                {
                    Metadata = new Auth0AccountResponse.AppMetadata(resellerAdminAuth0Id, resellerAdminAccountNumber, resellerAdminAccountId, resellerCurrency),
                    Firstname = u.FirstName,
                    Lastname = u.LastName,
                    Blocked = u.Blocked ?? false
                };
            });

            return userResponse.FirstOrDefault();
        }

        public async Task<Auth0AccountResponse> GetUserByAuth0Id(string auth0Id)
        {
            User auth0user;

            try
            {
                auth0user = await _managementClient.Users.GetAsync(auth0Id);
            }
            catch (AggregateException)
            {
                return null;
            }

            var roles = await _managementClient.Users.GetRolesAsync(auth0Id, new PaginationInfo());

            string resellerAdminAuth0Id = ((JObject)auth0user.AppMetadata)?.SelectToken("ResellerAdminAuth0Id")?.ToString();
            string resellerAdminAccountNumber = ((JObject)auth0user.AppMetadata)?.SelectToken("ResellerAdminAccountNumber")?.ToString();
            string resellerAdminAccountId = ((JObject)auth0user.AppMetadata)?.SelectToken("ResellerAdminAccountId")?.ToString();
            string resellerCurrency = ((JObject)auth0user.AppMetadata)?.SelectToken("ResellerCurrency")?.ToString();

            var userResponse = new Auth0AccountResponse(auth0user.UserId, auth0user.Email, auth0user.FullName, auth0user.CreatedAt)
            {
                Metadata = new Auth0AccountResponse.AppMetadata(resellerAdminAuth0Id, resellerAdminAccountNumber, resellerAdminAccountId, resellerCurrency),
                Roles = roles.Select(role => role.Name).ToArray(),
                Firstname = auth0user.FirstName,
                Lastname = auth0user.LastName
            };

            return userResponse;
        }

        public Auth0AccountResponse GetUserByEmail(string email)
        {
            var auth0user = _managementClient.Users.GetUsersByEmailAsync(email).Result;

            var userResponse = new Auth0AccountResponse(auth0user.First().UserId, auth0user.First().Email, auth0user.First().FullName, auth0user.First().CreatedAt);

            return userResponse;
        }

        public async Task<IEnumerable<Auth0AccountResponse>> GetUsersByEmailAsync(string email)
        {
            List<Auth0AccountResponse> userList = new List<Auth0AccountResponse>();

            var auth0user = await _managementClient.Users.GetUsersByEmailAsync(email);
            auth0user.ToList().ForEach(m => userList.Add(
               new Auth0AccountResponse(m.UserId, m.Email, m.FullName)
            ));

            return userList; ;
        }

        public IEnumerable<Auth0AccountResponse> GetUsersByIds(string[] ids) // ResellerAdmin
        {
            var users = new List<User>();

            bool loadMore = true;
            int pageNo = 0;
            while (loadMore)
            {
                var pagedList = _managementClient.Users.GetAllAsync(new GetUsersRequest
                {
                    Query = string.Join(" OR ", ids.Select(x => $"user_id:\"{x}\"").ToArray())
                }, new PaginationInfo(pageNo, perPage: 50, includeTotals: true)).Result;

                users.AddRange(pagedList);

                if (users.Count >= pagedList.Paging.Total)
                {
                    break;
                }

                pageNo++;
            }

            List<Auth0AccountResponse> userList = new List<Auth0AccountResponse>();
            users.ToList().ForEach(m => userList.Add(
                new Auth0AccountResponse(m.UserId, m.Email, m.FullName)
            ));

            return userList;
        }

        public IEnumerable<Auth0AccountResponse> GetUsersByResellerAdminAuth0Id(string resellerAdminAuth0Id)
        {
            return GetUsersByResellerAdminAuth0Id(resellerAdminAuth0Id, MAX_AUTH0_PAGESIZE, 1).Item1;
        }

        public (IEnumerable<Auth0AccountResponse>, int totalItems) GetUsersByResellerAdminAuth0Id(string resellerAdminAuth0Id, int pageSize, int page)
        {
            GetUsersRequest getUsersRequest = new GetUsersRequest()
            {
                Query = $"app_metadata.ResellerAdminAuth0Id:\"{resellerAdminAuth0Id}\" && app_metadata.Type:\"ResellerEmployee\""
            };

            PaginationInfo pagination = new PaginationInfo((page - 1), pageSize, includeTotals: true);

            var auth0users = _managementClient.Users.GetAllAsync(getUsersRequest, pagination).Result;

            var userResponse = auth0users.Select(u =>
            {
                string resellerAdminAuth0Id = ((JObject)u.AppMetadata)?.SelectToken("ResellerAdminAuth0Id")?.ToString();
                string resellerAdminAccountNumber = ((JObject)u.AppMetadata)?.SelectToken("ResellerAdminAccountNumber")?.ToString();
                string resellerAdminAccountId = ((JObject)u.AppMetadata)?.SelectToken("ResellerAdminAccountId")?.ToString();
                string resellerCurrency = ((JObject)u.AppMetadata)?.SelectToken("ResellerCurrency")?.ToString();

                return new Auth0AccountResponse(u.UserId, u.Email, u.FullName, u.CreatedAt)
                {
                    Metadata = new Auth0AccountResponse.AppMetadata(resellerAdminAuth0Id, resellerAdminAccountNumber, resellerAdminAccountId, resellerCurrency),
                    Firstname = u.FirstName,
                    Lastname = u.LastName,
                    Blocked = u.Blocked.Value
                };
            });

            return (userResponse, auth0users.Paging.Total);
        }

        public IEnumerable<Auth0AccountResponse> GetUsersByRole(string role = null) // ResellerAdmin
        {
            string roleId = (role != null ? GetRoleId(role) : string.Empty);

            var users = new List<AssignedUser>();

            bool loadMore = true;
            int pageNo = 0;
            while (loadMore)
            {
                var pagedList = _managementClient.Roles.GetUsersAsync(roleId, new PaginationInfo(pageNo, perPage: 50, includeTotals: true)).Result;
                users.AddRange(pagedList);

                if (users.Count >= pagedList.Paging.Total)
                {
                    break;
                }

                pageNo++;
            }

            List<Auth0AccountResponse> userList = new List<Auth0AccountResponse>();
            users.ToList().ForEach(m => userList.Add(
                new Auth0AccountResponse(m.UserId, m.Email, m.FullName)
            ));

            return userList;
        }

        public void UpdateUser(Auth0AccountRequest userUpdate)
        {
            UserUpdateRequest userUpdateRequest = new UserUpdateRequest
            {
                Email = userUpdate.Email,
                Password = userUpdate.Password,
                FirstName = userUpdate.FirstName,
                LastName = userUpdate.LastName,
                Connection = _auth0Options.Connection,
                FullName = userUpdate.FullName,
                NickName = userUpdate.Nickname
            };

            if (userUpdate.Metadata != null)
            {
                userUpdateRequest.AppMetadata = userUpdate.Metadata.Clone();
            }
            try
            {
                var user = _managementClient.Users.UpdateAsync(userUpdate.Auth0Id, userUpdateRequest).Result;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        #region ManagementAPISupport

        private string GetRoleId(string role)
        {
            var roleProp = _managementClient.Roles.GetAllAsync(new GetRolesRequest { NameFilter = role }).Result;
            return roleProp.First().Id;
        }

        #endregion ManagementAPISupport

        #region ManagementAPIConfig

        private ManagementApiClient GetManagementClient()
        {
            managementToken = managementToken ?? GetManagementToken().Result;
            var managementApiClient = new ManagementApiClient(managementToken.AccessToken, _auth0Options.Domain);
            return managementApiClient;
        }

        private async Task<AccessTokenResponse> GetManagementToken()
        {
            AccessTokenResponse token = await _authClient.GetTokenAsync(new ClientCredentialsTokenRequest
            {
                Audience = $"https://{_auth0Options.Domain}/api/v2/",
                ClientId = _auth0Options.ManagementClientId,
                ClientSecret = _auth0Options.ManagementClientSecret
            });

            return token;
        }

        #endregion ManagementAPIConfig
    }
}