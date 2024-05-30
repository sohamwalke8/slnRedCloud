using MediatR;
using RedCloud.Application.Responses;
using RedCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.ResellerAdmins.Queries
{
    public class ReselleAdminGetById : IRequest<Response<ResellerAdminVM>>
    {

        public int Id { get; set; }

        public ReselleAdminGetById(int id)
        {
            Id = id;
        }

    }
}
