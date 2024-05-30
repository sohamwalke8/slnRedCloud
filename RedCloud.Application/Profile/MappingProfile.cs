using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RedCloud.Application.Features.CountryFolder.Query.GetCountryList;
using RedCloud.Application.Features.CountryFolder.Query.GetCityList;
using RedCloud.Application.Features.AdminUsers.Command;
using RedCloud.Application.Features.OrganizationsAdmin.Command;
using RedCloud.Domain.Entities;
using RedCloud.Application.Features.ResellerAdmins.Command;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
using RedCloud.Models;

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
            CreateMap<ReSellerAdminVM, ResellerAdmin>().ReverseMap();
            CreateMap<Country, CountryListVM>().ReverseMap();
            CreateMap<CityListVM, City>().ReverseMap();
            CreateMap<StateVM, State>().ReverseMap();
           CreateMap<RedCloudUserVM, AdminUser>().ReverseMap();
        }
    }

}