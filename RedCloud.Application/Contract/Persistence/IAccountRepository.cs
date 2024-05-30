using RedCloud.Domain.Comman;
using RedCloud.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Contract.Persistence
{
    public interface IAccountRepository
    {
        Task<UserVM> Get(string Email, string Password);
    }
}
