using Microsoft.EntityFrameworkCore;
using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Interface;
using RedCloud.Persistenence;
using RedCloud.Service;
using Serilog;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
IConfiguration Configuration = builder.Configuration;
builder.Services.AddControllersWithViews();

// Add distributed memory cache for session
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(60);
});


//logger setup
Log.Logger = new LoggerConfiguration().CreateBootstrapLogger();
builder.Host.UseSerilog(((ctx, lc) => lc
.ReadFrom.Configuration(ctx.Configuration)));


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped(typeof(IApiClient<>), typeof(ApiClient<>));
builder.Services.AddScoped<IReSellerAdminService, ReSellerAdminService>();
builder.Services.AddScoped(typeof(IDropDownService<CountryVM>),typeof(DropDownService<CountryVM>));
builder.Services.AddScoped(typeof(IStateService<StateVM>), typeof(StateService<StateVM>));
builder.Services.AddScoped(typeof(ICityService<CityVM>), typeof(CityService<CityVM>));

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

app.UseSerilogRequestLogging();
app.UseSession();
app.UseRouting();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
