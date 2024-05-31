using RedCloud.Domain.Common;
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
    }
}
