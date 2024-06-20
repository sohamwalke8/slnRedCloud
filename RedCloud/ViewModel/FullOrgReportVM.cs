using RedCloud.Domain.Entities;

namespace RedCloud.ViewModel
{
    public class FullOrgReportVM
    {
        public IEnumerable<ResellerInboundMessagesReport> ResellerInboundMessagesReports { get; set; }
        public IEnumerable<TotalReport> TotalReports { get; set; }
    }
}
