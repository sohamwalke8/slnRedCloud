using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.AdminUsers.Command;
using RedCloud.Application.Features.AdminUsers.Queries;

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
        [HttpGet("{id}")]
        public async Task<ActionResult> FetchAdminUserById(int id)//changes the code
        {
            //_logger.LogInformation($"GetResellerAdminById Initiated for ID: {id}");
            var dto = await _mediator.Send(new AdminUserGetById(id));
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

    }
}
