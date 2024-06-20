using Microsoft.AspNetCore.Mvc;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReport _report;

        public ReportController(IReport report)
        {
            _report = report;
        }

        [HttpGet]
        public async Task<IActionResult> ViewInboundReport()
        {

            var response = await _report.GetallResellerInboundMessagesReport();

            return View(response);
        }


        [HttpGet]
        public async Task<IActionResult> ViewOutboundReport()
        {

            var response = await _report.GetOutboundResellerInboundMessagesReport();

            return View(response);
        }

        //[HttpGet]
        //public async Task<IActionResult> ViewFullOrgReport()
        //{
        //    var r = await _report.GetTotalReportCount();
        //    var response = await _report.GetFullResellerInboundMessagesReport();

        //    return View(response);
        //    return View(r);
        //}

        [HttpGet]
        public async Task<IActionResult> ViewFullOrgReport()
        {
            var totalReports = await _report.GetTotalReportCount();
            var resellerInboundMessagesReports = await _report.GetFullResellerInboundMessagesReport();

            var model = new FullOrgReportVM
            {
                ResellerInboundMessagesReports = resellerInboundMessagesReports,
                TotalReports = totalReports
            };

            return View(model);
        }

    }
}
