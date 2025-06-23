using RestSharp;
using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoicesService
    {

        Invoice CancelInvoice(string invoiceId, string zuoraTrackId, bool? async);

        Invoice CreateInvoice(InvoiceCreateRequest body, string zuoraTrackId, bool? async);

        void DeleteInvoice(string invoiceId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Email an invoice Emails an invoice to the email address specified in the invoice's bill-to account. If the bill-to account does not have an email address, Zuora returns a 400 error.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        void EmailInvoice(string invoiceId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Get invoice items Retrieves the invoice items for an invoice with the given invoice ID. You can retrieve posted, unposted, or canceled invoice items.
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        InvoiceItemListResponse GetInvoiceItems(string zuoraTrackId, bool? async);

        /// <summary>
        /// Get invoice items Retrieves the invoice items for an invoice with the given invoice ID. You can retrieve posted, unposted, or canceled invoice items.
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        InvoiceListResponse GetInvoices(string zuoraTrackId, bool? async);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        void FillInvoicesCache(string zuoraTrackId, bool async);

        /// <summary>
        /// Get an invoice Retrieves an invoice with the given invoice ID. You can retrieve a posted, unposted, or canceled invoice.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Invoice GetInvoice(string invoiceId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Patch an invoice Patches an invoice with the given invoice ID. You cannot patch an invoice that has been posted or canceled.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Invoice PatchInvoice(InvoicePatchRequest body, string invoiceId, string zuoraTrackId, bool? async);


        /// <summary>
        /// Pay an invoice Pays an invoice by applying a payment to the invoice.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Invoice PayInvoice(PayInvoiceRequest body, string invoiceId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Post an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Invoice PostInvoice(string invoiceId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Reverse an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Invoice ReverseInvoice(InvoiceReverseRequest body, string invoiceId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Unpost an invoice
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Invoice UnpostInvoice(string invoiceId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Write off an invoice
        /// </summary>
        /// <param name="body"></param>
        /// <param name="invoiceId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        CreditMemo WriteOffInvoice(WriteOffRequest body, string invoiceId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Get invoice items cached
        /// </summary>
        /// <returns></returns>
        InvoiceItemListResponse GetInvoiceItemsCached();

        /// <summary>
        /// Get invoices cached
        /// </summary>
        /// <returns></returns>
        InvoiceListResponse GetInvoicesCached();

        /// <summary>
        /// Get invoice cached
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        Invoice GetInvoiceCached(string invoiceId);

        /// <summary>
        /// Get invoices cached by account ID
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        InvoiceListResponse GetInvoicesCachedByAccountId(string accountId);


        /// <summary>
        /// Get invoices by account ID
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        InvoiceListResponse GetInvoicesByAccountId(string accountId, string zuoraTrackId, bool? async);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        void FillInvoicesItemsCache(string zuoraTrackId, bool async);
    }
}