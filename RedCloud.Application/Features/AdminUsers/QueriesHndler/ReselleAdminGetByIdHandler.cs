using AutoMapper;
using MediatR;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.AdminUsers.Queries;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using RedCloud.Models;
using RedCloud.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.AdminUsers.QueriesHndler
{

    public class ReselleAdminGetByIdHandler : IRequestHandler<ReselleAdminGetById, BaseResponse<ResellerAdminVM>>
    {
        private readonly IAsyncRepository<ResellerAdmin> _asyncRepository;
        private readonly IMapper _mapper;


        public ReselleAdminGetByIdHandler(IAsyncRepository<ResellerAdmin> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ResellerAdminVM>> Handle(ReselleAdminGetById request, CancellationToken cancellationToken)
        {

            var admin = await _asyncRepository.GetByIdAsync(request.Id);

            if (admin == null)
            {
                return null;
            }

            var dto = new ResellerAdminVM()
            {
                Id = admin.Id,
                ResellerName = admin.ResellerName,
                EIN = admin.EIN,
                AddressLine1 = admin.AddressLine1,
                AddressLine2 = admin.AddressLine2,

                City = admin.City,
                State = admin.State,
                ZipCode = admin.ZipCode,
                CompanyURL = admin.CompanyURL,
                CompanySupportEmail = admin.CompanySupportEmail,
                RedCloudAdmin = admin.RedCloudAdmin,
                Password = admin.Password

            };

               return new BaseResponse<ResellerAdminVM>(dto, "Successful"); ;


        }
    }
}