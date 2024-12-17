using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using ZIP2Go.Service;
using Service.Interfaces;

namespace ZIP2GO.WebAPI.HostedService
{

    public class InvoicesHostedService : BackgroundService
    {
        private readonly ILogger<InvoicesHostedService> _logger;
        private Timer? _timer = null;
        private int CountRound = 0;

        public InvoicesHostedService(
            IServiceProvider services,
            ILogger<InvoicesHostedService> logger)
        {
            Services = services;
            _logger = logger;
        }

        public IServiceProvider Services { get; }

        public IInvoicesService InvoicesService { get; }

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
