﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.CountryFolder.Query.GetCountryList;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin
{
    public class GetResellerAdminQueryListHandler : IRequestHandler<GetReSellerAdminListQuery, Response<IEnumerable<ReSellerAdminVM>>>
    {
           private readonly ILogger<GetResellerAdminQueryListHandler> _logger;
           private readonly IAsyncRepository<ResellerAdmin> _asyncRepository;
           private readonly IMapper _mapper;
     
        
        public GetResellerAdminQueryListHandler(IMapper mapper, ILogger<GetResellerAdminQueryListHandler> logger, IAsyncRepository<ResellerAdmin> asyncRepository)
        {
        _asyncRepository = asyncRepository;
        _mapper = mapper;
         _logger = logger;
        }

      
        public async Task<Response<IEnumerable<ReSellerAdminVM>>> Handle(GetReSellerAdminListQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handle Initiated");
            var allReSellerAdmin = (await _asyncRepository.ListAllAsync()).Where(x => x.IsDeleted==false);
            var resellerAdmin = _mapper.Map<IEnumerable<ReSellerAdminVM>>(allReSellerAdmin);
            _logger.LogInformation("Hanlde Completed");
            return new Response<IEnumerable<ReSellerAdminVM>>(resellerAdmin, "success");
        }
    }
    }



