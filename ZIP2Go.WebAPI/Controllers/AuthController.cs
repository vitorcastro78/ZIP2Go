using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZIP2Go.WebAPI.AuthService.Models;
using ZIP2Go.WebAPI.AuthService.Services;

namespace ZIP2Go.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthService authService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;
        }

        /// <summary>
        /// Obtém um token JWT usando Basic Authentication
        /// </summary>
        //[HttpPost("token")]
        //[ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //public async Task<ActionResult<AuthResponse>> GetToken()
        //{
        //    try
        //    {
        //        var authHeader = Request.Headers["Authorization"].ToString();
        //        if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Basic "))
        //        {
        //            return Unauthorized(new { message = "Credenciais não fornecidas" });
        //        }

        //        var encodedCredentials = authHeader.Substring("Basic ".Length).Trim();
        //        var credentials = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(encodedCredentials));
        //        var parts = credentials.Split(':', 2);

        //        if (parts.Length != 2)
        //        {
        //            return Unauthorized(new { message = "Formato de credenciais inválido" });
        //        }
            
        //        var login = new LoginModel
        //        {
        //            ClientId = parts[0],
        //            ClientSecret = parts[1]
        //        };

        //        if (string.IsNullOrEmpty(login.ClientId) || string.IsNullOrEmpty(login.ClientSecret))
        //        {
        //            return Unauthorized(new { message = "ClientId or ClientSecret not valid" });
        //        }

        //        var response = await _authService.AuthenticateAsync(login);
                
        //        if (response == null)
        //        {
        //            return Unauthorized(new { message = "Usuário ou senha inválidos" });
        //        }

        //        return Ok(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Erro ao obter token");
        //        return StatusCode(500, new { message = "Erro interno do servidor" });
        //    }
        //}

        /// <summary>
        /// Autentica um usuário e retorna um token JWT
        /// </summary>
        [HttpPost("token")]
        [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<AuthResponse>> GetToken([FromBody] LoginModel login)
        {
            try
            {
                if (string.IsNullOrEmpty(login.ClientId) || string.IsNullOrEmpty(login.ClientSecret))
                {
                    return Unauthorized(new { message = "ClientId or ClientSecret not valid" });
                }

                var response = await _authService.AuthenticateAsync(login);
                
                if (response == null)
                {
                    return Unauthorized(new { message = "Usuário ou senha inválidos" });
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter token");
                return StatusCode(500, new { message = "Erro interno do servidor" });
            }
        }

        /// <summary>
        /// Atualiza o token JWT usando um refresh token
        /// </summary>
        [HttpPost("refresh-token")]
        [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<AuthResponse>> RefreshToken([FromBody] RefreshTokenModel model)
        {
            try
            {
                var response = await _authService.RefreshTokenAsync(model.RefreshToken);
                
                if (response == null)
                {
                    return Unauthorized(new { message = "Refresh token inválido ou expirado" });
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar token");
                return StatusCode(500, new { message = "Erro interno do servidor" });
            }
        }

        /// <summary>
        /// Revoga um refresh token
        /// </summary>
        [Authorize]
        [HttpPost("revoke-token")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RevokeToken([FromBody] RefreshTokenModel model)
        {
            try
            {
                var result = await _authService.RevokeTokenAsync(model.RefreshToken);
                
                if (!result)
                {
                    return BadRequest(new { message = "Refresh token inválido" });
                }

                return Ok(new { message = "Token revogado com sucesso" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao revogar token");
                return StatusCode(500, new { message = "Erro interno do servidor" });
            }
        }
    }
} 