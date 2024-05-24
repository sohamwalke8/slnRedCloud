using AutoMapper;
using MediatR;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.OrganizationsAdmin.Query;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetResellerAdminWithEvent;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using RedCloud.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.OrganizationsAdmin.QueryHandler
{
    public class OrganizationAdminQueryHandler : IRequestHandler<OrganizationAdminQuery, OrganizationAdminVM>
    {
        private readonly IAsyncRepository<OrganizationAdmin> _asyncRepository;
        private readonly IMapper _mapper;


        public OrganizationAdminQueryHandler(IAsyncRepository<OrganizationAdmin> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }



        public async Task<OrganizationAdminVM> Handle(OrganizationAdminQuery request, CancellationToken cancellationToken)
        {
            var admin = await _asyncRepository.GetByIdAsync(request.Id);

            if (admin == null)
            {
                return null;
            }

            var dto = new OrganizationAdminVM()
            {
                OrgID = admin.OrgID,
                OrgName = admin.OrgName,
                OrgAdminName = admin.OrgAdminName,
                OrgAdminEmail = admin.OrgAdminEmail,
                OrgAdminPassword = admin.OrgAdminPassword,
                City = admin.City,
                State = admin.State,
                ZipCode = admin.ZipCode,
                OrgAdminMobNo = admin.OrgAdminMobNo,
                AddressLineOne = admin.AddressLineOne,
                AddressLineTwo = admin.AddressLineTwo,
                OrgURL = admin.OrgURL,
                

            };

            return dto;
        }
    }
}
