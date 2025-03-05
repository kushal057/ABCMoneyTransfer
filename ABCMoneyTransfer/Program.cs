using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ABC.Infrastructure.Identity.Data;
using ABC.Core.Interfaces;
using ABC.Application.Services;
using ABC.Core.Interfaces.Repository;
using ABC.Infrastructure;
using ABC.Core.Interfaces.Services;
using ABC.Client.APIClients;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppDBContextConnection") ?? throw new InvalidOperationException("Connection string 'AppDBContextConnection' not found.");

builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AppDBContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IMoneyTransferService, MoneyTransferService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddHttpClient<ExchangeRateApiClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
