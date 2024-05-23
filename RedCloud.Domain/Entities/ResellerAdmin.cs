using System.ComponentModel.DataAnnotations;

namespace RedCloud.Domain.Entities
{
    public class ResellerAdmin
    {
        [Key]
        public int Id { get; set; }
        public string ResellerName { get; set; }
        public string EIN { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string CompanyURL { get; set; }
        public string CompanySupportEmail { get; set; }
        public string RedCloudAdmin { get; set; }

        public string? Password { get; set; }

        public bool IsActive { get; set; } = true;

        public int? OrgID { get; set; }

        public virtual OrganizationAdmin OrganizationAdmins { get; set; }
    }
}
