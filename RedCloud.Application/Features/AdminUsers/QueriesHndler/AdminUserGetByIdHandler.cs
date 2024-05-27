using AutoMapper;
using MediatR;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.AdminUsers.Queries;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using RedCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.AdminUsers.QueriesHndler
{
    public class AdminUserGetByIdHandler : IRequestHandler<AdminUserGetById, RedCloudUserVM>
    {
        private readonly IAsyncRepository<AdminUser> _asyncRepository;
        private readonly IMapper _mapper;


        public AdminUserGetByIdHandler(IAsyncRepository<AdminUser> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }

        public  async Task<RedCloudUserVM> Handle(AdminUserGetById request, CancellationToken cancellationToken)
        {
            
            var admin = await _asyncRepository.GetByIdAsync(request.Id);

            if (admin == null)
            {
                return null;
            }

            var dto = new RedCloudUserVM()
            {
                ID = admin.ID,
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                Email = admin.Email,
                MobileNumber = admin.MobileNumber,
               

            };

            return dto;
        }
    }
}
