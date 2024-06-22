using System.ComponentModel.DataAnnotations;

namespace RedCloud.ViewModel
{
    public class TemplateVM
    {
        public int TemplateId { get; set; }

        [Required(ErrorMessage = "Please enter template name")]
        public string TemplateName { get; set; }

        [Required(ErrorMessage = "Please enter message type")]

        public string MessageType { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Details")]

        public string TemplatePersonalization { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Details")]

        public string MessageBody { get; set; }

        [Required(ErrorMessage = "Please enter valid URL")]
        [RegularExpression(@"^(www\.)?[a-zA-Z0-9-]+\.[a-zA-Z]{2,}\.com\/?$", ErrorMessage = "Please Enter Valid Details")]
        public string TemplateURL { get; set; }

        public int SessionId {  get; set; }
    }
}
