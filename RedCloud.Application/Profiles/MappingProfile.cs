using AutoMapper;
using RedCloud.Application.Features.Campaigns.Commands;
using RedCloud.Application.Features.Campaigns.Queries;
using RedCloud.Application.Features.Categories.Commands.CreateCateogry;
using RedCloud.Application.Features.Categories.Commands.StoredProcedure;
using RedCloud.Application.Features.Cities.Queries;
using RedCloud.Application.Features.Countries;
using RedCloud.Application.Features.Events.Queries.GetEventDetail;
using RedCloud.Application.Features.OrganizationAdmins.Commands;
using RedCloud.Application.Features.OrganizationAdmins.Queries;
using RedCloud.Application.Features.OrganizationUsers.Commands;
using RedCloud.Application.Features.OrganizationUsers.Queries;
using RedCloud.Application.Features.RedCloudAdmins.Commands.CreateRedCloudAdmin;
using RedCloud.Application.Features.ResellerAdminuser.Commands;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Application.Features.ResellerUsers.Command;
using RedCloud.Application.Features.ResellerUsers.Queries;
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
            //Aakash
            CreateMap<OrganizationAdmin, OrganizationAdminVM>().ReverseMap();
            CreateMap<OrganizationAdmin, GetAllOrganizationAdminVM>().ReverseMap();

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

            CreateMap<GetAllCampaignQueries, CampaignVM>().ReverseMap();

            CreateMap<Campaign, CampaignVM>().ReverseMap();

            //A.G
            CreateMap<CreateCampaignCommand, Campaign>().ReverseMap();





            
            CreateMap<OrganizationUser, GetAllOrganizationUserVM>().ReverseMap();
            //CreateMap<OrganizationUser, CreateOrganizationUserCommand>().ReverseMap();
            CreateMap<CreateOrganizationUserCommand,OrganizationUser>().ReverseMap();
            CreateMap<UpdateOrganizationUserCommand, OrganizationUser>().ReverseMap();



            CreateMap<CreateResellerUserCommand, ResellerUser>().ReverseMap();
            CreateMap<ResellerUserVM, ResellerUser>().ReverseMap();
            CreateMap<UpdateResellerUserCommand, ResellerUser>().ReverseMap();
        }
    }

}