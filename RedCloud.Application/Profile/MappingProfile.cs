using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RedCloud.Application.Features.CountryFolder.Query.GetCountryList;
using RedCloud.Application.Features.CountryFolder.Query.GetCityList;

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
        }
    }

}
