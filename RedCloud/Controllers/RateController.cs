using Microsoft.AspNetCore.Mvc;
using RedCloud.Domain.Entities;
using RedCloud.Interfaces;

namespace RedCloud.Controllers
{
    public class RateController : Controller
    {
        private readonly ILogger<RateController> _logger;
        private readonly IRate _rate;

        public RateController(ILogger<RateController> logger, IRate rate)
        {
            _rate = rate;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> ViewallRates()
        {

            var response = await _rate.GetallRate();

            return View(response);
        }

        public async Task<IActionResult> GetRateByID(int id)
        
         {
            _logger.LogInformation($"Fetching Rate with ID: {id}");
            var response = await _rate.GetRateId(id);
  

            if (response == null)
            {
                _logger.LogWarning($"Rate with ID: {id} not found");
                return NotFound();
            }

            return View(response);
        }

        
        public async Task<IActionResult> DeleteRate(int id)
        {
            _logger.LogInformation($"Fetching Rate with ID: {id}");
            var response = await _rate.SoftDeleteById(id);


            if (response == null)
            {
                _logger.LogWarning($"Rate with ID: {id} not found");
                return NotFound();
            }

            return RedirectToAction("ViewallRates");
        }
    }



}