using Microsoft.EntityFrameworkCore;
using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Interface;
using RedCloud.Persistenence;
using RedCloud.Service;
using Serilog;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
IConfiguration Configuration = builder.Configuration;


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddScoped(typeof(IApiClient<>), typeof(ApiClient<>));
builder.Services.AddScoped<IAccountService, AccountService>();



var app = builder.Build();


////logger setup
//Log.Logger = new LoggerConfiguration().CreateBootstrapLogger();
//builder.Host.UseSerilog(((ctx, lc) => lc
//.ReadFrom.Configuration(ctx.Configuration)));




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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
