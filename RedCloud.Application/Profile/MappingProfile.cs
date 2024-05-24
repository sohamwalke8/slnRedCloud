using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
using RedCloud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace RedCloud.Application.profile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ReSellerAdminVM, ResellerAdmin >().ReverseMap();

        }
    }

}
