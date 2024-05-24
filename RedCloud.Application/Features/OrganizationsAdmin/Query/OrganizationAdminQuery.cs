using MediatR;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetResellerAdminWithEvent;
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
    public class OrganizationAdminQuery : IRequest<OrganizationAdminVM>
    {

        public int Id { get; set; }

        public OrganizationAdminQuery(int id)
        {
            Id = id;
        }
    }
}
