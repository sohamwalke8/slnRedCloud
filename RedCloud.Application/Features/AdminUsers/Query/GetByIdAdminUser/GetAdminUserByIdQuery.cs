using MediatR;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.AdminUsers.Query.GetByIdAdminUser
{
    public class GetAdminUserByIdQuery : IRequest<BaseResponse<AdminUser>>
    {
        public int ID { get; set; }
    }
}
