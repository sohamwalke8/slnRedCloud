using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Domain.Entities
{
    public class AllOrganizationAdminVM
    {
        public int OrgID { get; set; }
        public string OrgName { get; set; }

        public string EIN { get; set; }

        public string OrgAdminEmail { get; set; }

        public bool IsActive { get; set; }

    }
}
