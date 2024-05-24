using Microsoft.EntityFrameworkCore;
using RedCloud.Domain.Entities;

namespace RedCloud.Persistenence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        
         public DbSet<ResellerAdmin> ReSellerAdmin { get; set; }
        public DbSet<OrganizationAdmin> OrganizationAdmin { get; set; }


        //private static DbContextOptions GetOptions(string connectionString)
        //{
        //    return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        //}

    }
}
