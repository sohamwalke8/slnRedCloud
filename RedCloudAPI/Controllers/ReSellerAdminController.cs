using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.CountryFolder.Query.GetCountryList;
using RedCloud.Application.Features.ReSellerAdmin.Command.BlockReSellerAdmin;
using RedCloud.Application.Features.ReSellerAdmin.Command.DeleteReSellerAdmin;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetResellerAdminWithEvent;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReSellerAdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        public ReSellerAdminController(IMediator mediator, ILogger<ReSellerAdminController> logger)
        {
            _logger = logger;
            _mediator = mediator;

        }

        [HttpGet("all", Name = "GetAllResellerAdminList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllResellerAdminList()
        {
            _logger.LogInformation("GetAllResellerAdmin Initiated");
            var dtos = await _mediator.Send(new GetReSellerAdminListQuery());
            return Ok(dtos);
        }



        [HttpDelete ("{id}",Name = "DeleteResellerAdmin")]
        public async Task<ActionResult> DeleteResellerAdmin(int id)
        {
            _logger.LogInformation("DeleteResellerAdmin Initiated");
            var deletereselleradmin=new DeleteReSellerAdminCommand() { Id = id };
            await _mediator.Send(deletereselleradmin);
          
          return Ok("ReSeller Admin Deleted SuccessFully");
        }


        [HttpGet("{id}", Name = "GetResellerAdminById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetResellerAdminById(int id)
        {
            _logger.LogInformation($"GetResellerAdminById Initiated for ID: {id}");
            var dto = await _mediator.Send(new GetReSellerAdminByIdQuery(id));
            if (dto == null)
            {
                return NotFound();
            }
            
            return Ok(dto);
        }

        [HttpPut("{id}", Name = "BlockReSeller")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> BlockReSeller(int id)
        {
            _logger.LogInformation("BlockReSeller Initiated");
            var blockeselleradmin = new BlockReSellerAdminCommand() { Id = id };
            await _mediator.Send(blockeselleradmin);

            return Ok("ReSeller Admin Blocked SuccessFully");
        }
    }
}
