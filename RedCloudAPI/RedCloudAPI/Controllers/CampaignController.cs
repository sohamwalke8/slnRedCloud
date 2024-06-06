using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.Campaign;
using RedCloud.Application.Features.Carrierss.Queries;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ILogger<CampaignController> _logger;
        public CampaignController(IMediator mediator, ILogger<CampaignController> logger)
        {
            _logger = logger;
            _mediator = mediator;

        }

        [HttpGet("all", Name = "Getallcampaign")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Getallcampaign()
        {
            _logger.LogInformation("Getallcampaign Initiated");
            var dtos = await _mediator.Send(new GetallCampaignCommand());
            return Ok(dtos);
        }
    }
}
