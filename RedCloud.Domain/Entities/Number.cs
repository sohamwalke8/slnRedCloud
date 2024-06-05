using RedCloud.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Domain.Entities
{
    public class Number : AuditableEntity
    {
        [Key]
        public int NumberId { get; set; }
        public string PhoneNumber { get; set; }
        public virtual List<ResellerAdminUser> ResellerAdminUsers { get; set; } = new List<ResellerAdminUser>();
        public virtual List<OrganizationAdmin> OrganizationAdmin { get; set; } = new List<OrganizationAdmin>();
     
        public int TypesId { get; set; }
        public Types Types { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public int? AssignmentTypeId { get; set; }
        public AssignmentType? AssignmentType { get; set; }
        public int? CarrierId { get; set; }
        public Carrier? Carrier { get; set; }

        public Country Country { get; set; }

        public int CountryId { get; set; }
        public string LATA { get; set; }    
        public string RateCenter { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}