using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
using RedCloud.Domain.Entities;
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
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ReSellerAdminVM, ResellerAdmin >().ReverseMap();
            CreateMap<Country, CountryListVM>().ReverseMap();
            CreateMap<CityListVM, City>().ReverseMap();

        }
    }

}
