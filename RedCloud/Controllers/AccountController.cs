using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Protocol.Plugins;
using RedCloud.Interface;
using RedCloud.Models.Account;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
namespace RedCloud.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        //public const string SessionName = "_Name";
        //public const string SessionId = "_RoleId";


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
                // Here you would call your API to validate the credentials
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

                    //if(MainRoleId == 1)
                    //    return RedirectToAction("Index", "Home");
                    //else if(MainRoleId == 2)
                    //    return RedirectToAction("Index", "Home");
                    //else if(MainRoleId == 3)
                    //    return RedirectToAction("Index", "Home");
                    //else
                    
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

            // Optionally, you can return a response indicating success
            return Ok(); // 200 OK status code
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
