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
        private readonly ILogger<OrganizationAdminController> _logger;
        


        public OrganizationAdminController(IOrganizationAdminService organizationAdminService, ILogger<OrganizationAdminController> logger)
        {
            _organizationAdminService = organizationAdminService;
            _logger = logger;
           
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> ViewOrganizationAdmin()
        {

            /*For Dummy Data Insert :
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
            */

            //_logger.LogInformation("ViewOrganizationAdmin Action initiated");
            var model = await _organizationAdminService.GetAllOrganizationAdmin();
            //_logger.LogInformation("ViewOrganizationAdmin Action completed");
            return View(model);
        }


        public async Task<IActionResult> ViewOrganizationDetails(int id)
        {
            /*var dummyData = new OrganizationAdmin
            {
                OrgID = 1,
                OrgName = "Sample Organization",
                EIN = "123456789",
                OrgAdminName = "John Doe",
                OrgAdminEmail = "john.doe@example.com",
                OrgAdminMobNo = "123-456-7890",
                AddressLineOne = "123 Main St",
                AddressLineTwo = "Suite 400",
                ZipCode = 12345,
                OrgURL = "http://www.sampleorg.com",
                IsActive = true,
                Country = new Country { CountryId = 1, Name = "USA" },
                State = new State { StateId = 1, Name = "California" },
                City = new City { CityId = 1, Name = "Los Angeles" },
                CountryId = 1,
                StateId = 1,
                CityId = 1
            };

            //return View(dummyData);
            */

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
                return Ok($"OrganizationDetails with ID {id} has been soft deleted.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred while soft deleting OrganizationDetails with ID {id}: {ex.Message}");
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



    }
}
