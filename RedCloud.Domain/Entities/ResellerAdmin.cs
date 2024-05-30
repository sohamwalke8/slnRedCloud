using RedCloud.Domain.Comman;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Domain.Entities
{
    public class ResellerAdmin: AuditableEntity
    {
        [Key]
        public int Id { get; set; }

        public string ResellerName { get; set; }
        public string EIN { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
      //  public string City { get; set; }
       // public string State { get; set; }
        public int ZipCode { get; set; }

        public string CompanyURL { get; set; }
        public string CompanySupportEmail { get; set; }
     
        public string? RedCloudAdmin { get; set; }

        public string? Password { get; set; }

        public bool IsActive { get; set; } = true;

       // public bool IsDeleted { get; set; } = false;
        public int? OrganizationAdminId { get; set; }


        public virtual OrganizationAdmin? OrganizationAdmins { get; set; }

        public virtual ICollection<AdminUser> AdminUsers { get; set; } = new List<AdminUser>();

       

        // public int? AdminUserId { get; set; }


        // public virtual AdminUser AdminUsers { get; set; }


        //public int CountryId { get; set; }//c

        //public virtual ICollection<Country> Countries { get; set; } = new List<Country>();//c

        //public int StateId { get; set; }//c

        //public virtual ICollection<State> States { get; set; } = new List<State>();//c

        //public int CityId { get; set; }//c

        //public virtual ICollection<City> Cities { get; set; } = new List<City>();//c

        public int CountryId { get; set; }

        public Country? Country { get; set; }

        public int StateId { get; set; }
        public State? State { get; set; }
      
        public int CityId { get; set; }

        public City? City { get; set; }

    }
}
