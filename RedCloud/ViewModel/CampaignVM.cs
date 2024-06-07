using System.ComponentModel.DataAnnotations;

namespace RedCloud.ViewModel
{
    public class CampaignVM
    {
        public int CampaignId { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Universal EIN is required")]
       // [RegularExpression(@"^\d{9}$", ErrorMessage = "Universal EIN must be a 9-digit number")]
        public int UniversalEIN { get; set; }

        [Required(ErrorMessage = "Brand ID is required")]
        public int BrandId { get; set; }

        public bool IsActive { get; set; } = true;


    }
}
