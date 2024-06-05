using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.Rates.Queries;
using RedCloud.Application.Responses;
using RedCloud.Domain.Entities;

namespace RedCloudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetRate>>> GetAllRates()
        {
            try
            {
                var response = await _mediator.Send(new GetAllRatesQuery());
                return Ok(response);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetRate>> GetById(int id)
        {
            try
            {
                var response = await _mediator.Send(new GetRateByIdQuery { Id = id });
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDeleteRate(int id)
        {
            try
            {
                var response = await _mediator.Send(new SoftDeleteRateQuery { Id = id });
                if (response != null)
                {
                    return Ok("Delete SuccessFully");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Internal server error");
            }

        }



    }
    }





