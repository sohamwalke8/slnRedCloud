using MediatR;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.ResellerAdmins.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using RedCloud.Domain.Entities;
using AutoMapper;
using RedCloud.Application.Responses;

namespace RedCloud.Application.Features.ResellerAdmins.CommandHandler
{
    public class CreateResellerAdminCommandHandler : IRequestHandler<CreateResellerAdminCommand, Response<int>>
    {

        private readonly IAsyncRepository<ResellerAdmin> _repository;
        private readonly IMapper _mapper;


        public CreateResellerAdminCommandHandler(IAsyncRepository<ResellerAdmin> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateResellerAdminCommand request, CancellationToken cancellationToken)
            {
            request.Password = GenerateRandomPassword();//create for random passaword generation new adition

            var AdminRese = _mapper.Map<ResellerAdmin>(request);


            //  ResellerName = request.ResellerName,
            AdminRese.IsActive = true;
            AdminRese.CreatedBy = 1;//c.n
            AdminRese.CreatedDate = DateTime.Now;
            AdminRese.IsDeleted = false;



            var result = await _repository.AddAsync(AdminRese);
            //var response = new Response<BlogVM>(_mapper.Map<BlogVM>(blog), "Inserted successfully ");
            var response = new Response<int>(result.Id, "Inserted successfully ");
            return response;

        }

        private string GenerateRandomPassword()
        {
            const int passwordLength = 12;
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";

            var random = new Random();
            return new string(Enumerable.Repeat(allowedChars, passwordLength)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
