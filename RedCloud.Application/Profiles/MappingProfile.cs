﻿using AutoMapper;
using RedCloud.Application.Features.Categories.Commands.CreateCateogry;
using RedCloud.Application.Features.Categories.Commands.StoredProcedure;
using RedCloud.Application.Features.Cities.Queries;
using RedCloud.Application.Features.Countries;
using RedCloud.Application.Features.Events.Queries.GetEventDetail;
using RedCloud.Application.Features.OrganizationAdmins.Commands;
using RedCloud.Application.Features.RedCloudAdmins.Commands.CreateRedCloudAdmin;
using RedCloud.Application.Features.ResellerAdminuser.Commands;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RedCloud.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RedCloudAdmin, RedCloudAdminVM>();
            CreateMap<CreateRedCloudAdminCommand, RedCloudAdmin>();
            CreateMap<EditRedCloudAdminCommand, RedCloudAdmin>().ReverseMap();

            CreateMap<CreateResellerAdminUserCommand, ResellerAdminUser>();
            CreateMap<UpdateResellerAdminUserCommand, ResellerAdminUser>();
            CreateMap<ResellerAdminUserVM, ResellerAdminUser>().ReverseMap();


            //disha
            CreateMap<ResellerAdminUserVM, ResellerAdminUser>().ReverseMap();
            CreateMap<Country, CountryListVM>().ReverseMap();
            CreateMap<CityListVM, City>().ReverseMap();
            //

            CreateMap<CreateOrganizationAdminCommand, OrganizationAdmin>();
            CreateMap<UpdateOrganizationAdminCommand, OrganizationAdmin>();
        }
    }

}