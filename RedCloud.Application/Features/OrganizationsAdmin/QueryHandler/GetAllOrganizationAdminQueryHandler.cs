using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.OrganizationsAdmin.Query;
//using RedCloud.Application.Features.OrganizationsAdmin.Query.GetAllOrganizationAdminQuery;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using RedCloud.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.OrganizationsAdmin.QueryHandler
{
    public class GetAllOrganizationAdminQueryHandler : IRequestHandler<GetAllOrganizationAdminQuery, Response<IEnumerable<AllOrganizationAdminVM>>>
    {

        private readonly ILogger<GetAllOrganizationAdminQueryHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<OrganizationAdmin> _asyncRepository;

        public GetAllOrganizationAdminQueryHandler(ILogger<GetAllOrganizationAdminQueryHandler> logger, IAsyncRepository<OrganizationAdmin> asyncRepository, IMapper mapper)
        {
            _logger = logger;
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }



        public async Task<Response<IEnumerable<AllOrganizationAdminVM>>> Handle(GetAllOrganizationAdminQuery request, CancellationToken cancellationToken)
        {
            //  _logger.LogInformation("Handle Initiated");
            //for include All Data(State,)
            //var OrganizatinAdmins = (await _asyncRepository.GetAllAsync("State,City")).Where(x => x.IsDeleted == false);
            var OrganizatinAdmins = (await _asyncRepository.ListAllAsync()).Where(x => x.IsDeleted == false);

            var model = OrganizatinAdmins.Select(x => new AllOrganizationAdminVM()
            {
                OrgID = x.OrgID,
                OrgName = x.OrgName,
                EIN = x.EIN,
                OrgAdminEmail = x.OrgAdminEmail,
                IsActive = x.IsActive,
            });
            return new Response<IEnumerable<AllOrganizationAdminVM>>(model, "success");
        }
    }
}
