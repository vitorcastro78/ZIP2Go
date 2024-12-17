using EasyCaching.SQLite;
using Service.Interfaces;
using ZIP2Go.Service;

var builder = WebApplication.CreateBuilder(args);

AddDependencyInjection(builder);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEasyCaching(option =>
{
    // use sqlite cache
    option.UseSQLite(config =>
    {
        config.DBConfig = new SQLiteDBOptions { FileName = "Cache\\cache.db" };
    });
});
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

static void AddDependencyInjection(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<IAccountsService, AccountsService>();
    builder.Services.AddScoped<IInvoicesService, InvoicesService>();
    builder.Services.AddScoped<ISubscriptionsService, SubscriptionsService>();
    builder.Services.AddScoped<ISubscriptionItemsService, SubscriptionItemsService>();
}