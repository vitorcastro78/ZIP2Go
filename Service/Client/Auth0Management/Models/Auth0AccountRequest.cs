namespace Service.Client.Auth0Management.Models
{
    public class Auth0AccountRequest
    {
        public Auth0AccountRequest()
        {
            FullName = $"{FirstName} {LastName}";
        }

        public Auth0AccountRequest(string auth0Id)
            : this()
        {
            Auth0Id = auth0Id;
        }

        public Auth0AccountRequest(string role, string email, string password, string firstName, string lastName)
            : this()
        {
            Role = role;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Nickname = email.Substring(0, email.IndexOf("@")); //Nickname is based on email name
        }

        public Auth0AccountRequest(string auth0Id, string email, string firstName, string lastName)
            : this(auth0Id)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Auth0Id { get; private set; }

        public bool Blocked { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string FullName { get; private set; }

        public string LastName { get; set; }

        public AppMetadata Metadata { get; set; }

        public string Nickname { get; private set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public string RoleId { get; private set; }

        public void SetAuth0Id(string auth0Id) => this.Auth0Id = auth0Id;

        public void SetRoleId(string roleId) => this.RoleId = roleId;

        public class AppMetadata : ICloneable
        {
            public AppMetadata(string resellerAdminAuth0Id)
            {
                ResellerAdminAuth0Id = resellerAdminAuth0Id;
            }

            public string ResellerAdminAccountId { get; set; }

            public string ResellerAdminAccountName { get; set; }

            public string ResellerAdminAccountNumber { get; set; }

            public string ResellerAdminAuth0Id { get; set; }

            public string ResellerCurrency { get; set; }

            public string Type { get; set; }

            public object Clone() => this.MemberwiseClone();
        }
    }
}