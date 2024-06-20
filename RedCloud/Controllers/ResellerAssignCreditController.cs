using Microsoft.AspNetCore.Mvc;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Controllers
{
    public class ResellerAssignCreditController : Controller
    {
        private readonly IResellerAssignCreditService _resellerAssignCreditService;
        public ResellerAssignCreditController(IResellerAssignCreditService resellerAssignCreditService)
        {
            _resellerAssignCreditService = resellerAssignCreditService;
        }
        public IActionResult ListRate()
        {
            return View();
        }
        public async Task<IActionResult> AddRate()
        {
            var lstOrg = await _resellerAssignCreditService.GetOrganizationAdminList();
            var lstTypes = await _resellerAssignCreditService.GetCreditsTypeList();
            ViewBag.listOrg = lstOrg;
            ViewBag.listTypes = lstTypes;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRate(RateAssignCreditVM model)
        {
            var lstOrg = await _resellerAssignCreditService.GetOrganizationAdminList();
            var lstTypes = await _resellerAssignCreditService.GetCreditsTypeList();
            ViewBag.listOrg = lstOrg;
            ViewBag.listTypes = lstTypes;
            if (ModelState.IsValid)
            {
                var res = await _resellerAssignCreditService.AddRate(model);
                return RedirectToAction("ListRate");
            }
            return View();
        }
        public async Task<IActionResult> EditRate(int Id)
        {
            var lstOrg = await _resellerAssignCreditService.GetOrganizationAdminList();
            var lstTypes = await _resellerAssignCreditService.GetCreditsTypeList();
            ViewBag.listOrg = lstOrg;
            ViewBag.listTypes = lstTypes;
            if (Id != null || Id != 0)
            {
                var resposne = await _resellerAssignCreditService.GetRateById(Id);
                return View(resposne);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditRate(RateAssignCreditVM model)
        {
            if (ModelState.IsValid)
            {
                var resposne = await _resellerAssignCreditService.EditRate(model);
            }
            return RedirectToAction("ListRate");
        }
    }
}