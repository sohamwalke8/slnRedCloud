using System.ComponentModel.DataAnnotations;

namespace RedCloud.ModelVM
{
    public class OrganizationAdminVM
    {
        
        public int OrgID { get; set; }

        [Required(ErrorMessage = "Please Enter Organization Name")]
        public string OrgName { get; set; }

        [Required(ErrorMessage = "Please Enter Admin Name Number")]
        public string OrgAdminName { get; set; }

        [Required(ErrorMessage = "Please Enter a Valid Email Address")]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$")]
        public string OrgAdminEmail { get; set; }


        [Required(ErrorMessage = "Please enter valid details")]
        public string? OrgAdminPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Please enter mobile number")]
        public string OrgAdminMobNo { get; set; }

        [Required(ErrorMessage = "Please enter Address Line One")]
        public string AddressLineOne { get; set; }

        [Required(ErrorMessage = "Please enter Address Line Two")]
        public string AddressLineTwo { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Select State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter Zip Code")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter Org URL")]
        public string OrgURL { get; set; }

        [Required(ErrorMessage = "Please Select Reseller Admin")]
        public string ResellerName { get; set; } = "Test";

    }
}
