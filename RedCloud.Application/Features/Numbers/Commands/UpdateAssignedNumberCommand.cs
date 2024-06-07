using Azure;
using MediatR;
using RedCloud.Application.Features.Numbers.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.Numbers.Commands
{
    public  class UpdateAssignedNumberCommand:IRequest<Response<ViewAssignedNumberVM>>
    {

    }
}
