using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Controllers
{
    public class OrganizationUserController : Controller
    {
        private readonly IOrganizationUserService _organizationUserService;
        private readonly IOrganizationAdminService _organizationAdminService;
        private readonly ILogger<OrganizationUserController> _logger;
      


        public OrganizationUserController(IOrganizationUserService organizationUserService, ILogger<OrganizationUserController> logger)
        {
            _organizationUserService = organizationUserService;
            _logger = logger;
            
        }

        // AAKASh

        [HttpGet]
        public async Task<IActionResult> ViewOrganizationUsers()
        {
            //_logger.LogInformation("ViewOrganizationAdmin Action initiated");
            var model = await _organizationUserService.GetAllOrganizationUser();
            //_logger.LogInformation("ViewOrganizationAdmin Action completed");
            return View(model);
        }


        public async Task<IActionResult> ViewOrganizationUserDetails(int id)
        {

            //_logger.LogInformation($"Fetching ViewOrganizationDetails with ID: {id}");
            var response = await _organizationUserService.GetOrganizationUserDetailesById(id);
            if (response == null)
            {
                _logger.LogWarning($"ViewOrganizationDetails with ID: {id} not found");
                return NotFound();
            }

            return View(response);
        }



        [HttpPut]
        public async Task<IActionResult> Block(int id)
        {
            try
            {
                var response = await _organizationUserService.BlockOrganizationUser(id);
                return View(response);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while blocking the OrganizationAdmin." });
            }
        }


        // ---------------------------------------------------------------------------------

        public async Task<IActionResult> AddOrganizationUser()
        {
            //ViewBag.ResellerList = (await _reSellerAdminService.GetallResellerAdmin()).Select(r => r.ResellerName).ToList();
            //return View(); 
    
            return View(new OrganizationUserVM());
        }

        [HttpPost]
        public async Task<IActionResult> AddOrganizationUser(OrganizationUserVM request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");


            var response = await _organizationUserService.CreateOrganizationUser(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("ViewOrganizationUsers");

            
        }

        public async Task<IActionResult> UpdateOrganizationUser(int Id)
        {


            var response = await _organizationUserService.GetOrganizationUserDetailesById(Id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrganizationUser(OrganizationUserVM request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response = _organizationUserService.EditOrganizationUser(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("ViewOrganizationUsers");
        }


    }
}
