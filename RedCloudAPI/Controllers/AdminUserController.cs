using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.AdminUsers.Command;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        public AdminUserController(IMediator mediator, ILogger<AdminUserController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpPost("AddAdminUser")]
        public async Task<ActionResult> Create([FromBody] CreateAdminUserCommand CreateAdminUserCommand)
        {
            try
            {
                var response = await _mediator.Send(CreateAdminUserCommand);
                return Ok(response);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromBody] EditAdminUserCommand EditAdminUserCommand)
        {
            var response = await _mediator.Send(EditAdminUserCommand);
            return Ok(response);
        }

    }
}
