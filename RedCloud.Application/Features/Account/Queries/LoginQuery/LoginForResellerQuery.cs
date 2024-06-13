using MediatR;
using RedCloud.Application.Responses;
using RedCloud.Domain.Common;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.Account.Queries.LoginQuery
{
    public class LoginQueryForReseller: IRequest<Response<ResellerAdminUser>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
