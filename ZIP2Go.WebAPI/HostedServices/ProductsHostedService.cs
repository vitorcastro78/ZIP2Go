using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;

namespace ZIP2Go.WorkServices.HostedService
{
    public class ProductsHostedService : BackgroundService
    {
        private readonly ILogger<ProductsHostedService> _logger;

        private readonly IServiceScopeFactory _services;

        private Timer? _timer = null;


        public ProductsHostedService(
            IServiceScopeFactory services,
            ILogger<ProductsHostedService> logger)
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
            TimeSpan.FromMinutes(15));
        }

        private async void DoWork(object? state)
        {
            string zuoraTrackId = new Guid().ToString();
            bool async = true;
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<IProductsService>();

                service.FillProductsCache(zuoraTrackId, async);
            }
        }


    }
}