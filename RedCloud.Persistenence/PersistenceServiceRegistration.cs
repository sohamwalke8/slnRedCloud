using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Persistenence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Persistenence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContex>(options => 
                            options.UseSqlServer(configuration.GetConnectionString("RedCloudPortal")));

            services.AddScoped(typeof(IAccountRepository), typeof(AccountRepository));
            
            return services;
        }
    }
}
