using ZIP2GO.Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBillingDocumentItemsService
    {
        /// <summary>
        /// List billing document items List billing document items
        /// </summary>
        /// <param name="cursor">A cursor for use in pagination. A cursor defines the starting place in a list. For instance, if you make a list request and receive 100 objects, ending with &#x60;next_page&#x3D;W3sib3JkZXJ&#x3D;&#x60;, your subsequent call can include &#x60;cursor&#x3D;W3sib3JkZXJ&#x3D;&#x60; in order to fetch the next page of the list.</param>
        /// <returns>BillingDocumentItemListResponse</returns>
        BillingDocumentItemListResponse GetBillingDocumentItems(string cursor, string zuoraTrackId, bool? async);
    }
}