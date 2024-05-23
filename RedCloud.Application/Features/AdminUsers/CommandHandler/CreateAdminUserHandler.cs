using AutoMapper;
using Azure;
using MediatR;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.AdminUsers.Command;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.AdminUsers.CommandHandler
{
    public class CreateAdminUserHandler : IRequestHandler<CreateAdminUserCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<AdminUser> _repository;
        private readonly IMapper _mapper;

        public CreateAdminUserHandler(IAsyncRepository<AdminUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        
        public async Task<BaseResponse<int>> Handle(CreateAdminUserCommand request, CancellationToken cancellationToken)
        {
            var adminuser = _mapper.Map<AdminUser>(request);
            var result = await _repository.AddAsync(adminuser);
            var response = new BaseResponse<int>(result.ID, "Inserted successfully");
            return response;
        }

       
    }
    }
