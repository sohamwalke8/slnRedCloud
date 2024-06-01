using AutoMapper;
using MediatR;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.RedCloudAdmins.Commands.CreateRedCloudAdmin
{
    public class EditRedCloudAdminCommandHandler : IRequestHandler<EditRedCloudAdminCommand, Response<Unit>>
    {
        private readonly IAsyncRepository<RedCloudAdmin> _repository;
        private readonly IMapper _mapper;
        public EditRedCloudAdminCommandHandler(IAsyncRepository<RedCloudAdmin> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
       
        public async Task<Response<Unit>> Handle(EditRedCloudAdminCommand request, CancellationToken cancellationToken)
        {
            var adminuser = _mapper.Map<RedCloudAdmin>(request);



            adminuser.LastModifiedDate = DateTime.UtcNow;
            adminuser.LastModifiedBy = null;


            await _repository.UpdateAsync(adminuser);
            var response = new Response<Unit>("Updated Successfully");
            return response;
        }
    }
}
