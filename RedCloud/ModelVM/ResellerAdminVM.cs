using Microsoft.Identity.Client;

namespace RedCloud.Models
{
    public class ResellerAdminVM
    {
        public int Id { get; set; } 
        public string ReSellerName { get; set; }
        public string EIN  { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public  string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string CompanyURL { get; set; }
        public string CompanySupportEmail { get; set;}
        public string RedCloudAdmin { get; set; }
        public bool IsActive { get; set;}
        public bool IsDeleted { get; set; }

     }
}
