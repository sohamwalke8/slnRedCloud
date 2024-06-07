using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Domain.Entities
{
    
    public class Campaign
    {

        public int CampaignId { get; set; }


        public string CompanyName { get; set;}

        public int UniversalEIN { get; set; }

        public int BrandId { get; set; }        

        public bool IsActive { get; set; }=true;

        public bool IsDeleted { get; set; } = false;

    }
}
