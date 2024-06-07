using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Domain.Entities;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Controllers
{
    public class ResellerAdminUserController : Controller
    {
        private readonly IAdminResellerUser _adminreseller;
        private readonly ILogger<ResellerAdminUserController> _logger;
        private readonly IDropDownService<CountryVM> _dropDownService;
        private readonly IStateService<StateVM> _stateService;
        private readonly ICityService<CityVM> _cityService;
        private readonly IRedCloudAdminService _redcloudAdminService;




        public ResellerAdminUserController(IAdminResellerUser adminreseller, ILogger<ResellerAdminUserController> logger, IDropDownService<CountryVM> dropDownService, 
            IStateService<StateVM> stateService, ICityService<CityVM> cityService, IRedCloudAdminService redCloudAdmin)
        {
            _adminreseller = adminreseller;
            _logger = logger;
            _dropDownService = dropDownService;
            _stateService = stateService;
            _cityService = cityService;
            _redcloudAdminService = redCloudAdmin;




        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddReseller()

        {
            var resellerList = await _redcloudAdminService.GetallRedCloudAdminUser();
            ViewBag.AdminList = new SelectList(resellerList, "RedCloudAdminUserId", "FirstName");
            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries;
            return View(new ResellerAdminUserVM());
        }

        [HttpPost]
        public async Task<IActionResult> AddReseller(ResellerAdminUser Model)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response = await _adminreseller.CreateAdminResellerUserAsync(Model);//name of service and service method

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("ViewallResellerAdmin");
        }


        //public IActionResult UpdateResellerAdmin(int Id)
        //{

        //    return View();
        //}


        public async Task<IActionResult> UpdateResellerAdminUser(int Id)
        {

            //var response = await _organizationAdminService.GetOrganizationAdminById(Id)
            ;
            var response = await _adminreseller.GetResellerAdminUserById(Id)
       ;
            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries;
            ViewBag.State = await _stateService.GetStatesByCountryId(response.CountryId);
            ViewBag.City = await _cityService.GetCityByStateId(response.StateId);

            // var countries = await _dropDownService.GetAllCountryList();
            //ViewBag.Country = countries;
            var resellerList = await _redcloudAdminService.GetallRedCloudAdminUser();
            ViewBag.AdminList = new SelectList(resellerList, "RedCloudAdminUserId", "FirstName");
            // var resellerList = await _reSellerAdminService.GetallResellerAdmin();
            // ViewBag.ResellerList = new SelectList(resellerList, "Id", "ResellerName");
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateResellerAdminUser(ResellerAdminUser request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response = _adminreseller.UpdateAdminResellerUser(request);

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
            var response = await _adminreseller.GetallResellerAdminUser();
            //_logger.LogInformation("ViewResellerAdmin Action completed");
            return View(response);
        }


        /////DISHa
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///


        [HttpGet]
        public async Task<IActionResult> ViewallResellerAdmin()
        {
            //_logger.LogInformation("ViewResellerAdmin Action initiated");
            var response = await _adminreseller.GetallResellerAdmin();
            //_logger.LogInformation("ViewResellerAdmin Action completed");
            return View(response);
        }



//public async Task<IActionResult> GetResellerAdminById(int id)
//{
//    var response = await _reSellerAdminService.GetResellerAdminById(id)

        //    return View(response);
        //}
        public async Task<IActionResult> GetResellerByID(int id)
        {
            _logger.LogInformation($"Fetching ResellerAdmin with ID: {id}");
            var response = await _adminreseller.GetResellerAdminById(id)
  ;

            if (response == null)
            {
                _logger.LogWarning($"ResellerAdmin with ID: {id} not found");
                return NotFound();
            }

            return View(response);
        }




        [HttpGet]
        public async Task<IActionResult> SoftDeleteResellerAdmin(int id)
        {
            try
            {
                await _adminreseller.SoftDeleteResellerAdmin(id);
                return Ok($"ResellerAdmin with ID {id} has been soft deleted.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred while soft deleting ResellerAdmin with ID {id}: {ex.Message}");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }


        [HttpPut]
        public async Task<IActionResult> Block(int id)
        {
            try
            {
                var response = await _adminreseller.Block(id)
    ;
                return View(response);

            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while blocking the reseller." });
            }
        }






    }
}
