using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Controllers
{
    public class OrganizationAdminController : Controller
    {
        private readonly IOrganizationAdminService _organizationAdminService;
        private readonly IAdminResellerUser _reSellerAdminService;
        private readonly ILogger<OrganizationAdminController> _logger;
        private readonly IDropDownService<CountryVM> _dropDownService;
        private readonly IStateService<StateVM> _stateService;
        private readonly ICityService<CityVM> _cityService;


        public OrganizationAdminController(IOrganizationAdminService organizationAdminService, ILogger<OrganizationAdminController> logger,
            IAdminResellerUser reSellerAdminService, IDropDownService<CountryVM> dropDownService, IStateService<StateVM> stateService, ICityService<CityVM> cityService)
        {
            _organizationAdminService = organizationAdminService;
            _reSellerAdminService = reSellerAdminService;
            _logger = logger;
            _dropDownService = dropDownService;
            _stateService = stateService;
            _cityService = cityService;
        }

        // AAKASh

        [HttpGet]
        public async Task<IActionResult> ViewOrganizationAdmin()
        {
            //_logger.LogInformation("ViewOrganizationAdmin Action initiated");
            var model = await _organizationAdminService.GetAllOrganizationAdmin();
            //_logger.LogInformation("ViewOrganizationAdmin Action completed");
            return View(model);
        }


        public async Task<IActionResult> ViewOrganizationDetails(int id)
        {
            
            //_logger.LogInformation($"Fetching ViewOrganizationDetails with ID: {id}");
            var response = await _organizationAdminService.GetOrganizationAdminDetailesById(id);
            if (response == null)
            {
                _logger.LogWarning($"ViewOrganizationDetails with ID: {id} not found");
                return NotFound();
            }

            return View(response);
        }

        [HttpGet]
        public async Task<IActionResult> SoftDelete(int id)
        {
            try
            {
                await _organizationAdminService.SoftDeleteOrganizationAdmin(id);
                return Ok($"OrganizationDetails has been soft deleted.");
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Error occurred while soft deleting OrganizationDetails with ID {id}: {ex.Message}");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Block(int id)
        {
            try
            {
                var response = await _organizationAdminService.BlockOrganizationAdmin(id);
                return View(response);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while blocking the OrganizationAdmin." });
            }
        }


     // ---------------------------------------------------------------------------------

        public async Task<IActionResult> AddOrganizationAdmin()
        {
            //ViewBag.ResellerList = (await _reSellerAdminService.GetallResellerAdmin()).Select(r => r.ResellerName).ToList();
            //return View(); 
            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries;
            var resellerList = await _reSellerAdminService.GetallResellerAdmin();
            ViewBag.ResellerList = new SelectList(resellerList, "ResellerAdminUserId", "ResellerName");
            return View(new OrganizationAdminVM());
        }

        [HttpPost]
        public async Task<IActionResult> AddOrganizationAdmin(OrganizationAdminVM request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");


            var response = await _organizationAdminService.CreateOrganizationAdmin(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("ViewOrganizationAdmin");
        }

        public async Task<IActionResult> UpdateOrganizationAdmin(int Id)
        {


            var response = await _organizationAdminService.GetOrganizationAdminById(Id);
            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries; 
            ViewBag.State = await _stateService.GetStatesByCountryId(response.CountryId);
            ViewBag.City = await _cityService.GetCityByStateId(response.StateId);


            var resellerList = await _reSellerAdminService.GetallResellerAdmin();
            ViewBag.ResellerList = new SelectList(resellerList, "ResellerAdminUserId", "ResellerName");


            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrganizationAdmin(OrganizationAdminVM request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response = _organizationAdminService.EditOrganizationAdmin(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("UpdateOrganizationAdmin");
        }


    }
}
