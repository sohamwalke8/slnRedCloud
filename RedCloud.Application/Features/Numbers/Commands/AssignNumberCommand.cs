using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedCloud.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.Numbers.Commands
{
    public class AssignNumberCommand : IRequest<Response<Unit>>
    {
        public int? NumberId { get; set; }
        ////public string PhoneNumber { get; set; } 
        
        //public string RateCenter { get; set; }

        //public int? CountryId { get; set; }

        //public int? StateId { get; set; }

        //public int? TypeId { get; set; }

        //public string? LATA { get; set; }   

        public int?  ResellerAdminUserId { get; set; }
        public int? OrganizationAdminId { get; set; }
       
        public int? AssignmentTypeId { get; set; }

         public int? CampaignId { get; set; }  
       

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }


    }
}
