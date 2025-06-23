using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using ZIP2Go.WebAPI.AuthService.Models;

namespace ZIP2Go.WebAPI.AuthService.Services
{
    public interface IAuthService
    {
        Task<AuthResponse?> AuthenticateAsync(LoginModel login);
        Task<AuthResponse?> RefreshTokenAsync(string refreshToken);
        Task<bool> RevokeTokenAsync(string refreshToken);
    }

    public class AuthService : IAuthService
    {
        private readonly JwtSettings _jwtSettings;
        private static readonly Dictionary<string, string> _refreshTokens = new();

        public AuthService(JwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public async Task<AuthResponse?> AuthenticateAsync(LoginModel login)
        {

            var roles = new[] { "Admin" };
            var token = GenerateJwtToken(login.ClientSecret, roles);
            var refreshToken = GenerateRefreshToken();

            // Armazena o refresh token (em produção, use um banco de dados)
            _refreshTokens[refreshToken] = login.ClientSecret;

            return new AuthResponse
            {
                Token = token,
                RefreshToken = refreshToken,
                Expiration = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpirationInMinutes),
                Username = login.ClientSecret,
                Roles = roles,
                Message = "Login realizado com sucesso"
            };
        }

        public async Task<AuthResponse?> RefreshTokenAsync(string refreshToken)
        {
            if (!_refreshTokens.TryGetValue(refreshToken, out var username))
            {
                return null;
            }

            var roles = new[] { "Admin" }; // Em produção, busque as roles do usuário
            var newToken = GenerateJwtToken(username, roles);
            var newRefreshToken = GenerateRefreshToken();

            // Remove o refresh token antigo e adiciona o novo
            _refreshTokens.Remove(refreshToken);
            _refreshTokens[newRefreshToken] = username;

            return new AuthResponse
            {
                Token = newToken,
                RefreshToken = newRefreshToken,
                Expiration = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpirationInMinutes),
                Username = username,
                Roles = roles,
                Message = "Token atualizado com sucesso"
            };
        }

        public async Task<bool> RevokeTokenAsync(string refreshToken)
        {
            return _refreshTokens.Remove(refreshToken);
        }

        private string GenerateJwtToken(string username, string[] roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.SecretKey);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpirationInMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _jwtSettings.Issuer,
                Audience = _jwtSettings.Audience
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }
} 