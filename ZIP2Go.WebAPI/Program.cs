using EasyCaching.SQLite;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.OpenApi.Models;
using Service.Client;
using ZIP2Go.WebAPI.Extensions;
using Service.Client;
using Service.Client.Auth0Management;
using ZIP2GO.WebAPI.Filters;

var builder = WebApplication.CreateBuilder(args);

var options = new ZuoraOptions();
builder.Configuration.GetSection("Zuora").Get<ZuoraOptions>();

// Add services to the container.
ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

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
    });

    // Registrar os serviços da aplicação
    services.AddApplicationServices();

    // Registrar o HttpContextAccessor
    services.AddHttpContextAccessor();
}

static void ConfigureAuth0Service(IServiceCollection services, IConfiguration configuration)
{
    services.Configure<Auth0Options>(configuration.GetSection(ConfigSections.AUTH0));
    services.AddScoped<IAuth0Service, Auth0Service>();
}