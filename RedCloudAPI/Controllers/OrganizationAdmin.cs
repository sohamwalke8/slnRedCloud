using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.OrganizationsAdmin.Command;
using RedCloud.Application.Features.OrganizationsAdmin.Query;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetResellerAdminWithEvent;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationAdmin : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrganizationAdmin(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpPost("AddOrganizationAdmin")]
        public async Task<ActionResult> Create([FromBody] CreateOrganizationAdmin createOrganizationAdmin)
        {
            var response = await _mediator.Send(createOrganizationAdmin);
            return Ok(response);
        }


        [HttpPut("UpdateOrganizationAdmin")]
        public async Task<ActionResult> Update([FromBody] UpdateOrganizationAdmin updateOrganizationAdmin)
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
        [HttpGet("")]
        public async Task<ActionResult> GetAllOrganizationAdmin()
        {


            return Ok();
        }





    }
}
