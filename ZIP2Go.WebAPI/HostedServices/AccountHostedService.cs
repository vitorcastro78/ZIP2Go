using Service.Interfaces;

namespace Zip2Go.WebAPI.HostedService
{
    public class AccountHostedService : BackgroundService
    {
        private readonly ILogger<AccountHostedService> _logger;

        private Timer? _timer = null;

        private int CountRound = 0;

        public AccountHostedService(
            IServiceProvider services,
            ILogger<AccountHostedService> logger)
        {
            Services = services;
            _logger = logger;
        }

        public IAccountsService accountsService { get; }

        public IServiceProvider Services { get; }

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