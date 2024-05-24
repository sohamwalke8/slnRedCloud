//using MediatR;
//using Microsoft.AspNetCore.Mvc;

//namespace RedCloudAPI.Controllers
//{
//    public class CountryController : ControllerBase
//    {
//        private readonly IMediator _mediator;
//        private readonly ILogger<CountryController> _logger;
//        public CountryController(IMediator mediator,ILogger <CountryController> logger)
//        { 
//        _logger = logger;
//         _mediator = mediator;   
        
//        }
//        //public IActionResult Index()
//        //{
//        //    return View();
//        //}


//        [HttpGet ("all",Name ="GetAllCountry")]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult> GetAllCountry()
//        {
//            _logger.LogInformation("GetAllCountries Initiated");
//            var dtos=await _mediator.Send(new GetCountryListQuery());
//             return Ok(dtos);
//        }
//    }
//}
