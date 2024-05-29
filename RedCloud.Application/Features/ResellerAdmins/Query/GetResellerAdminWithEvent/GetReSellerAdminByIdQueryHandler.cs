using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetResellerAdminWithEvent
{
    public class GetReSellerAdminByIdQueryHandler : IRequestHandler<GetReSellerAdminByIdQuery, Response<ReSellerAdmindto>>
    {
        private readonly IAsyncRepository<ResellerAdmin> _asyncRepository;
        public GetReSellerAdminByIdQueryHandler(IAsyncRepository<ResellerAdmin> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }
        //public async Task<ReSellerAdmindto> Handle(GetReSellerAdminByIdQuery request, CancellationToken cancellationToken)
        //{
        //    var admin = await _asyncRepository.GetByIdAsync(request.Id);
        //    if (admin == null)
        //    {
        //        return null;
        //    }
        //    var dto = new ReSellerAdmindto()
        //    {
        //        ResellerName = admin.ResellerName,
        //        EIN = admin.EIN,
        //        AddressLine1 = admin.AddressLine1,
        //        AddressLine2 = admin.AddressLine2,
        //        City = admin.City,
        //        State = admin.State,
        //        ZipCode = admin.ZipCode,
        //        CompanyURL = admin.CompanyURL,
        //        CompanySupportEmail = admin.CompanySupportEmail,
        //        RedCloudAdmin = admin.RedCloudAdmin,

        //    };
        //    return dto;
        //}


        public async Task<Response<ReSellerAdmindto>> Handle(GetReSellerAdminByIdQuery request, CancellationToken cancellationToken)
        {
            var admin = await _asyncRepository.FirstOrDefaultAsync(
                x => x.Id == request.Id &&  x.IsDeleted ==false);

            if (admin == null)
            {
                return null;
            }

            var dto = new ReSellerAdmindto()
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
            };

            return new Response<ReSellerAdmindto>(dto, "success");
        }
    }
}

