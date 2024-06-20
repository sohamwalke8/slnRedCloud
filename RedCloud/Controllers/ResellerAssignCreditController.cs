using Microsoft.AspNetCore.Mvc;

namespace RedCloud.Controllers
{
    public class ResellerAssignCreditController : Controller
    {
        public IActionResult AssignCreditList()
        {
            return View();
        }


        public IActionResult AssignCreditDetailsById(int id)
        {
            return View();
        }


    }
}
