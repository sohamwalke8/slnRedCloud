using MediatR;
using MvcApiCallingService.Responses;
using RedCloud.Application.Responses;
using RedCloud.Domain.Comman;
using RedCloud.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.Account.Query.Login
{
    public class LoginQuery : IRequest<Response<UserVM>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
