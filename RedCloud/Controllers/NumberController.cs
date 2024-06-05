using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Domain.Entities;
using RedCloud.Interfaces;
using RedCloud.Services;
using RedCloud.ViewModel;
using System.ComponentModel.Design;

namespace RedCloud.Controllers
{
    public class NumberController : Controller
    {
        private readonly IDropDownService<CountryVM> _dropDownService;
        private readonly IStateService<StateVM> _stateService;
        private readonly ICarrier<CarrierVM> _carrier;
        private readonly IType<TypesVM> _type;
        private readonly INumberService<NumberVM> _numberService;
      
        

        public NumberController(IDropDownService<CountryVM> dropDownService, IStateService<StateVM> stateService, ICarrier<CarrierVM> carrier, IType<TypesVM> type, INumberService<NumberVM> numberService)
        {
            _dropDownService = dropDownService;
            _stateService = stateService;
            _carrier = carrier;
            _type = type;
            _numberService = numberService;
            
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddNumber()

        {
            var carrierlist = await _carrier.GetAllCarriersList();
            ViewBag.AdminList = new SelectList(carrierlist, "CarrierId", "CarrierName");
            var countries = await _dropDownService.GetAllCountryList();
            ViewBag.Country = countries;
            var typelist=await _type.GetAllTypesList();
            ViewBag.Typelist = new SelectList(typelist, "TypesId", "TypesName");
           
            return View(new NumberVM());
        }

        [HttpPost]
        public async Task<IActionResult> AddNumber(NumberVM Model)
        {
          
            var response = await _numberService.AddNumber(Model);//name of service and service method

            return RedirectToAction("AddNumber");
        }


    }
}
