using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.OrganizationsAdmin.Query;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
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
    public class GetAllOrganizationAdminQueryHandler : IRequestHandler<GetAllOrganizationAdminQuery, BaseResponse<IEnumerable<AllOrganizationAdminVM>>>
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



        public async Task<BaseResponse<IEnumerable<AllOrganizationAdminVM>>> Handle(GetAllOrganizationAdminQuery request, CancellationToken cancellationToken)
        {

            var OrganizatinAdmin = (await _asyncRepository.ListAllAsync()).Where(x => x.IsActive == true);

            //var resellers = AllOrganizatinAdmin.ResellerAdmins;                  // List of ResellerAdmin associated with the OrganizationAdmin

            var AllOrganizatinAdminData = _mapper.Map<IEnumerable<AllOrganizationAdminVM>>(OrganizatinAdmin);

            return new BaseResponse<List<AllOrganizationAdminVM>>(AllOrganizatinAdminData, "success");

        }
    }
}
