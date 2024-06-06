﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.Numbers.Commands
{
    public  class AssignNumberViewModel
    {
        //non-editabale-prop
        public int NumberId { get; set; }
        public string PhoneNumber { get; set; }

        public string  RateCenter { get; set; }
        public string TypeName { get; set; }
        public string CountryName { get; set; }
        public string LATA { get; set; }   
        public string StateName { get; set; }
       public string CarrierName { get; set; }

        //editable-prop
        public int? ResellerAdminUserId { get; set; }
        //public IEnumerable<SelectListItem> ResellerAdminUser { get; set; }

        public int? OrgID { get; set; }
        //public IEnumerable<SelectListItem> OrganizationAdmin { get; set; }
        public int? AssignmentTypeId { get; set; }
        //public IEnumerable<SelectListItem> AssignmentType { get; set; }
        //public IEnumerable<SelectListItem> Campaign { get; set; }
        public int? CampaignId { get; set; }
        public string StartDate { get; set; }

        public string EndDate { get; set; }


    }
}
