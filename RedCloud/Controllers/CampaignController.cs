using Microsoft.AspNetCore.Mvc;
using RedCloud.Interfaces;
using RedCloud.Services;
using RedCloud.ViewModel;

namespace RedCloud.Controllers
{
    public class CampaignController : Controller
    {
        private readonly ICampaignService _campaignService;
        private readonly ILogger<CampaignController> _logger;

        public CampaignController(ICampaignService campaignService, ILogger<CampaignController> logger)
        {
            _campaignService = campaignService;
            _logger = logger;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCampaign(CampaignVM model)
        {

            var userId = HttpContext.Session.GetInt32("UserId");
            // _logger.LogInformation("CreateCampaign Action initiated");
            model.userID = userId;
            var response = await _campaignService.CreateCampaign(model);

            //_logger.LogInformation("CreateCampaign Action completed");
            return RedirectToAction("Index");

        }


        public async Task<IActionResult> ViewCampaignById(int id) 
        {

            //_logger.LogInformation($"Fetching ViewCampaignById with ID: {id}");
            var response = await _campaignService.GetCampaign(id);
            if (response == null)
            {
                //_logger.LogWarning($"ViewCampaignById with ID: {id} not found");
                return NotFound();
            }
            return View(response);
        } 
        
        
        

        
    }
}
