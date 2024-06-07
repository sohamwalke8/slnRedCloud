using AutoMapper;
using MediatR;
using Microsoft.Data.SqlClient;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.RedCloudAdmins.Commands.CreateRedCloudAdmin;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.Rates.Commands
{
   

    public class CreateRateCommandHandler : IRequestHandler<CreateRateCommand, Response<int>>
    {
        private readonly IAsyncRepository<Rate> _repository;
        private readonly IMapper _mapper;

        public CreateRateCommandHandler(IAsyncRepository<Rate> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateRateCommand request, CancellationToken cancellationToken)
        {

            var parameters = new[]
            {
                new SqlParameter("@ResellerAdminUserId", request.ResellerAdminUserId),
                new SqlParameter("@Type", request.Type),
                new SqlParameter("@InboundSMS", request.InboundSMS),
                new SqlParameter("@OutboundSMS", request.OutboundSMS),
                new SqlParameter("@InboundMMS", request.InboundMMS),
                new SqlParameter("@OutboundMMS", request.OutboundMMS),
                new SqlParameter("@MonthlyNumber", request.MonthlyNumber),
                new SqlParameter("@Users", request.Users)
            };

            var result = await _repository.StoredProcedureCommandAsync("usp_InsertRate", parameters);

            
            var response = new Response<int>(result);
            
            return response;

        }
    }
}