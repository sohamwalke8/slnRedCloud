using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.OrganizationsAdmin.Command.BlockOrganizationAdmin
{
    public class BlockOrganizationAdminCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
