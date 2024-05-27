using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Interface;
using RedCloud.Models;
using RedCloud.Persistenence.Repositories;
using RedCloud.Service;
using RedCloud.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped(typeof(IApiClient<>), typeof(ApiClient<>));
builder.Services.AddScoped<IReSellerAdminService, ReSellerAdminService>();
builder.Services.AddScoped(typeof(IDropDownService<CountryVM>),typeof(DropDownService<CountryVM>));
builder.Services.AddScoped(typeof(IStateService<StateVM>), typeof(StateService<StateVM>));
builder.Services.AddScoped(typeof(ICityService<CityVM>), typeof(CityService<CityVM>));

builder.Services.AddScoped<IAdminUserService, AdminUserService>();
builder.Services.AddScoped<IOrganizationAdminService, OrganizationAdminService>();
builder.Services.AddScoped(typeof(IApiClient<>), typeof(ApiClient<>));

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=RedCloudUserAdmin}/{action=AddAdmin}/{id?}");

app.Run();
