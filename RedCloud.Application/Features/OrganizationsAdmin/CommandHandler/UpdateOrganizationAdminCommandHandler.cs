using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.OrganizationsAdmin.Command;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.OrganizationsAdmin.CommandHandler
{
    public class UpdateOrganizationAdminCommandHandler : IRequestHandler<UpdateOrganizationAdmin, Response<Unit>>
    {

        private readonly IAsyncRepository<OrganizationAdmin> _repository;
        private readonly IMapper _mapper;


        public UpdateOrganizationAdminCommandHandler(IAsyncRepository<OrganizationAdmin> repository, IMapper mapper)
        {
            _repository = repository;
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

        public async Task<Response<Unit>> Handle(UpdateOrganizationAdmin request, CancellationToken cancellationToken)
        {
            
            var model = await _repository.GetByIdAsync(request.Id);
            request.OrgAdminPassword = model.OrgAdminPassword;
            _mapper.Map(request, model, typeof(UpdateOrganizationAdmin), typeof(OrganizationAdmin));

            model.LastModifiedBy = 1;
            model.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(model);
            var response = new Response<Unit>("Inserted successfully");
            return response;
        }

    }
}
