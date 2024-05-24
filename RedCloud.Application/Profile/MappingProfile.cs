using AutoMapper;
using RedCloud.Application.Features.AdminUsers.Command;
using RedCloud.Application.Features.OrganizationsAdmin.Command;
using RedCloud.Application.Features.ResellerAdmins.Command;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace RedCloud.Application.profile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateAdminUserCommand, AdminUser>();
            CreateMap<EditAdminUserCommand, AdminUser>();
            CreateMap<CreateOrganizationAdmin, OrganizationAdmin>();
            CreateMap<UpdateOrganizationAdmin, OrganizationAdmin>();
            CreateMap<UpdateOrganizationAdmin, ResellerAdmin>();

            CreateMap<CreateResellerAdminCommand, ResellerAdmin>();
            CreateMap<UpdateResellerAdminCommand, ResellerAdmin>();

        }
    }
}
