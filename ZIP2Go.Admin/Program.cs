using Admin.Repository.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Admin.Repository.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ZIP2GoAdminContextConnection") ?? throw new InvalidOperationException("Connection string 'ZIP2GoAdminContextConnection' not found.");

builder.Services.AddDbContext<IdentityContext>(options => options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<AdminUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<IdentityContext>();

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<AdminDataContext>(options => new AdminDataContext(connectionString));
builder.Services.AddSingleton<IdentityContext>(options => new IdentityContext(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
