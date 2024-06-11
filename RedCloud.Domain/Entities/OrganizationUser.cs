using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Domain.Entities
{
    public class OrganizationUser
    {
        public int OrganizationUserId { get; set; }

        public string OrganizationUserFirstName { get; set; }


        public string OrganizationUserLastName { get; set; }

        public string OrganizationUserEmail { get; set; }

       
    }
}
