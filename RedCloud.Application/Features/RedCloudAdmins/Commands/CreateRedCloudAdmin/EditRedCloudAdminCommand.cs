﻿using MediatR;
using RedCloud.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Features.RedCloudAdmins.Commands.CreateRedCloudAdmin
{
    public class EditRedCloudAdminCommand : IRequest<Response<Unit>>
    {
        public int RedCloudAdminUserId { get; set; }
        //[Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Please enter a valId email address")]
        //[EmailAddress(ErrorMessage = "Please enter a valId email address")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Please enter mobile number")]
        public string MobileNumber { get; set; }

        public string? Password { get; set; }

        public bool IsActive { get; set; }
    }
}