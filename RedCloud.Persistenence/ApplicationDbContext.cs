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
        //public ApplicationDbContex(DbContextOptions options) : base(options)
        //{
        //}

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        // public DbSet<ResellerAdmin1> ReSellerAdmins { get; set; }
        
         public DbSet<ResellerAdmin> ReSellerAdmins { get; set; }
        public DbSet<OrganizationAdmin> OrganizationAdmins { get; set; }
        // public DbSet<OrganizationAdmin1> OrganizationAdmins { get; set; }

        // public DbSet<User> User { get; set; }



        //private static DbContextOptions GetOptions(string connectionString)
        //private readonly ILoggedInUserService _loggedInUserService;
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ILoggedInUserService loggedInUserService)
        //    : base(options)
        //{
        //    return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        //    _loggedInUserService = loggedInUserService;
        //}



     
    }
}
