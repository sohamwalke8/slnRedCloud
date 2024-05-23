using AutoMapper;
using RedCloud.Application.Features.OrganizationsAdmin.Command;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.profile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateOrganizationAdmin, OrganizationAdmin>();
            CreateMap<UpdateOrganizationAdmin, OrganizationAdmin>();
            CreateMap<UpdateOrganizationAdmin, ResellerAdmin>();

        }
    }
}
