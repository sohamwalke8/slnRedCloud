using Microsoft.AspNetCore.Mvc;
using RedCloud.Application.Features.RedCloudAdmins.Commands.CreateRedCloudAdmin;
using RedCloud.Domain.Entities;
using RedCloud.Interfaces;
using RedCloud.Services;

namespace RedCloud.Controllers
{
    public class RedCloudAdminController : Controller
    {

        private readonly IRedCloudAdminService _adminUserService;
        private readonly ILogger<RedCloudAdminService> _logger;

        public RedCloudAdminController(IRedCloudAdminService adminUserService, ILogger<RedCloudAdminService> logger)
        {
            _adminUserService = adminUserService;
            _logger = logger;
        }
        public IActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost("AddAdminUser")]
        public async Task<IActionResult> AddAdmin(RedCloudAdminVM request)
        {
            if (ModelState.IsValid)
            {
                var adminUser = new RedCloudAdmin
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    MobileNumber = request.MobileNumber,
                    IsActive = request.IsActive,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = null,
                    IsDeleted = false
                };

                var response = await _adminUserService.CreateAdminUser(adminUser);
                return RedirectToAction("Index");
            }
            return View(request);
        }

        public async Task<IActionResult> EditAdmin(int Id)
        {
            var response = await _adminUserService.GetAdminUserById(Id);
            return View(response);
        }


        [HttpPost("EditAdminUser")]
        public async Task<IActionResult> EditAdmin(RedCloudAdminVM request)
        {
            if (ModelState.IsValid)
            {
                var adminUser = new RedCloudAdmin
                {
                    RedCloudAdminUserId = request.RedCloudAdminUserId,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    MobileNumber = request.MobileNumber,
                    IsActive = request.IsActive,
                    LastModifiedDate = DateTime.UtcNow,
                    LastModifiedBy = null
                };

                await _adminUserService.EditAdminUser(adminUser);
                return RedirectToAction("Index");
            }
            return View(request);
        }
    }
}
