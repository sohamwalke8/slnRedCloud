using Microsoft.EntityFrameworkCore;
using RedCloud.Application.Contract;
using RedCloud.Domain.Entities;

using System.Data;

namespace RedCloud.Persistenence
{
    public class ApplicationDbContext: DbContext
    {
        //public ApplicationDbContex(DbContextOptions options) : base(options)
        //{
        //}

        // public DbSet<ResellerAdmin1> ReSellerAdmins { get; set; }

        // public DbSet<OrganizationAdmin1> OrganizationAdmins { get; set; }

        // public DbSet<User> User { get; set; }



        //private readonly ILoggedInUserService _loggedInUserService;
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ILoggedInUserService loggedInUserService)
        //    : base(options)
        //{
        //    _loggedInUserService = loggedInUserService;
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<ResellerAdmin> ReSellerAdmins { get; set; }

        public DbSet<OrganizationAdmin> OrganizationAdmins { get; set; }

        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}
