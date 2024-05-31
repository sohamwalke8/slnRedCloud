using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.Account.Queries.LoginQuery;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IMediator mediator, ILogger<AccountController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost("Login")]
        public async Task<ActionResult> GetLogin([FromBody] LoginQuery loginQuery)
        {
            var user = await _mediator.Send(loginQuery);
            return Ok(user);
        }
    }
}
