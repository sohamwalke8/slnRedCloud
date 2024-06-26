﻿using MediatR;
using RedCloud.Application.Features.ResellerReport.Queries;
using RedCloud.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.ResellerReport.Queries
{
    public class GetTotalOrganizationReportQuery : IRequest<Response<IEnumerable<TotalReportVM>>>
    {
    
    }
}