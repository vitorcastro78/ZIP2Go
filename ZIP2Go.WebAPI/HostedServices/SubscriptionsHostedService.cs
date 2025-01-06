using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using ZIP2Go.Service;
using ZIP2Go.Models;
using Service.Interfaces;

namespace ZIP2GO.WebAPI.HostedService
{

    public class SubscriptionsHostedService : BackgroundService
    {
        private readonly ILogger<SubscriptionsHostedService> _logger;
        private Timer? _timer = null;
        private int CountRound = 0;

        public SubscriptionsHostedService(
            IServiceProvider services,
            ILogger<SubscriptionsHostedService> logger)
        {
            Services = services;
            _logger = logger;
        }

        public IServiceProvider Services { get; }
        public ISubscriptionsService subscriptionsService { get; }

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
            _timer = new Timer( DoWork, null, TimeSpan.Zero,
            TimeSpan.FromMinutes(15));

        }

        private async void DoWork(object? state)
        {
            _logger.LogInformation($"Hosted Service started round {CountRound}.");
           
        }
    }
}
