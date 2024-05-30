using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.CountryFolder.Query.GetCountryList;
using RedCloud.Application.Features.ReSellerAdmin.Command.DeleteReSellerAdmin;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetResellerAdminWithEvent;
using RedCloud.Application.Features.ResellerAdmins.Command;
using RedCloud.Application.Features.ResellerAdmins.Queries;

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


        [HttpGet]
        //[HttpGet("{id}", Name = "GetResellerAdminById")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetResellerAdminById(int id)
        {
            //_logger.LogInformation($"GetResellerAdminById Initiated for ID: {id}");
            var dto = await _mediator.Send(new GetReSellerAdminByIdQuery(id));
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }


        [HttpPost(Name = "AddResellerAdmin")]
        public async Task<ActionResult> Create([FromBody] CreateResellerAdminCommand CreateResellerAdminCommand)
        {
            var response = await _mediator.Send(CreateResellerAdminCommand);
            return Ok(response);
        }

        [HttpPut("UpdateResellerAdmin")]
        public async Task<ActionResult> Update([FromBody] UpdateResellerAdminCommand updateResellerAdmin)
        {
            var response = await _mediator.Send(updateResellerAdmin);
            return Ok(response);
        }

        [HttpGet("{id}")]
        
        public async Task<ActionResult> FetchResellerAdminUserById(int id)//changes the code
        {

            //_logger.LogInformation($"GetResellerAdminById Initiated for ID: {id}");
            var dto = await _mediator.Send(new ReselleAdminGetById(id));
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }
    }
}
