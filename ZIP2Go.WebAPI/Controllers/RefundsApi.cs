using EasyCaching.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZIP2GO.Service.Models;
using Newtonsoft.Json;
using Service.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

using ZIP2GO.WebAPI.Attributes;
using ZIP2GO.WebAPI.Security;
using ZIP2Go.WebAPI.Controllers;

namespace ZIP2GO.WebAPI.Controllers
{
    [ApiController]
    public class RefundsController : ControllerBaseApi
    {
        private readonly IRefundsService _refundsService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEasyCachingProvider _cacheProvider;

        public RefundsController(
            IRefundsService refundsService,
            IHttpContextAccessor httpContextAccessor,
            IEasyCachingProvider cache) : base(httpContextAccessor, cache)
        {
            _refundsService = refundsService ?? throw new ArgumentNullException(nameof(refundsService));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            _cacheProvider = cache ?? throw new ArgumentNullException(nameof(cache));
        }

        [HttpPost]
        [Route("/v2/refunds/{refund_id}/cancel")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CancelRefund")]
        public async Task<IActionResult> CancelRefund([FromRoute][Required] string refundId)
        {
            return new ObjectResult(null);
        }

        [HttpPost]
        [Route("/v2/refunds")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateRefund")]
        public async Task<IActionResult> CreateRefund([FromBody] RefundCreateRequest body)
        {
            return new ObjectResult(null);
        }

        [HttpDelete]
        [Route("/v2/refunds/{refund_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DeleteRefund")]
        public async Task<IActionResult> DeleteRefund([FromRoute][Required] string refundId)
        {
            return new ObjectResult(null);
        }

        [HttpGet]
        [Route("/v2/refunds/{refund_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetRefund")]
        public async Task<IActionResult> GetRefund([FromRoute][Required] string refundId)
        {
            return new ObjectResult(null);
        }

        [HttpGet]
        [Route("/v2/refunds")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetRefunds")]
        public async Task<IActionResult> GetRefunds()
        {
            return new ObjectResult(null);
        }
    }
} 
