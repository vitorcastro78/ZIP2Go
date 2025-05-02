namespace Service.Client.Auth0Management.Models
{
    public class Auth0AccountResponse
    {
        public Auth0AccountResponse()
        { }

        public Auth0AccountResponse(string auth0Id, string email, string fullName)
        {
            Auth0Id = auth0Id;
            Email = email;
            FullName = fullName;
        }

        public Auth0AccountResponse(string userId, string email, string fullname, DateTime? createdAt)
        {
            Auth0Id = userId;
            Email = email;
            FullName = fullname;
            CreatedAt = createdAt;
        }

        public string Auth0Id { get; set; }

        public bool Blocked { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string Email { get; set; }

        public string Firstname { get; set; }

        public string FullName { get; set; }

        public string Lastname { get; set; }

        public AppMetadata Metadata { get; set; }

        public string[] Roles { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public class AppMetadata
        {
            public AppMetadata()
            {
            }

            public AppMetadata(string resellerAdminAuth0Id, string resellerAdminAccountNumber, string resellerAdminAccountId, string resellerCurrency)
            {
                ResellerAdminAuth0Id = resellerAdminAuth0Id;
                ResellerAdminAccountNumber = resellerAdminAccountNumber;
                ResellerAdminAccountId = resellerAdminAccountId;
                ResellerCurrency = resellerCurrency;
            }

            public string ResellerAdminAccountId { get; set; }

            public string ResellerAdminAccountNumber { get; set; }

            public string ResellerAdminAuth0Id { get; set; }

            public string ResellerCurrency { get; set; }
        }
    }
}