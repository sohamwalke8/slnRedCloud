﻿using AutoMapper.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Newtonsoft.Json;
using RedCloud.Application.Contract.Infrastructure;
using RedCloud.Application.Features.Account.Queries.LoginQuery;
using RedCloud.Application.Helper;
using RedCloud.Domain.Common;
using RedCloud.Interfaces;
using RedCloud.Models.Email;
using RedCloud.Services;
using RedCloud.ViewModel;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace RedCloud.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMailService _mailService;
        private readonly IEncryptionService _encryptionService;

        public AccountController(IAccountService accountService, IMailService mailService, IEncryptionService encryptionService)
        {
            _accountService = accountService;
            _mailService = mailService;
            _encryptionService = encryptionService;
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

                //to convert the plain text into encrypted password 
                //LoginVM loginData = new LoginVM()
                //{
                //    Email = model.Email,
                //    Password = EncryptionDecryption.EncryptString(model.Password)
                //};


                //var data = loginData;

                // Here you would call your API to valIdate the credentials
                //var result =await _accountService.Login(loginData);

                //correct code below 
                var result = await _accountService.Login(model);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "InvalId login attempt.");
                    return View(model);

                }
                if (result.Data.Roles != null)
                {
                    // Set session data
                    var roles = result.Data.Roles.Select(r => new
                    {
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
                    ModelState.AddModelError(string.Empty, "InvalId login attempt.");
                }
            }
            return View(model);
        }

        public IActionResult SetRole(string roleName)
        {
            // Set the session variable to the provIded role name
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

        //ForgetUserPasswordVM
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetUserPasswordVM model)
        {
            if (string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError("Email", "Email is required.");
                return View();
            }
            else
            {
                var IsUserExist = await _accountService.CheckUserExistByEmail(model.Email);

                if (IsUserExist == null)
                {
                    // _logger.LogWarning($"Rate with ID: {id} not found");
                    return NotFound();
                }
                else
                {
                    int originalValue = IsUserExist.UserId;
                    string encryptedValue = _encryptionService.EncryptValue(originalValue);

                    MailRequest mailRequest = new MailRequest()
                    {
                        ToEmail = model.Email,
                        Subject = "Forget Password",
                        //Body = $"This Forget email password please click  https://localhost:7206/Account/ResetPassword"
                        //Body = $"This Forget email password please click  https://localhost:7206/Account/ResetPassword/{data[0].userId}"
                        //Body = $"This Forget email password please click  https://localhost:7206/Account/ResetUserPassword/{IsUserExist.UserId}"
                        //Body = $"This Forget email password please click  {EncrptedUrl}"
                        //Body = $"This Forget email password please click  https://localhost:7206/Account/ResetUserPassword/{EncrptedUrl}"
                        Body = $"This Forget email password please click  https://localhost:7206/Account/ResetUserPassword/?strUserId={encryptedValue}"
                    };
                    await _mailService.SendEmailAsync(mailRequest);
                    //var responses = await _accountService.ForgetUserPasswordService(model);

                    // Return to the same view with a success message
                    TempData["SuccessMessage"] = "Email sent successfully! Please check on mail";
                }
            }
            return View();
        }
        public async Task<IActionResult> ResetUserPassword(string strUserId)
        {
            int UserId = _encryptionService.DecryptValue(strUserId);
            ViewBag.UserId = UserId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetUserPassword(ResetUserPasswordVM model)
        {      
            if (ModelState.IsValid)
            {
                model.Password = EncryptionDecryption.EncryptString(model.Password);
                var response = await _accountService.ForgetUserPasswordService(model);
                TempData["SuccessMessage"] = "Password Reset successfully!l";
            }
            else
            {
                TempData["ErrorMessage"] = "Please try again!";
            }
            return View();
        }

        /*
        [HttpPost]
        public async Task<IActionResult> LoginAsync(Login login)
        {

            if (ModelState.IsValid)
            {

                //LoginResponse loginResponse = await _service.Login(login);
                //if (loginResponse.UserName != null)
                {
                    //HttpContext.Session.SetString("UserName", loginResponse.UserName);
                    //_notyf.Success("Logged In Successfully");

                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    //_notyf.Error(loginResponse.Message);
                    return View();
                }

            }
            else
            {
                return View();
            }
        }
        */
    }
}
