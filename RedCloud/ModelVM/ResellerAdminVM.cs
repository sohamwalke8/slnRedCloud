namespace RedCloud.Models
{
    public class ResellerAdminVM
    {
        public int Id { get; set; } 
        public string ReSellerName { get; set; }
        public string EIN  { get; set; }
        public string CompanySupportEmail { get; set;}
        public bool IsActive { get; set;}
        public bool IsDeleted { get; set; }

     }
}
