using MediatR;
using MvcApiCallingService.Models.Responses;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using RedCloud.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.OrganizationsAdmin.Query
{
    public class GetAllOrganizationAdminQuery : IRequest<BaseResponse<List<AllOrganizationAdminVM>>>
    {


    }
}
