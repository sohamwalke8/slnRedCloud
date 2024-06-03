using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.OrganizationAdmins.Commands;
using RedCloud.Application.Features.OrganizationAdmins.Queries;
using RedCloud.Application.Features.ResellerAdminuser.Queries;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationAdmin : ControllerBase
    {
        //new

        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public OrganizationAdmin(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }


        //Added by Akash Start
        [HttpGet("all", Name = "GetAllOrganizationAdminList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllOrganizationAdminList()
        {
            _logger.LogInformation("GetAllOrganizationAdminList Initiated");
            var data = await _mediator.Send(new GetAllOrganizationAdminQuery());
            return Ok(data);
        }


        [HttpGet("{id:int}", Name = "GetResellerAdminById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response<OrganizationAdmin>>> Get(int id)
        {
            _logger.LogInformation("GetResellerAdminById initiated");
            var result = await _mediator.Send(new GetReSellerAdminByIdQuery(id));
            if (result.Data == null)
            {
                return NotFound(result);
            }

            return Ok(result);
        }



        [HttpDelete("{id}", Name = "DeleteOrganizationAdmin")]
        public async Task<ActionResult> DeleteOrganizationAdmin(int id)
        {
            _logger.LogInformation("DeleteOrganizationAdmin Initiated");
            var deletereselleradmin = new DeleteOrganizationAdminCommand() { Id = id };
            await _mediator.Send(deletereselleradmin);

            return Ok("ReSeller Admin Deleted SuccessFully");
        }



        [HttpPut("{id}", Name = "BlockReSeller")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> BlockOrganizationAdmin(int id)
        {
            _logger.LogInformation("BlockReSeller Initiated");
            var blockeselleradmin = new BlockOrganizationAdminCommand() { Id = id };
            await _mediator.Send(blockeselleradmin);

            return Ok("ReSeller Admin Blocked SuccessFully");
        }


        //Added by Akash End




        [HttpPost("AddOrganizationAdmin")]
        public async Task<ActionResult> Create([FromBody] CreateOrganizationAdminCommand createOrganizationAdmin)
        {
            var response = await _mediator.Send(createOrganizationAdmin);
            return Ok(response);
        }

        [HttpPut("UpdateOrganizationAdmin")]
        public async Task<ActionResult> Update([FromBody] UpdateOrganizationAdminCommand updateOrganizationAdmin)
        {
            var response = await _mediator.Send(updateOrganizationAdmin);
            return Ok(response);
        }

        [HttpGet("{id}", Name = "GetOrganizationAdminById")]
        public async Task<ActionResult> FetchOrganizationAdminById(int id)
        {
            //_logger.LogInformation($"GetResellerAdminById Initiated for ID: {id}");
            var dto = await _mediator.Send(new OrganizationAdminQuery(id));
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }
    }
}

