﻿using Microsoft.AspNetCore.Mvc;
using RedCloud.Domain.Entities;
using RedCloud.Interface;
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
        public async Task<IActionResult> AddAdmin(AdminUser request)
        {
           // _logger.LogInformation("CreateCategory Action initiated");
            var response = await _adminUserService.CreateAdminUser(request);
           
            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("Index");
        }
        public IActionResult EditAdmin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditAdmin(AdminUser request)
        {
            // _logger.LogInformation("CreateCategory Action initiated");
            var response = _adminUserService.EditAdminUser(request);

            //_logger.LogInformation("CreateCategory Action initiated");
            return RedirectToAction("EditAdmin");
        }
    }
}