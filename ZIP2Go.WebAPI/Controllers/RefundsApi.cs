using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Service;
using Service.Interfaces;
using Service.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using ZIP2GO.WebAPI.Attributes;
using ZIP2GO.WebAPI.Security;

namespace ZIP2GO.WebAPI.Controllers
{
    /// <summary>
    /// Controller responsible for managing refunds in the system.
    /// Provides endpoints for creating, updating, deleting, and querying refunds.
    /// </summary>
    [ApiController]
    public class RefundsController : ControllerBase
    {
        private readonly IRefundsService _refundsService;

        /// <summary>
        /// Initializes a new instance of the refunds controller.
        /// </summary>
        /// <param name="refundsService">Service for managing refunds</param>
        /// <param name="httpContextAccessor">HTTP context accessor</param>
        /// <param name="cache">Cache provider</param>
        /// <exception cref="ArgumentNullException">Thrown when any dependency is null</exception>
        public RefundsController(
            IRefundsService refundsService)
        {
            _refundsService = refundsService ?? throw new ArgumentNullException(nameof(refundsService));
        }

        /// <summary>
        /// Creates a new refund.
        /// </summary>
        /// <param name="body">Refund data to create</param>
        /// <returns>The newly created refund</returns>
        /// <response code="201">Refund created successfully</response>
        /// <response code="400">Invalid refund data</response>
        [HttpPost]
        [Route("/refunds")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateRefund")]
        public async Task<IActionResult> CreateRefund([FromBody] RefundCreateRequest body, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _refundsService.CreateRefund(body, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves a refund by its ID.
        /// </summary>
        /// <param name="refundId">The unique identifier of the refund</param>
        /// <returns>The requested refund details</returns>
        /// <response code="200">Refund found and returned</response>
        /// <response code="404">Refund not found</response>
        [HttpGet]
        [Route("/refunds/{refund_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetRefund")]
        public async Task<IActionResult> GetRefund([FromRoute][Required] string refundId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            if (string.IsNullOrEmpty(refundId)) return BadRequest("refundId cannot be null");
            if (string.IsNullOrEmpty(zuoraTrackId)) return BadRequest("zuoraTrackId cannot be null");

            var refund = _refundsService.GetRefundCached(refundId);
            if (refund is null) refund = _refundsService.GetRefund(refundId, zuoraTrackId, async);

            return Ok(refund);
        }

        /// <summary>
        /// Retrieves a list of all refunds.
        /// </summary>
        /// <returns>A paginated list of refunds</returns>
        /// <response code="200">List of refunds retrieved successfully</response>
        [HttpGet]
        [Route("/refunds")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetRefunds")]
        public async Task<IActionResult> GetRefunds([FromQuery] string cursor, string zuoraTrackId, bool async = true)
        {
            var refunds = _refundsService.GetRefundsCached();

            if (refunds.Data.Count() == 0) refunds = _refundsService.GetRefunds(cursor, zuoraTrackId, async);

            return Ok(refunds);
        }

        /// <summary>
        /// Updates an existing refund.
        /// </summary>
        /// <param name="body">Updated refund data</param>
        /// <param name="refundId">ID of the refund to update</param>
        /// <returns>The updated refund information</returns>
        /// <response code="200">Refund updated successfully</response>
        /// <response code="404">Refund not found</response>
        [HttpPatch]
        [Route("/refunds/{refund_id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateRefund")]
        public async Task<IActionResult> UpdateRefund([FromBody] RefundPatchRequest body, [FromRoute][Required] string refundId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _refundsService.UpdateRefund(body, refundId, zuoraTrackId, async);
            return Ok(result);
        }
    }
}