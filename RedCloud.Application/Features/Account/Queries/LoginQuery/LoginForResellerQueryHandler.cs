using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contracts.Persistence;
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
    public class LoginForResellerQueryHandler : IRequestHandler<LoginForResellerQuery, Response<ResellerAdminUser>>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<LoginQueryHandler> _logger;


        public Task<Response<ResellerAdminUser>> Handle(LoginForResellerQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
