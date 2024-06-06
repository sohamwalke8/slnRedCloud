﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.Numbers.Commands;
using RedCloud.Application.Features.Numbers.Queries;
using RedCloud.Application.Features.OrganizationAdmins.Commands;
using RedCloud.Application.Features.ResellerAdminuser.Queries;

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


        [HttpPost("AssignNumber")]
        public async Task<ActionResult> AssignNumber([FromBody] AssignNumberCommand assignNumber)
        {
            var response = await _mediator.Send(assignNumber);
            return Ok(response);
        }




        [HttpGet("{id}")]

        public async Task<ActionResult> GetNumberById(int id)//changes the code
        {

            //_logger.LogInformation($"GetResellerAdminById Initiated for ID: {id}");
            var dto = await _mediator.Send(new AssignNumberQuery() { NumberId = id });
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpPut]

        public async Task<ActionResult> GetNumberById(int id,AssignNumberCommand command )//changes the code
        {

           
            //var dto = await _mediator.Send(new AssignNumberQuery() { NumberId = id });
            //if (dto == null)
            //{
            //    return NotFound();
            //}
            var response = await _mediator.Send(command);

            return Ok(response);
        }
        

    }
}
