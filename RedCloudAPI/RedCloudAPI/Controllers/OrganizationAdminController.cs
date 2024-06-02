using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.OrganizationAdmins.Commands;
using RedCloud.Application.Features.OrganizationAdmins.Queries;

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

