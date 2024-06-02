using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.OrganizationsAdmin.Command;
using RedCloud.Application.Features.OrganizationsAdmin.Command.BlockOrganizationAdmin;
using RedCloud.Application.Features.OrganizationsAdmin.Command.DeleteOrganizationAdmin;
using RedCloud.Application.Features.OrganizationsAdmin.Query;
using RedCloud.Application.Features.OrganizationsAdmin.Query.GetOrganizationAdminById;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationAdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<OrganizationAdminController> _logger;


        public OrganizationAdminController(IMediator mediator, ILogger<OrganizationAdminController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }


        [HttpGet("all", Name = "GetAllOrganizationAdminList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllOrganizationAdminList()
        {
            //_logger.LogInformation("GetAllOrganizationAdminList Initiated");
            var data = await _mediator.Send(new GetAllOrganizationAdminQuery());
            return Ok(data);
        }


        [HttpGet("{id}", Name = "GetOrganizationAdminDetailsById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetOrganizationAdminDetailsById(int id)
        {
            //_logger.LogInformation("GetOrgaAdminById initiated");
            var result = await _mediator.Send(new GetOrganizationAdminDetailsQuery(id));
            if (result.Data == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }



        [HttpDelete("{id}",Name = "DeleteOrganizationAdmin")]
        public async Task<ActionResult> DeleteOrganizationAdmin(int id)
        {
           // _logger.LogInformation("DeleteOrganizationAdmin Initiated");
            var deletereselleradmin = new DeleteOrganizationAdminCommand() { Id = id };
            await _mediator.Send(deletereselleradmin);

            return Ok("ReSeller Admin Deleted SuccessFully");
        }


        [HttpPut("{id}", Name = "BlockOrganizationAdmin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> BlockOrganizationAdmin(int id)
        {
            //_logger.LogInformation("BlockReSeller Initiated");
            var blockeselleradmin = new BlockOrganizationAdminCommand() { Id = id };
            await _mediator.Send(blockeselleradmin);

            return Ok("ReSeller Admin Blocked SuccessFully");
        }




    }
}
