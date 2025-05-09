﻿namespace Service.Client.Auth0Management
{
    public class Auth0Options
    {
        public string ApiIdentifier { get; set; }

        public string Connection { get; set; }

        public string Domain { get; set; }

        public string ManagementClientId { get; set; }

        public string ManagementClientSecret { get; set; }

        public string Roles { get; set; }
    }
}