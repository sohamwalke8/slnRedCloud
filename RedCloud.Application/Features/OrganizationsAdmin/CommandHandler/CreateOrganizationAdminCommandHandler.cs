using AutoMapper;
using MediatR;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.OrganizationsAdmin.Command;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.OrganizationsAdmin.CommandHandler
{
    public class CreateOrganizationAdminCommandHandler : IRequestHandler<CreateOrganizationAdmin, Response<int>>
    {
        private readonly IAsyncRepository<OrganizationAdmin> _asyncRepository;
        private readonly IMapper _mapper;

        

        public CreateOrganizationAdminCommandHandler(IAsyncRepository<OrganizationAdmin> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }

        private string GenerateRandomPassword()
        {
            const int passwordLength = 12;
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";

            var random = new Random();
            return new string(Enumerable.Repeat(allowedChars, passwordLength)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public async Task<Response<int>> Handle(CreateOrganizationAdmin request, CancellationToken cancellationToken)
        {
            request.OrgAdminPassword = GenerateRandomPassword();
            var org = _mapper.Map<OrganizationAdmin>(request);
           var result = await _asyncRepository.AddAsync(org);
            var response = new Response<int>(result.OrgID, "Inserted successfully ");
            return response;
        }
    }
}
