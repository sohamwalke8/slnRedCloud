﻿using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Helper;
using RedCloud.Domain.Comman;
using RedCloud.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace RedCloud.Persistenence.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ILogger _logger;
        private readonly ApplicationDbContex _dbContex;

        public AccountRepository(ApplicationDbContex dbContex, ILogger<User> logger)
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
