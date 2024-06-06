using RedCloud.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Domain.Entities
{
    public class Campaign: AuditableEntity
    {
        public int CampaignId { get; set; }

        public int OrgID { get; set; }

        public OrganizationAdmin OrganizationAdmin { get; set; }

        public int ResellerAdminUserId { get; set; }

        public ResellerAdminUser ResellerAdminUser { get; set;}

        public string CompanyName { get; set; }

        public string UniversalEIN { get; set; }

        public int BrandId { get; set; }

        public  Status IdentityStatus { get; set; }

        public string? BrandRelationship { get; set; }

        public DateOnly? BrandRegistrationDate { get; set; }

        public string CampaignIdOne { get; set; }
        public string? CampaignIdTwo { get; set; }

        public string UseCaseOne { get; set; }
        public string? UseCaseTwo { get; set; }

        public DateOnly  RegistrationDateOne { get; set; }

        public DateOnly? RegistrationDateTwo { get; set; }

        public DateOnly RenewalDateOne { get; set; }
        public DateOnly? RenewalDateTwo { get; set; }

        public string CampaignDescriptionOne { get; set; }
        public string? CampaignDescriptionTwo { get; set; }

    }


    

}
