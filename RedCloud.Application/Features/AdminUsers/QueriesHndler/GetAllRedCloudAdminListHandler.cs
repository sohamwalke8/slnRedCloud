using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.AdminUsers.Queries;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
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
    public class GetAllRedCloudAdminListHandler:IRequestHandler<GetAllRedCloudAdminList, Response<IEnumerable<RedCloudUserVM>>>
    {
        private readonly ILogger<GetAllRedCloudAdminListHandler> _logger;
        private readonly IAsyncRepository<AdminUser> _asyncRepository;
        private readonly IMapper _mapper;


        public GetAllRedCloudAdminListHandler(IMapper mapper, ILogger<GetAllRedCloudAdminListHandler> logger, IAsyncRepository<AdminUser> asyncRepository)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async  Task<Response<IEnumerable<RedCloudUserVM>>> Handle(GetAllRedCloudAdminList request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handle Initiated");
            var allReSellerAdmin = (await _asyncRepository.ListAllAsync()).Where(x => x.IsDeleted == false);
            var resellerAdmin = _mapper.Map<IEnumerable<RedCloudUserVM>>(allReSellerAdmin);
            _logger.LogInformation("Hanlde Completed");
            return new Response<IEnumerable<RedCloudUserVM>>(resellerAdmin, "success");
        }
    }
}
