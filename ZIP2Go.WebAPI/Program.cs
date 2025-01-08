using EasyCaching.SQLite;
using Microsoft.AspNetCore.Builder;
using Service.Interfaces;
using ZIP2Go.Service;
using ZIP2Go.WebAPI.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add Dependency Injection to the container.
AddDependencyInjection(builder);
// Add services to the container.
ConfigureServices(builder.Services);
var app = builder.Build();
// Configure WebApp
ConfigureWebApp(app);

static void AddDependencyInjection(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<IAccountsService, AccountsService>();
    builder.Services.AddScoped<IInvoicesService, InvoicesService>();
    builder.Services.AddScoped<ISubscriptionsService, SubscriptionsService>();
    builder.Services.AddScoped<ISubscriptionItemsService, SubscriptionItemsService>();
    builder.Services.AddScoped<IOrdersService, OrdersService>();
}

static void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    // services.AddEndpointsServiceExplorer();
    services.AddSwaggerGen();

    services.AddEasyCaching(option =>
    {
        // use sqlite cache
        option.UseSQLite(config =>
        {
            config.DBConfig = new SQLiteDBOptions { FileName = "Cache\\cache.db" };
        });
    });

    // Adiciona serviços do framework
    services.AddMvc(options =>
    {
        //adicionado por instância
        options.Filters.Add(new ActionFilter());
        //adicionado por tipo
    });
}

static void ConfigureWebApp(WebApplication app)
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(config =>
        {
            config.ConfigObject.AdditionalItems["syntaxHighlight"] = new Dictionary<string, object>
            {
                ["activated"] = false
            };
        });
    }
    app.MapSwagger().RequireAuthorization();


    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}