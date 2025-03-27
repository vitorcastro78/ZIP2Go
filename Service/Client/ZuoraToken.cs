using Newtonsoft.Json;

namespace ZIP2GO.Service.Client
{
    public class ZuoraToken
    {
        [JsonProperty("access_token")]
        public string Access_token { get; set; }

        [JsonProperty("token_type")]
        public string Token_type { get; set; }

        [JsonProperty("expires_in")]
        public int Expires_in { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("jti")]
        public string Jti { get; set; }

        public DateTime? ExpiresAt { get; set; }
    }
}