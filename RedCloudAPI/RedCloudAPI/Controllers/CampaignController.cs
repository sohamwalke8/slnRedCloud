using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.Campaigns;
using RedCloud.Application.Features.Campaigns.Queries;
using RedCloud.Application.Features.RedCloudAdmins.Queries;
using RedCloud.Application.Features.ResellerAdminuser.Commands;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {


        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        public CampaignController(IMediator mediator, ILogger<RedCloudAdminController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }







        [HttpGet("all")]
        public async Task<ActionResult> GetAllCampaign()
        {
            try
            {
                var response = await _mediator.Send(new GetAllCampaignQueries());
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching admin user by Id");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }


        }

        [HttpDelete("{id}", Name = "DeleteCampaigns")]
        public async Task<ActionResult> DeleteCampain(int id)
        {
            _logger.LogInformation("DeleteResellerAdmin Initiated");
            var campaign = new DeleteCampaignByIdCommand() { CampaignId = id };
            await _mediator.Send(campaign);

            return Ok("Campaign Deleted SuccessFully");
        }

    }
}
