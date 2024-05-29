using System.ComponentModel.DataAnnotations;

namespace RedCloud.Models
{
    public class CountryVM
    {

        [Required(ErrorMessage = "Please Select Reseller Name")]
        public int CountryId { get; set; }


        [Required(ErrorMessage = "Please Select  Name")]
        public string Name { get; set; }    

        public virtual ICollection<StateVM> States { get; set; }=new List<StateVM>();

    }
}
