using Microsoft.AspNetCore.Mvc;
using RedCloud.Domain.Entities;
using RedCloud.Models;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace RedCloud.Controllers
{
    public class HomeController : Controller
    {
    //    private readonly ILogger<HomeController> _logger;
    //    private readonly IAsyncRepository<HomeController> _repo;

    //    public HomeController(ILogger<HomeController> logger, IAsyncRepository<HomeController> repo)
    //    {
    //        _logger = logger;
    //        _repo = repo;
    //    }

        public IActionResult Index()
        {
        //   var countries = new List<CountryVM>
        //{
        //   new CountryVM { CountryId = 2, Name = "India" },
        //   new CountryVM { CountryId = 3, Name = "Korea" }

        
        //   ViewBag.Country = countries;
          return View();
        }

        //public IActionResult GetStateByCountryId(int  countryId)
        //{
        //    List<StateVM> states = new List<StateVM>
        //    {
        //    new StateVM {StateId=1, CountryId = 2, Name = "Maharashtra" },
        //    new StateVM {StateId=2, CountryId = 3, Name = "Seoul" }
        //    };
        //    states=states.Where (x=>x.CountryId== countryId).ToList();
        //    return PartialView("_StateDropdown",states); 
        //}
        //public IActionResult GetCityByStateId(int stateId)
        //{
        //    List<CityVM> city = new List<CityVM>
        //    {
        //    new CityVM {StateId=1, CityId = 2, Name = "Mumbai" },
        //    new CityVM {StateId=4, CityId = 3, Name = "Hamnisa" }
        //    };
        //  city = city.Where(x => x.StateId == stateId).ToList();
        //    return PartialView("_CityDropdown", city);
        //}


        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
