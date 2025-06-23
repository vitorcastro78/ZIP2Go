using System.ComponentModel.DataAnnotations;

namespace ZIP2Go.WebAPI.AuthService.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "O nome de usuário é obrigatório")]
        public string ClientId { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string ClientSecret { get; set; } = string.Empty;
    }

    public class AuthResponse
    {
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime Expiration { get; set; }
        public string Username { get; set; } = string.Empty;
        public string[] Roles { get; set; } = Array.Empty<string>();
        public string Message { get; set; } = string.Empty;
    }

    public class RefreshTokenModel
    {
        [Required(ErrorMessage = "O token de atualização é obrigatório")]
        public string RefreshToken { get; set; } = string.Empty;
    }

    public class JwtSettings
    {
        public string SecretKey { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public int ExpirationInMinutes { get; set; }
        public int RefreshTokenExpirationInDays { get; set; }
    }
} 