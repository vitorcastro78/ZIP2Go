using Azure.Identity;
using EasyCaching.SQLite;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Service;
using Service.Client;
using Service.Interfaces;
using System.Text;
using ZIP2Go.WebAPI.AuthService.Models;
using ZIP2Go.WebAPI.AuthService.Services;
using ZIP2Go.WebAPI.Extensions;
using ZIP2Go.WorkServices.HostedService;
using ZIP2GO.WebAPI.Filters;

var builder = WebApplication.CreateBuilder(args);

var options = new ZuoraOptions();
builder.Configuration.GetSection("Zuora").Get<ZuoraOptions>();

// Add services to the container.
ConfigureServices(builder.Services, builder.Configuration);

builder.Services.AddApplicationInsightsTelemetry(new Microsoft.ApplicationInsights.AspNetCore.Extensions.ApplicationInsightsServiceOptions
{
    ConnectionString = builder.Configuration["APPLICATIONINSIGHTS_CONNECTION_STRING"]
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

// Adiciona o middleware de logging do Application Insights
app.UseApplicationInsightsLogging();

// Adiciona o middleware CORS
app.UseCors();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();

static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true).AddNewtonsoftJson();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();

    // Configuração do CORS
    services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
    });

    // Configuração JWT
    var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>();
    services.AddSingleton(jwtSettings);

    ConfigureAuthService(services);
    ConfigureHostedService(services);

    services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings.Issuer,
            ValidAudience = jwtSettings.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.SecretKey))
        };
    });

    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "Zuora Accelerator Plataform",
            Version = "v1",
            Description = "Api Methods for Zuora Billing Integration",
            Contact = new OpenApiContact
            {
                Name = "Subscription Factory NL",
                Url = new Uri("https://www.subscriptionfactory.com"),
                Email = "vitor.castro@subscriptionfactory.com"
            }
        });

        // Configuração do Swagger para JWT
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = "JWT Authorization header using the Bearer scheme",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer"
        });

        c.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
        });

        var filePath = Path.Combine(AppContext.BaseDirectory, "zip2go.xml");
        c.IncludeXmlComments(filePath);
    });

    services.AddEasyCaching(option =>
    {
        // Criar diretório se não existir
        var cacheDir = Path.Combine(Directory.GetCurrentDirectory(), "Cache");
        if (!Directory.Exists(cacheDir))
        {
            Directory.CreateDirectory(cacheDir);
        }

        option.UseSQLite(config =>
        {
            config.DBConfig = new SQLiteDBOptions
            {
                FileName = "caching.db",
                FilePath = cacheDir  // Caminho separado do nome do arquivo
            };
        });
    });

    // Adiciona serviços do framework
    services.AddMvc(options =>
    {
        var IServiceScopeFactory = services.BuildServiceProvider().GetRequiredService<IServiceScopeFactory>();
        options.Filters.Add(new ActionFilter(IServiceScopeFactory));
    });

    // Registrar os serviços da aplicação
    services.AddApplicationServices();

    // Registrar o HttpContextAccessor
    services.AddHttpContextAccessor();

   
}

static void ConfigureAuthService(IServiceCollection services)
{
    services.AddScoped<IAuthService, AuthService>();
}

static void ConfigureHostedService(IServiceCollection services)
{
      services.AddHostedService<AccountsHostedService>();
    //services.AddHostedService<SubscriptionsHostedService>();
    //services.AddHostedService<InvoicesHostedService>();
}

