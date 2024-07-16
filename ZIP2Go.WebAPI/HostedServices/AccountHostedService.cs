using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using ZIP2Go.Service;

namespace ZIP2GO.WebAPI.HostedService
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

        public IServiceProvider Services { get; }

        public IAccountsApi accountsApi { get; }

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
