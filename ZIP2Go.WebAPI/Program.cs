using EasyCaching.SQLite;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Service.Interfaces;
using ZIP2GO.Service;
using ZIP2GO.Service.Client;
using ZIP2GO.Service.Client.Auth0Management;
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

    builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
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

static void ConfigureAuth0Service(IServiceCollection services, IConfiguration configuration)
{
    services.Configure<Auth0Options>(configuration.GetSection(ConfigSections.AUTH0));
    services.AddScoped<IAuth0Service, Auth0Service>();
}
static void ConfigureWebApp(WebApplication app)
{
    // Configure the HTTP request pipeline.


    JsonSerializerSettings defaultJsonSettings = JsonConvert.DefaultSettings != null ? JsonConvert.DefaultSettings() : new JsonSerializerSettings();
    defaultJsonSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    JsonConvert.DefaultSettings = () => defaultJsonSettings;


    app.UseSwagger();

    app.UseStaticFiles();

    app.UseSwaggerUI(config =>
    {
        config.ConfigObject.AdditionalItems["syntaxHighlight"] = new Dictionary<string, object>
        {
            ["activated"] = false
        };
    });

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}

