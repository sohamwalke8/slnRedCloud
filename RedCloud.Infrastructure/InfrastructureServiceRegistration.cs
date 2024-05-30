using RedCloud.Infrastructure.Cache;
using RedCloud.Infrastructure.FileExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        //public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
        //    services.AddTransient<ICsvExporter, CsvExporter>();
        //    services.AddTransient<IEmailService, EmailService>();
        //    services.Configure<CacheConfiguration>(configuration.GetSection("CacheConfiguration"));
        //    services.AddMemoryCache();
        //    services.AddTransient<ICacheService, MemoryCacheService>();
        //    services.AddSendGrid(options => { options.ApiKey = configuration.GetValue<string>("EmailSettings:ApiKey"); });
        //    return services;
        //}

    }
}