using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin
{
    public  class ReSellerAdminVM
    {
        public int Id { get; set; }
        public string ReSellerName { get; set; }
        public string EIN { get; set; }
        public string CompanySupportEmail { get; set; }
        public bool IsActive { get; set; }
    }
}
