using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Helper;
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
        //[HttpGet]
        //public async Task<IActionResult> GetRateByID(string encryptedId)
        //{
        //    try
        //    {
        //        var response = await _rate.GetRateByEncryptedId(encryptedId);

        //        if (response == null)
        //        {
        //            _logger.LogWarning($"Rate with ID: {encryptedId} not found");
        //            return NotFound();
        //        }

        //        return View(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Error fetching rate: {ex.Message}");
        //        return StatusCode(500, "Internal server error");
        //    }
        //}




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