using Microsoft.EntityFrameworkCore;
using RedCloud.Application.Contract;
using RedCloud.Domain.Entities;

using System.Data;

namespace RedCloud.Persistenence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        
         public DbSet<ResellerAdmin> ReSellerAdmins { get; set; }
        public DbSet<OrganizationAdmin> OrganizationAdmins { get; set; }

        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}
