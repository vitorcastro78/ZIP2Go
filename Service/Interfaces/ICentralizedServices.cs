using Service.Models;

namespace Service.Interfaces
{
    public interface ICentralizedServices
    {
        Account GetAccount(string accountId, string zuoraTrackId = "", bool async = true);
        Invoice GetInvoice(string invoiceId, string zuoraTrackId = "", bool async = true);
        Order GetOrder(string orderId, string zuoraTrackId = "", bool async = true);
        Payment GetPayment(string paymentId, string zuoraTrackId = "", bool async = true);
        Plan GetPlan(string planId, string zuoraTrackId = "", bool async = true);
        Price GetPrice(string priceId, string zuoraTrackId = "", bool async = true);
        Product GetProduct(string productId, string zuoraTrackId = "", bool async = true);
        Refund GetRefund(string refundId, string zuoraTrackId = "", bool async = true);
        Subscription GetSubscription(string subscriptionId, string zuoraTrackId = "", bool async = true);
    }
}