using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Domain.Entities;
using RedCloud.Interface;
using RedCloud.Models;
using RedCloud.ModelVM;
using RedCloud.Service;

namespace RedCloud.Controllers
{
    public class OrganizationAdminController : Controller
    {
        private readonly IOrganizationAdminService _organizationAdminService;
        private readonly IReSellerAdminService _reSellerAdminService;

        private readonly ILogger<OrganizationAdminController> _logger;
        private readonly IDropDownService<CountryVM> _dropDownService;
        private readonly IStateService<StateVM> _stateService;
        private readonly ICityService<CityVM> _cityService;


        public OrganizationAdminController(IOrganizationAdminService organizationAdminService, ILogger<OrganizationAdminController> logger,
            IReSellerAdminService reSellerAdminService, IDropDownService<CountryVM> dropDownService, IStateService<StateVM> stateService, ICityService<CityVM> cityService)
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
            var resellerList = await _reSellerAdminService.GetallResellerAdmin();
            ViewBag.ResellerList = new SelectList(resellerList, "Id", "ReSellerName");
            return View();
        }

        [HttpPost("AddOrganizationAdmin")]
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
            var resellerList = await _reSellerAdminService.GetallResellerAdmin();
            ViewBag.ResellerList = new SelectList(resellerList, "Id", "ReSellerName");   
            
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrganizationAdmin(OrganizationAdminVM request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response =  _organizationAdminService.EditOrganizationAdmin(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("UpdateOrganizationAdmin");
        }

        public async Task<IActionResult> GetCountry()
        {

            _logger.LogInformation("GetCountry method initiated");


            var countries = await _dropDownService.GetAllCountryList();


            _logger.LogInformation("GetCountry method completed");

            ViewBag.Country = countries;
            return View();

        }




        public async Task<IActionResult> GetStateByCountryId(int countryId)
        {


            _logger.LogInformation("GetStateByCountryId initiated");

            var states = await _stateService.GetStatesByCountryId(countryId);

            _logger.LogInformation("GetStateByCountryId completed");

            return PartialView("_StateDropdown", states);



        }





        public async Task<IActionResult> GetCityByStateId(int stateId)
        {

            var city = await _cityService.GetCityByStateId(stateId);
            return PartialView("_CityDropdown", city);
        }

    }
}
