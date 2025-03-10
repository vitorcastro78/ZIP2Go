using EasyCaching.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Repository.DataContext;
using Service.Client;
using Service.Interfaces;
using System;
using ZIP2GO.Service;
using ZIP2GO.WebAPI.Filters;

var builder = WebApplication.CreateBuilder(args);

var options = new ZuoraOptions();
builder.Configuration.GetSection("Zuora").Get<ZuoraOptions>();

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
    builder.Services.AddScoped<ISubscriptionPlansService, SubscriptionPlansService>();
    builder.Services.AddScoped<IOrdersService, OrdersService>();
    builder.Services.AddScoped<IPaymentMethodsService, PaymentMethodsService>();
    builder.Services.AddScoped<IProductsService, ProductsService>();
    builder.Services.AddScoped<IContactsService, ContactsService>();
    builder.Services.AddScoped<IBillingDocumentItemsService, BillingDocumentItemsService>();
    builder.Services.AddScoped<IBillingDocumentsService, BillingDocumentsService>();
    builder.Services.AddScoped<IWorkflowsService, WorkflowsService>();
}

static void ConfigureServices(IServiceCollection services)
{
    services.AddControllers().AddNewtonsoftJson();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();

    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1",

      new OpenApiInfo
      {
          Title = "Zuora Integration Plataform",
          Version = "v1",
          Description = "Api Methods for Zuora Billing Integration",
          Contact = new OpenApiContact
          {
              Name = "Vitor Castro",
              Url = new Uri("https://www.zuora.com"),
              Email = "vitorcastro78@gmail.com"
          }
      });
        var filePath = Path.Combine(AppContext.BaseDirectory, "zip2go.xml");
        c.IncludeXmlComments(filePath);
    });

    // services.AddDbContext<AppDataContext>(options => options.UseSqlite("Database\\subscription.db"));

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
    
    app.UseSwagger();

    app.UseStaticFiles();

    app.UseSwaggerUI();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}