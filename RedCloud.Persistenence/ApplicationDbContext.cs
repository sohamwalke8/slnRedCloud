using Microsoft.EntityFrameworkCore;
using RedCloud.Application.Contract;
using RedCloud.Domain.Entities;
using System.Diagnostics.CodeAnalysis;

namespace RedCloud.Persistenence
{
    [ExcludeFromCodeCoverage]
    public class ApplicationDbContext : DbContext
    {
        //private readonly ILoggedInUserService _loggedInUserService;
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ILoggedInUserService loggedInUserService)
        //    : base(options)
        //{
        //    _loggedInUserService = loggedInUserService;
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<OrganizationAdmin> OrganizationAdmins { get; set; }

        public DbSet<ResellerAdmin> ResellerAdmins { get; set; }
    }
}
