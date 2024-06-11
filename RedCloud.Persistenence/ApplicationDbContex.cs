using Microsoft.EntityFrameworkCore;
using RedCloud.Application.Contract;
using RedCloud.Domain.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;

namespace RedCloud.Persistenence
{
    [ExcludeFromCodeCoverage]
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }


        //OnModelCreating() method is used to configure the model using ModelBuilder Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
        }

        //public DbSet<Role> Role { get; set; }

        public DbSet<RoleMapper> RoleMapper { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<RedCloudAdmin> RedCloudAdmins { get; set; }

        public DbSet<ResellerAdminUser> ResellerAdminUsers { get; set; }
        public DbSet<Country> Countries { get; set; }   

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<OrganizationAdmin> OrganizationAdmins { get; set; }

        public DbSet<Campaign> Campaigns { get; set; }

        public DbSet<OrganizationUser> OrganizationUsers { get; set; }
        public DbSet<ResellerUser> ResellerUsers { get; set; }






        
    }
}