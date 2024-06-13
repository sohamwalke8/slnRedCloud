using RedCloud.Domain.Common;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Contracts.Persistence
{
    public interface IAccountRepository
    {
        Task<UserVM> Get(string Email, string Password);
        Task<ResellerAdminUser> Get(string Email, string Password);

        Task
    }
}
