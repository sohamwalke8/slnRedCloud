using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Application.Features.OrganizationAdmins.Queries;
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
        public async Task<IActionResult> AddOrganizationAdmin()
        {
            //ViewBag.ResellerList = (await _reSellerAdminService.GetallResellerAdmin()).Select(r => r.ResellerName).ToList();
            //return View(); 
            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries;
            var resellerList = await _reSellerAdminService.GetallResellerAdminUser();
            ViewBag.ResellerList = new SelectList(resellerList, "Id", "ReSellerName");
            return View(new OrganizationAdminVM());
        }

        [HttpPost]
        public async Task<IActionResult> AddOrganizationAdmin(OrganizationAdminVM request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");


            var response = await _organizationAdminService.CreateOrganizationAdmin(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("AddOrganizationAdmin");
        }

        public async Task<IActionResult> UpdateOrganizationAdmin(int Id)
        {


            var response = await _organizationAdminService.GetOrganizationAdminById(Id);
            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries;
            ViewBag.State = await _stateService.GetStatesByCountryId(response.CountryId);
            ViewBag.City = await _cityService.GetCityByStateId(response.StateId);


            var resellerList = await _reSellerAdminService.GetallResellerAdminUser();
            ViewBag.ResellerList = new SelectList(resellerList, "Id", "ReSellerName");


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
