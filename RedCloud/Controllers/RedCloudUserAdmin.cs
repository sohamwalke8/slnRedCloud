using Microsoft.AspNetCore.Mvc;

namespace RedCloud.Controllers
{
    public class RedCloudUserAdmin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddAdmin()
        {
            return View();
        }
        public IActionResult EditAdmin()
        {
            return View();
        }
    }
}
