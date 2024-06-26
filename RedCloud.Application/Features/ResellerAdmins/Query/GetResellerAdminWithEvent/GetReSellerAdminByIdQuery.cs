﻿using MediatR;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetResellerAdminWithEvent;
using RedCloud.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetResellerAdminWithEvent
{
    public class GetReSellerAdminByIdQuery:IRequest<Response<ReSellerAdmindto>>
    {

        public int Id { get; set; }

        public GetReSellerAdminByIdQuery(int id)
        {
            Id = id;
        }
    }
}

