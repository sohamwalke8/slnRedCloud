using Microsoft.AspNetCore.Mvc;

using RedCloud.Domain.Entities;
using RedCloud.Interface;
using RedCloud.Service;

namespace RedCloud.Controllers
{
    public class OrganizationAdminController : Controller
    {
        private readonly IOrganizationAdminService _organizationAdminService;
        private readonly IReSellerAdminService _reSellerAdminService;

        private readonly ILogger<OrganizationAdminController> _logger;


        public OrganizationAdminController(IOrganizationAdminService organizationAdminService, ILogger<OrganizationAdminController> logger,
            IReSellerAdminService reSellerAdminService)
        {
            _organizationAdminService = organizationAdminService;
            _reSellerAdminService = reSellerAdminService;
            _logger = logger;

        }
        public IActionResult AddOrganizationAdmin()
        {
            return View();
        }

        [HttpPost("AddOrganizationAdmin")]
        public async Task<IActionResult> AddOrganizationAdmin(OrganizationAdmin request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response = await _organizationAdminService.CreateOrganizationAdmin(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("AddOrganizationAdmin");
        }

        public IActionResult UpdateOrganizationAdmin()
        {
            ViewBag.ResellerList = _reSellerAdminService.GetallResellerAdmin();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrganizationAdmin(OrganizationAdmin request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response =  _organizationAdminService.EditOrganizationAdmin(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("UpdateOrganizationAdmin");
        }
    }
}
