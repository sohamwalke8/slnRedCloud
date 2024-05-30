using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetResellerAdminWithEvent
{
    public class ReSellerAdmindto
    {
        public int Id { get; set; }
        public string ResellerName { get; set; }
        public string EIN { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int? City { get; set; }//c
        public int? State { get; set; }//c
        public int ZipCode { get; set; }

        public string CompanyURL { get; set; }
        public string CompanySupportEmail { get; set; }
        public string RedCloudAdmin { get; set; }
    }
}
