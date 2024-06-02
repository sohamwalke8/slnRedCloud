using AutoMapper;
using RedCloud.Application.Features.OrganizationsAdmin.Command;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RedCloud.Application.Features.CountryFolder.Query.GetCountryList;
using RedCloud.Application.Features.CountryFolder.Query.GetCityList;
using RedCloud.Models;
using RedCloud.ModelVM;
using RedCloud.Application.Features.OrganizationsAdmin.Query.GetOrganizationAdminById;
using RedCloud.Application.Features.OrganizationsAdmin.Query.GetAllOrganizationAdmin;

namespace RedCloud.Application.profile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {   
            CreateMap<OrganizationAdmin, OrganizationAdminVM>().ReverseMap();
            CreateMap<OrganizationAdmin,OrganizationAdminDetailsVM > ().ReverseMap();
            CreateMap<OrganizationAdmin,GetAllOrganizationAdminVM>().ReverseMap();
            CreateMap<Country, CountryListVM>().ReverseMap();
            CreateMap<State, StateVM>().ReverseMap();
            CreateMap<CityListVM, City>().ReverseMap();

        }
    }
}
