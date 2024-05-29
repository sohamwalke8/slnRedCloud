using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.ReSellerAdmin.Command.BlockReSellerAdmin
{
    public class BlockReSellerAdminCommandHandler : IRequestHandler<BlockReSellerAdminCommand, Unit>
    {

        private readonly ILogger<BlockReSellerAdminCommandHandler> _logger;
        private readonly IAsyncRepository<ResellerAdmin> _asyncRepository;
        private readonly IMapper _mapper;


        public BlockReSellerAdminCommandHandler(IMapper mapper, ILogger<BlockReSellerAdminCommandHandler> logger, IAsyncRepository<ResellerAdmin> asyncRepository)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(BlockReSellerAdminCommand request, CancellationToken cancellationToken)
        {
            var id = request.Id;

            var Blockeduser = await _asyncRepository.GetByIdAsync(id);
            if (Blockeduser == null)
            {
                throw new Exception();
            }
            Blockeduser.IsActive = false;

            await _asyncRepository.UpdateAsync(Blockeduser);
            return Unit.Value;
        }
    }
}
