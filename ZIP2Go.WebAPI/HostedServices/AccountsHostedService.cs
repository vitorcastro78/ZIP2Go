using Microsoft.Extensions.DependencyInjection;
using Service;
using Service.Interfaces;

namespace ZIP2Go.WorkServices.HostedService
{
    public class AccountsHostedService : BackgroundService
    {
        private readonly ILogger<AccountsHostedService> _logger;

        private readonly IServiceScopeFactory _services;

        private Timer? _timer = null;


        public AccountsHostedService(
            IServiceScopeFactory services,
            ILogger<AccountsHostedService> logger)
        {
            _services = services;
            _logger = logger;
        }



        public override async Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Consume Scoped Service Hosted Service is stopping.");

            await base.StopAsync(stoppingToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Consume Scoped Service Hosted Service running.");
            _timer = new Timer(DoWork, null, TimeSpan.Zero,
             TimeSpan.FromHours(23));
        }

        private async void DoWork(object? state)
        {
            string zuoraTrackId = new Guid().ToString();
            bool async = true;
     
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IAccountsService>();
         
                service.FillAccountsCache(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ISubscriptionsService>();
              
                service.FillSubscriptionsCache(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IProductsService>();

                service.FillProductsCache(zuoraTrackId, async);
            }
 
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IInvoicesService>();

                service.FillInvoicesCache(zuoraTrackId, async);
                service.FillInvoicesItemsCache(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IPlansService>();

                service.FillPlansCache(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ISubscriptionPlansService>();

                service.FillSubscriptionPlansCached();
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IPricesService>();

                service.FillPricesCache(zuoraTrackId,async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IDebitMemosService>();

                service.FillDebitMemosCache(zuoraTrackId, async);
                service.FillDebitMemosItemsCache(zuoraTrackId, async);
            }

            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ICreditMemosService>();

                service.FillCreditMemosCache(zuoraTrackId, async);
                service.FillCreditMemosItemsCache(zuoraTrackId, async);
            }
        }


    }
}