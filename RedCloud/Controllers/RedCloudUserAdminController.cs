using Microsoft.AspNetCore.Mvc;
using RedCloud.Domain.Entities;
using RedCloud.Interface;
using RedCloud.Models;
using RedCloud.Service;

namespace RedCloud.Controllers
{
    public class RedCloudUserAdminController : Controller
    {

        private readonly IAdminUserService _adminUserService;
        private readonly ILogger<AdminUserService> _logger;


        public RedCloudUserAdminController(IAdminUserService adminUserService, ILogger<AdminUserService> logger)
        {
            _adminUserService = adminUserService;
            _logger = logger;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost("AddAdminUser")]
        public async Task<IActionResult> AddAdmin(RedCloudUserVM request)
        {
            if (ModelState.IsValid)
            {
                var adminUser = new AdminUser
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    MobileNumber = request.MobileNumber,
                    IsActive = request.IsActive
                };

                var response = await _adminUserService.CreateAdminUser(adminUser);
                return RedirectToAction("Index");
            }

            
            return View(request);
        }
        public IActionResult EditAdmin()
        {
            return View();
        }

        [HttpPost("EditAdminUser")]
        public async Task<IActionResult> EditAdmin(RedCloudUserVM request)
        {
            if (ModelState.IsValid)
            {
                var adminUser = new AdminUser
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    MobileNumber = request.MobileNumber,
                    IsActive = request.IsActive,
                    ID=request.ID
                };

                
                await _adminUserService.EditAdminUser(adminUser);

                return RedirectToAction("Index");
            }

            
            return View(request);
        }

    }
}