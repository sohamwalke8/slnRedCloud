using RedCloud.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace RedCloud.ModelVM
{
    public class OrganizationAdminVM
    {
        
        public int OrgID { get; set; }

        [Required(ErrorMessage = "Please Enter Organization Name")]
        public string OrgName { get; set; }

        [Required(ErrorMessage = "Please Enter EIN Number")]
        public string EIN { get; set; }


        [Required(ErrorMessage = "Please Enter Admin Name Number")]
        public string OrgAdminName { get; set; }

        [Required(ErrorMessage = "Please Enter  Valid Email Address")]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$",ErrorMessage ="Please Enter Valid Details")]
        public string OrgAdminEmail { get; set; }


        //[Required(ErrorMessage = "Please Enter Valid Details")]
        //public string? OrgAdminPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please Enter Valid Details")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please Enter Valid Details")]
        public string OrgAdminMobNo { get; set; }

        [Required(ErrorMessage = "Please Enter Address Line One")]
        public string AddressLineOne { get; set; }

        [Required(ErrorMessage = "Please Enter Address Line Two")]
        public string AddressLineTwo { get; set; }


        [Required(ErrorMessage = "Please Enter Zip Code")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Please Enter Org URL")]
        public string OrgURL { get; set; }

        [Required(ErrorMessage = "Please Select Reseller Name")]
        public string ResellerName { get; set; } = "Test";

        public int Id { get; set; }

        public int CountryId { get; set; }

        public int StateId { get; set; }


        public int? CityId { get; set; }



    }
}
