using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
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
    public class LoginQueryHandler : IRequestHandler<LoginQuery, Response<UserVM>>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<LoginQueryHandler> _logger;

        public LoginQueryHandler(IAccountRepository accountRepository, IMapper mapper, ILogger<LoginQueryHandler> logger)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Response<UserVM>> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = (await _accountRepository.Get(request.Email,request.Password));

            if (user == null)
            {
                return new Response<UserVM>("no user found ");
            }
            else
            {
                return new Response<UserVM>(user, "success");
            }
        }
    }
}
