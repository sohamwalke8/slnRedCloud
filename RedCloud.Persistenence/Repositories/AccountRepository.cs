using Microsoft.Extensions.Logging;
using RedCloud.Application.Contracts.Persistence;
using RedCloud.Domain.Common;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Persistenence.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _dbContex;

        public AccountRepository(ApplicationDbContext dbContex, ILogger<User> logger)
        {
            _dbContex = dbContex;
            _logger = logger;
        }


        public async Task<UserVM> Get(string Email, string Password)
        {
            ////----
            //var user = _dbContex.User.Where(x => x.Email == Email && x.Password== Encryptedpass).FirstOrDefault();
            //var userData = _dbContex.User.Where(x =>x.Email == Email).FirstOrDefault();
            //var DecryptedPass = EncryptionDecryption.DecryptString(userData.Password);

            ////-----
            ///

            var user = _dbContex.User.Where(x => x.Email == Email && x.Password == Password).FirstOrDefault();
            //var user = _dbContex.User.Where(x => x.Email == Email && x.Password==Password).FirstOrDefault();
            if (user != null)
            {
                var roles = _dbContex.RoleMapper.Where(x => x.UserId == user.UserId).Select(x => new Role
                {
                    RoleName = x.Role.RoleName,
                    RoleId = x.Role.RoleId,
                }).OrderBy(x => x.RoleId).ToList();

                var loginDetailes = new UserVM
                {
                    UserId = user.UserId,
                    Email = user.Email,
                    Password = user.Password,
                    Roles = roles,
                };

                return loginDetailes;
            }
            throw new UnauthorizedAccessException();

        }
    }
}
