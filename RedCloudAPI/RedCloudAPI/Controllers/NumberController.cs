using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.Numbers.Commands;
using RedCloud.Application.Features.OrganizationAdmins.Commands;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NumberController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpPost("AddNumber")]
        public async Task<ActionResult> Create([FromBody] AddNumberCommand addNumber)
        {
            var response = await _mediator.Send(addNumber);
            return Ok(response);
        }

    }
}
