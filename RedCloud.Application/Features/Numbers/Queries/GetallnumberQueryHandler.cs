using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.Numbers.Queries
{
    public class GetallnumberQueryHandler:IRequestHandler<GetallNumberQuery, Response<IEnumerable<ViewAssignedNumberVM>>>
    {
    private readonly ILogger<GetallnumberQueryHandler> _logger;
    private readonly IAsyncRepository<Number> _asyncRepository;
    private readonly IMapper _mapper;


    public GetallnumberQueryHandler(IMapper mapper, ILogger<GetallnumberQueryHandler> logger, IAsyncRepository<Number> asyncRepository)
    {
        _asyncRepository = asyncRepository;
        _mapper = mapper;
        _logger = logger;
    }

    

        public async Task<Response<IEnumerable<ViewAssignedNumberVM>>> Handle(GetallNumberQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handle Initiated");
            var allnumbers = (await _asyncRepository.ListAllAsync());
            var numbers=_mapper.Map<IEnumerable<ViewAssignedNumberVM>>(allnumbers);
            _logger.LogInformation("Handle Completed");
            return new Response<IEnumerable<ViewAssignedNumberVM>>(numbers, "success");
        }


       


    }
   
}
