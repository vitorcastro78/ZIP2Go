using Service.Interfaces;

namespace Zip2Go.WebAPI.HostedService
{
    public class SubscriptionItemsHostedService : BackgroundService
    {
        private readonly ILogger<SubscriptionsHostedService> _logger;

        private Timer? _timer = null;

        private int CountRound = 0;

        public SubscriptionItemsHostedService(
            IServiceProvider services,
            ILogger<SubscriptionsHostedService> logger)
        {
            Services = services;
            _logger = logger;
        }

        public IServiceProvider Services { get; }

        public ISubscriptionItemsService SubscriptionItemsService { get; }

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
            _logger.LogInformation($"Hosted Service started round {CountRound}.");
        }
    }
}