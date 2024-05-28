using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Protocol.Plugins;
using RedCloud.Interface;
using RedCloud.Models.Account;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Application.Helper;
namespace RedCloud.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;


        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        // Action method to display the login page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Action method to handle login POST requests
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                LoginVM loginData = new LoginVM()
                {
                    Email = model.Email,
                    Password = EncryptionDecryption.EncryptString(model.Password)
                };


                var data = loginData;

                // Here you would call your API to validate the credentials
                //var result =await _accountService.Login(loginData);

                //correct code below 
                var result =await _accountService.Login(model);
                if (!result.Succeeded)
                {
                     ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);

                }
                if (result.Data.Roles != null)
                {
                    // Set session data
                    var roles = result.Data.Roles.Select(r => new {
                        RoleName = r.RoleName.Trim(),
                        // Include other properties if needed
                    });
                    HttpContext.Session.SetString("Email", result.Data.Email);
                    HttpContext.Session.SetString("UserRoles", JsonConvert.SerializeObject(roles));

                    var RoleName = result.Data.Roles[0].RoleName;

                    HttpContext.Session.SetString("Role", RoleName);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }
            return View(model);
        }

        public IActionResult SetRole(string roleName)
        {
            // Set the session variable to the provided role name
            HttpContext.Session.SetString("Role", roleName);

            ViewBag.role = HttpContext.Session.GetString("Role");

            if (HttpContext.Session.GetString("Role") == "SubAdminAdministrartor")
            {
                return PartialView("_SubAdmin", ViewBag.role);
            }
            else if (HttpContext.Session.GetString("Role") == "ResellerAdmin")
            {
                return PartialView("_ResellerAdmin", ViewBag.role);
            }
            else if (HttpContext.Session.GetString("Role") == "OrganizationAdmin")
            {
               return PartialView("_OrganizationAdmin", ViewBag.role);
            }
            else if (HttpContext.Session.GetString("Role") == "MessagingUsers")
            {
                return PartialView("_MessagingUsers", ViewBag.role);
            }

            return RedirectToAction("Index", "Home");
        }



        //[HttpPost]
        //public async Task<IActionResult> LoginAsync(Login login)
        //{

        //    if (ModelState.IsValid)
        //    {

        //        //LoginResponse loginResponse = await _service.Login(login);
        //        //if (loginResponse.UserName != null)
        //        {
        //            //HttpContext.Session.SetString("UserName", loginResponse.UserName);
        //            //_notyf.Success("Logged In Successfully");

        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {

        //            //_notyf.Error(loginResponse.Message);
        //            return View();
        //        }

        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}






    }
}
