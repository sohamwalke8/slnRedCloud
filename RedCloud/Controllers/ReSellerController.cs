using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Domain.Entities;
using RedCloud.Interface;
using RedCloud.Models;
using RedCloud.ModelVM;
using RedCloud.Service;

namespace RedCloud.Controllers
{
    public class ReSellerController : Controller
    {

        private readonly IAdminReseller _adminreseller;
        private readonly ILogger<OrganizationAdmin> _logger;
        private readonly IDropDownService<CountryVM> _dropDownService;
        private readonly IStateService<StateVM> _stateService;
        private readonly ICityService<CityVM> _cityService;




        public ReSellerController(IAdminReseller adminreseller, ILogger<OrganizationAdmin> logger, IDropDownService<CountryVM> dropDownService, IStateService<StateVM> stateService, ICityService<CityVM> cityService)
        {
            _adminreseller = adminreseller;
            _logger = logger;
            _dropDownService = dropDownService;
            _stateService = stateService;
            _cityService = cityService;




        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddReseller()

        {
            var resellerList = await _adminreseller.GetallResellerAdmin();
            ViewBag.AdminList = new SelectList(resellerList, "ID", "FirstName" );
            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries;
            return View(new ResellerAdminVM());
        }

        [HttpPost]
        public async Task<IActionResult> AddReseller(ResellerAdmin Model)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response = await _adminreseller.CreateAdminResellerAsync(Model);//name of service and service method

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("Index");
        }
         

        //public IActionResult UpdateResellerAdmin(int Id)
        //{

        //    return View();
        //}


        public async Task<IActionResult> UpdateResellerAdmin(int Id)
        {

            //var response = await _organizationAdminService.GetOrganizationAdminById(Id);
            var response = await _adminreseller.GetResellerAdminById(Id);
            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries;
            ViewBag.State = await _stateService.GetStatesByCountryId(response.CountryId);
            ViewBag.City = await _cityService.GetCityByStateId(response.StateId);
            
           // var countries = await _dropDownService.GetAllCountryList();
            //ViewBag.Country = countries;
            var resellerList = await _adminreseller.GetallResellerAdmin();
            ViewBag.AdminList = new SelectList(resellerList, "ID", "FirstName");
            // var resellerList = await _reSellerAdminService.GetallResellerAdmin();
            // ViewBag.ResellerList = new SelectList(resellerList, "Id", "ResellerName");
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateResellerAdmin(ResellerAdmin request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response = _adminreseller.UpdateAdminReseller(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("UpdateResellerAdmin");
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


        [HttpGet]
        public async Task<IActionResult> ViewResellerAdmin()
        {
            //_logger.LogInformation("ViewResellerAdmin Action initiated");
            var response = await _adminreseller.GetallResellerAdmin();
            //_logger.LogInformation("ViewResellerAdmin Action completed");
            return View(response);
        }

    }
}
