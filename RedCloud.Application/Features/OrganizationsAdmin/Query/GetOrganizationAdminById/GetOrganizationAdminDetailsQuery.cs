using MediatR;
using RedCloud.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.OrganizationsAdmin.Query.GetOrganizationAdminById
{
    public class GetOrganizationAdminDetailsQuery : IRequest<Response<OrganizationAdminDetailsVM>>
    {
        public int Id { get; set; }

        public GetOrganizationAdminDetailsQuery(int id)
        {
            Id = id;
        }

    }
}
