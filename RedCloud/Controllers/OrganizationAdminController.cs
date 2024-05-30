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
            return View(new OrganizationAdminVM());
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

            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries;
            var response = await _organizationAdminService.GetOrganizationAdminById(Id);
            var resellerList = await _reSellerAdminService.GetallResellerAdmin();
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

                                                         //-----------------------------------------------------------------------------------------------------


        public async Task<IActionResult> ViewOrganizationAdmin()
        {
            var model = new List<AllOrganizationAdminVM>
            {
                new AllOrganizationAdminVM
                {
                    OrgID = 1,
                    OrgName = "Sample Organization 1",
                    EIN = "12-3456789",
                    OrgAdminEmail = "admin1@sample.org",
                    IsActive = true
                },
                new AllOrganizationAdminVM
                {
                    OrgID = 2,
                    OrgName = "Sample Organization 2",
                    EIN = "98-7654321",
                    OrgAdminEmail = "admin2@sample.org",
                    IsActive = false
                },
                 new AllOrganizationAdminVM
                {
                     OrgID = 3,
                    OrgName = "Sample Organization 3",
                    EIN = "98-7654321",
                    OrgAdminEmail = "admin2@sample.org",
                    IsActive = false
                 }
            };
            return View(model);
        }


        public async Task<IActionResult> ViewOrganizationDetails()
        {
            //var dummyData = new OrganizationAdmin
            //{
            //    OrgID = 1,
            //    OrgName = "Sample Organization",
            //    EIN = "123456789",
            //    OrgAdminName = "John Doe",
            //    OrgAdminEmail = "john.doe@example.com",
            //    OrgAdminMobNo = "123-456-7890",
            //    AddressLineOne = "123 Main St",
            //    AddressLineTwo = "Suite 400",
            //    ZipCode = 12345,
            //    OrgURL = "http://www.sampleorg.com",
            //    IsActive = true,
            //    Country = new Country { CountryId = 1, Name = "USA" },
            //    State = new State { StateId = 1, Name = "California" },
            //    City = new City { CityId = 1, Name = "Los Angeles" },
            //    CountryId = 1,
            //    StateId = 1,
            //    CityId = 1
            //};

            //return View(dummyData);
            return View();
        }

    }
}
