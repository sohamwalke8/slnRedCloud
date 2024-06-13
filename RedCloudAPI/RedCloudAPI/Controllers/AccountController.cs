using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RedCloud.Application.Features.Account.Commands;
using RedCloud.Application.Features.Account.Queries;
using RedCloud.Application.Features.Account.Queries.LoginQuery;
using RedCloud.Application.Features.OrganizationAdmins.Commands;
using RedCloud.Domain.Entities;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AccountController> _logger; //Add by Aditya

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

        //Add by Aditya Start

        [HttpGet("CheckUserExistByEmail/{email}")]
        public async Task<ActionResult<User>> CheckUserExistByEmail(string email)
        {
            try
            {
                var response = await _mediator.Send(new UserExistByEmailQuery { Email = email });
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes

                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("ResetUserPassword")]
        public async Task<ActionResult> ResetUserPassword(ResetAdminPasswordCommand model)
        {
            var response = await _mediator.Send(model);
            return Ok(response);
        }
        //Add by Aditya End

        public async Task<ActionResult> ResellerAdminLogin(LoginForResellerQuery loginQuery)
        {
            var response = "value ";
            return Ok(response);
        }

    }
}
