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
    ///
    /// </summary>
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoicesService _invoicesService;

        public InvoicesController(
            IInvoicesService invoicesService)
        {
            _invoicesService = invoicesService ?? throw new ArgumentNullException(nameof(invoicesService));
        }

        /// <summary>
        /// Cancel an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/invoices/{invoiceId}/cancel")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CancelInvoice")]
        [SwaggerResponse(statusCode: 200, type: typeof(Invoice), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> CancelInvoice([FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _invoicesService.CancelInvoice(invoiceId, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Create an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/invoices")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("CreateInvoice")]
        [SwaggerResponse(statusCode: 201, type: typeof(Invoice), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> CreateInvoice([FromBody] InvoiceCreateRequest body, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _invoicesService.CreateInvoice(body, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Delete an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/invoices/{invoiceId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DeleteInvoice")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> DeleteInvoice([FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            _invoicesService.DeleteInvoice(invoiceId, zuoraTrackId, async);
            return NoContent();
        }

        /// <summary>
        /// Email an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/invoices/{invoiceId}/email")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailInvoice")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> EmailInvoice([FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            _invoicesService.EmailInvoice(invoiceId, zuoraTrackId, async);
            return NoContent();
        }

        /// <summary>
        /// Get an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/invoices/{invoiceId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetInvoice")]
        [SwaggerResponse(statusCode: 200, type: typeof(Invoice), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> GetInvoice([FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            if (string.IsNullOrEmpty(invoiceId)) 
            {
                return BadRequest("invoiceId cannot be null");
            }
            if (string.IsNullOrEmpty(zuoraTrackId)) 
            {
                return BadRequest("zuoraTrackId cannot be null");
            }

            var invoice = _invoicesService.GetInvoiceCached(invoiceId);
            if (invoice is null) 
            {
                invoice = _invoicesService.GetInvoice(invoiceId, zuoraTrackId, async);
            }
            return Ok(invoice);
        }

        /// <summary>
        /// Retrieves a subscription by its ID.
        /// </summary>
        /// <param name="subscriptionId">The unique identifier of the subscription</param>
        /// <returns>The requested subscription details</returns>
        /// <response code="200">Subscription found and returned</response>
        /// <response code="404">Subscription not found</response>
        [HttpGet]
        [Route("/invoices/account/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetSInvoicesByAccountId")]
        public async Task<IActionResult> GetInvoicesByAccountId([FromRoute][Required] string id, [FromQuery] string zuoraTrackId, bool async = true)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest("accountId cannot be null");
            if (string.IsNullOrEmpty(zuoraTrackId)) return BadRequest("zuoraTrackId cannot be null");

            var subscription = _invoicesService.GetInvoicesCachedByAccountId(id);

            if (!subscription.Data.Any())
            {
                subscription = _invoicesService.GetInvoicesByAccountId(id, zuoraTrackId, async);
            }

            return Ok(subscription);
        }

        /// <summary>
        /// List invoice items
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/invoice_items")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetInvoiceItems")]
        [SwaggerResponse(statusCode: 200, type: typeof(InvoiceItemListResponse), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> GetInvoiceItems([FromQuery] string zuoraTrackId, bool async = true)
        {
            var invoiceItems = _invoicesService.GetInvoiceItemsCached();

            if (!invoiceItems.Data.Any()) 
            {
                invoiceItems = _invoicesService.GetInvoiceItems(zuoraTrackId, async);
            }
            return Ok(invoiceItems);
        }

        /// <summary>
        /// List invoices
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/invoices")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetInvoices")]
        [SwaggerResponse(statusCode: 200, type: typeof(InvoiceListResponse), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> GetInvoices([FromQuery] string zuoraTrackId, bool async = true)
        {
            var invoices = _invoicesService.GetInvoicesCached();

            if (invoices.Data.Count() == 0) invoices = _invoicesService.GetInvoices(zuoraTrackId, async);

            return Ok(invoices);
        }

        /// <summary>
        /// Patch an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpPatch]
        [Route("/invoices/{invoiceId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PatchInvoice")]
        [SwaggerResponse(statusCode: 200, type: typeof(Invoice), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> PatchInvoice([FromBody] InvoicePatchRequest body, [FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _invoicesService.PatchInvoice(body, invoiceId, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Pay an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/invoices/{invoiceId}/pay")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PayInvoice")]
        [SwaggerResponse(statusCode: 200, type: typeof(Invoice), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> PayInvoice([FromBody] PayInvoiceRequest body, [FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _invoicesService.PayInvoice(body, invoiceId, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Post an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/invoices/{invoiceId}/post")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PostInvoice")]
        [SwaggerResponse(statusCode: 200, type: typeof(Invoice), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> PostInvoice([FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _invoicesService.PostInvoice(invoiceId, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Reverse an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/invoices/{invoiceId}/reverse")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ReverseInvoice")]
        [SwaggerResponse(statusCode: 200, type: typeof(Invoice), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> ReverseInvoice([FromBody] InvoiceReverseRequest body, [FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _invoicesService.ReverseInvoice(body, invoiceId, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Unpost an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/invoices/{invoiceId}/unpost")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UnpostInvoice")]
        [SwaggerResponse(statusCode: 200, type: typeof(Invoice), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> UnpostInvoice([FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _invoicesService.UnpostInvoice(invoiceId, zuoraTrackId, async);
            return Ok(result);
        }

        /// <summary>
        /// Write off an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/invoices/{invoiceId}/write-off")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("WriteOffInvoice")]
        [SwaggerResponse(statusCode: 200, type: typeof(CreditMemo), description: "Default Response")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(ErrorResponse), description: "Method Not Allowed")]
        [SwaggerResponse(statusCode: 429, type: typeof(ErrorResponse), description: "Too Many Requests")]
        [SwaggerResponse(statusCode: 500, type: typeof(ErrorResponse), description: "Internal Server Error")]
        [SwaggerResponse(statusCode: 502, type: typeof(ErrorResponse), description: "Bad Gateway")]
        [SwaggerResponse(statusCode: 503, type: typeof(ErrorResponse), description: "Service Unavailable")]
        [SwaggerResponse(statusCode: 504, type: typeof(ErrorResponse), description: "Gateway Timeout")]
        public async Task<IActionResult> WriteOffInvoice([FromBody] WriteOffRequest body, [FromRoute][Required] string invoiceId, [FromQuery] string zuoraTrackId, bool async = true)
        {
            var result = _invoicesService.WriteOffInvoice(body, invoiceId, zuoraTrackId, async);

            return Ok(result);
        }
    }
}