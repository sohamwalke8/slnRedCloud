using Microsoft.AspNetCore.Mvc;

namespace RedCloud.Controllers
{
    public class CampaignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
