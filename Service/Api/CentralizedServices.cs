using RestSharp;
using Service.Interfaces;
using Service.Client;
using Service.Models;
using EasyCaching.Core;

namespace Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CentralizedServices : ICentralizedServices
    {
        private readonly IAccountsService _accountsService;
        private readonly ISubscriptionsService _subscriptionsService;
        private readonly IInvoicesService _invoicesService;
        private readonly IPaymentsService _paymentsService;
        private readonly IRefundsService _refundsService;
        private readonly IProductsService _productsService;
        private readonly IPlansService _plansService;
        private readonly IOrdersService _ordersService;
        private readonly IPricesService _pricesService;

        public CentralizedServices(
            IAccountsService accountsService,
            ISubscriptionsService subscriptionsService,
            IInvoicesService invoicesService,
            IPaymentsService paymentsService,
            IRefundsService refundsService,
            IProductsService productsService,
            IPlansService plansService,
            IOrdersService ordersService,
            IPricesService pricesService)
        {
            _accountsService = accountsService;
            _subscriptionsService = subscriptionsService;
            _invoicesService = invoicesService;
            _paymentsService = paymentsService;
            _refundsService = refundsService;
            _productsService = productsService;
            _plansService = plansService;
            _ordersService = ordersService;
            _pricesService = pricesService;
        }

        public Account GetAccount(string accountId, string zuoraTrackId = "", bool async = true)
        {
            return _accountsService.GetAccount(accountId, zuoraTrackId, async);
        }

        public Invoice GetInvoice(string invoiceId, string zuoraTrackId = "", bool async = true)
        {
            return _invoicesService.GetInvoice(invoiceId, zuoraTrackId, async);
        }
        public Subscription GetSubscription(string subscriptionId, string zuoraTrackId = "", bool async = true)
        {
            return _subscriptionsService.GetSubscriptionByKey(subscriptionId, zuoraTrackId, async);
        }
        public Payment GetPayment(string paymentId, string zuoraTrackId = "", bool async = true)
        {
            return _paymentsService.GetPayment(paymentId, zuoraTrackId, async);
        }
        public Refund GetRefund(string refundId, string zuoraTrackId = "", bool async = true)
        {
            return _refundsService.GetRefund(refundId, zuoraTrackId, async);
        }
        public Product GetProduct(string productId, string zuoraTrackId = "", bool async = true)
        {
            return _productsService.GetProduct(productId, zuoraTrackId, async);
        }
        public Plan GetPlan(string planId, string zuoraTrackId = "", bool async = true)
        {
            return _plansService.GetPlan(planId, zuoraTrackId, async);
        }
        public Order GetOrder(string orderId, string zuoraTrackId = "", bool async = true)
        {
            return _ordersService.GetOrder(orderId, zuoraTrackId, async);
        }
        public Price GetPrice(string priceId, string zuoraTrackId = "", bool async = true)
        {
            return _pricesService.GetPrice(priceId, zuoraTrackId, async);
        }


    }
}