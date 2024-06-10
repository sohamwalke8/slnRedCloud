using AutoMapper;
using RedCloud.Application.Features.AssignmentType;
using RedCloud.Application.Features.Campaign;
using RedCloud.Application.Features.Carrierss;
using RedCloud.Application.Features.Categories.Commands.CreateCateogry;
using RedCloud.Application.Features.Categories.Commands.StoredProcedure;
using RedCloud.Application.Features.Cities.Queries;
using RedCloud.Application.Features.Countries;
using RedCloud.Application.Features.Events.Queries.GetEventDetail;
using RedCloud.Application.Features.Numbers.Commands;
using RedCloud.Application.Features.Numbers.Queries;
using RedCloud.Application.Features.OrganizationAdmins.Commands;
using RedCloud.Application.Features.OrganizationAdmins.Queries;
using RedCloud.Application.Features.RedCloudAdmins.Commands.CreateRedCloudAdmin;
using RedCloud.Application.Features.ResellerAdminuser.Commands;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Application.Features.Types;
using RedCloud.Domain.Entities;
using RedCloud.ViewModel;
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
            // CreateMap<ResellerAdminUser,ReSellerAdmindto>().ReverseMap();
            //

            CreateMap<CreateOrganizationAdminCommand, OrganizationAdmin>();
            CreateMap<UpdateOrganizationAdminCommand, OrganizationAdmin>();
            CreateMap<OrganizationAdmin, GetAllOrganizationAdminVM>();

            //For Numbers
            CreateMap<AddNumberCommand, Domain.Entities.Number>();
            CreateMap<Types, TypesVM>();
            CreateMap<Carrier, CarrierVM>();
            CreateMap<AssignmentType, AssignmentTypeVM>();
            CreateMap<Domain.Entities.Number, AssignNumberViewModel>();
            CreateMap<AssignNumberCommand, Domain.Entities.Number>();
            CreateMap<Campaign, CampaignVM>();
            CreateMap<ViewAssignedNumberVM, AssignNumberViewModel>();
            CreateMap<RedCloud.Domain.Entities.Number, RedCloud.Application.Features.Numbers.Queries.ViewAssignedNumberVM>();
            //CreateMap<RedCloud.Domain.Entities.Number, NumberlistVM>();

            CreateMap<RedCloud.Domain.Entities.Number, NumberlistVM>()
            .ForMember(dest => dest.CarrierName, opt => opt.MapFrom(src => src.Carrier.CarrierName))
            .ForMember(dest => dest.OrgName, opt => opt.MapFrom(src => src.OrganizationAdmin.OrgName));


        }

    }
}