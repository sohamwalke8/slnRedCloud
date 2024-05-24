using Microsoft.AspNetCore.Mvc;
using RedCloud.Interface;
using RedCloud.Service;

namespace RedCloud.Controllers
{
    
    public class ReSellerAdminController : Controller
    {
        private readonly IReSellerAdminService _reSellerAdminService;
        private readonly ILogger<ReSellerAdminController> _logger;
      

        public ReSellerAdminController(IReSellerAdminService reSellerAdminService, ILogger<ReSellerAdminController> logger )
        {
            _reSellerAdminService = reSellerAdminService;
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            return View();
        }

      

        [HttpGet]
        public async Task<IActionResult> ViewResellerAdmin()
        {
            //_logger.LogInformation("ViewResellerAdmin Action initiated");
            var response = await _reSellerAdminService.GetallResellerAdmin();
            //_logger.LogInformation("ViewResellerAdmin Action completed");
            return View(response);
        }





        [HttpGet]
        public async Task<IActionResult> SoftDeleteResellerAdmin(int id)
        {
            try
            {
                await _reSellerAdminService.SoftDeleteResellerAdmin(id);
                return Ok($"ResellerAdmin with ID {id} has been soft deleted.");
            }
            catch (Exception ex)
            {
               // _logger.LogError($"Error occurred while soft deleting ResellerAdmin with ID {id}: {ex.Message}");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}
