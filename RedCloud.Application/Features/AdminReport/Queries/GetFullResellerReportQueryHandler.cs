﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.AdminReport.Queries
{
    public class GetFullResellerReportQueryHandler: IRequestHandler<GetFullResellerReportQuery, Response<IEnumerable<ResellerReportVM>>>
    {
        private readonly IAsyncRepository<AdminInboundMessageReport> _reportRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetFullResellerReportQueryHandler> _logger;

    public GetFullResellerReportQueryHandler(IAsyncRepository<AdminInboundMessageReport> reportRepository, IMapper mapper, ILogger<GetFullResellerReportQueryHandler> logger)
    {
        _reportRepository = reportRepository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<Response<IEnumerable<ResellerReportVM>>> Handle(GetFullResellerReportQuery request, CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Fetching Reseller report data");


            var reportData = await _reportRepository.StoredProcedureQueryAsync("GetFullResellersDetailsWithStatus");


            var mappedData = _mapper.Map<IEnumerable<ResellerReportVM>>(reportData);

            return new Response<IEnumerable<ResellerReportVM>>(mappedData, "Fetched successfully");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching Reseller report data");
            return new Response<IEnumerable<ResellerReportVM>>(null, "An error occurred");
        }
    }
}
}



   

    