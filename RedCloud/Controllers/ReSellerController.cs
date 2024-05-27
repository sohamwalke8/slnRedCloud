using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Domain.Entities;
using RedCloud.Interface;
using RedCloud.Models;

namespace RedCloud.Controllers
{
    public class ReSellerController : Controller
    {

        private readonly IAdminReseller _adminreseller;
        private readonly ILogger<OrganizationAdmin> _logger;


        public ReSellerController(IAdminReseller adminreseller, ILogger<OrganizationAdmin> logger)
        {
            _adminreseller = adminreseller;
            _logger = logger;

        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddReseller()
        {
            return View();
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
            var response = await _adminreseller.GetResellerAdminById(Id)
;
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
    }
}
