using MediatR;
using RedCloud.Application.Responses;
using RedCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.AdminUsers.Queries
{
    public  class GetAllRedCloudAdminList : IRequest<Response<IEnumerable<RedCloudUserVM>>>//u have to change vm name
    {
      
    }
}
