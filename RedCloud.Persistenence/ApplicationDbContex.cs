using Microsoft.EntityFrameworkCore;
using RedCloud.Domain.Entities;
using RedCloud.Models.Account;

namespace RedCloud.Persistenence
{
    public class ApplicationDbContex : DbContext
    {

        public ApplicationDbContex(DbContextOptions options) : base(options)
        {

        }


                                                    //OnModelCreating() method is used to configure the model using ModelBuilder Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
        }

        public DbSet<Role> Role { get; set; }

        public DbSet<RoleMapper> RoleMapper { get; set; }

        public DbSet<User> User { get; set; }




    }
}
