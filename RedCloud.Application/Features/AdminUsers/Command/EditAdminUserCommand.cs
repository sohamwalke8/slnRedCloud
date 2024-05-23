using MediatR;
using RedCloud.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.AdminUsers.Command
{
    public class EditAdminUserCommand : IRequest<BaseResponse<Unit>>
    {
        public int ID { get; set; }
        //[Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Please enter a valid email address")]
        //[EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Please enter mobile number")]
        public int MobileNumber { get; set; }

        public bool IsActive { get; set; }
    }
}
