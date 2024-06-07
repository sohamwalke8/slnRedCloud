using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Domain.Entities;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Services
{
    public class CampaignService : ICampaignService
    {
         private readonly IApiClient<CampaignVM> _client;//name of Entity or viewmodel
        public readonly ILogger<CampaignService> _logger;//add service name
        //private readonly IApiClient<RedCloudAdmin> _adminuser;
        private readonly IApiClient<CampaignVM> _campaign;


        public CampaignService(ILogger<CampaignService> logger, IApiClient<CampaignVM> campaign, IApiClient<CampaignVM> client)//first one is entity and is service
        {
             _client = client;
            _logger = logger;
            // _adminuser = adminuser;
            _campaign = campaign;
            _client = client;
        }





        public async Task<IEnumerable<CampaignVM>> GetallCampaign()//change  dto
        {
            _logger.LogInformation("GetAllCategories Service initiated");
            var reSelleradmin = await _campaign.GetAllAsync("Campaign/all");//add u r api link this get all Async is from api helper
            _logger.LogInformation("GetAllCategories Service completed");
            return reSelleradmin.Data;
        }

        public async  Task SoftDeleteCampaign(int id)//
        {
            _logger.LogInformation($"Soft delete initiated for Campaign with ID: {id}");

            await _client.DeleteAsync($"Campaign/{id}");//$"ResellerAdminUser/{id}") add u r link

            _logger.LogInformation($"Soft delete completed for Campaign with ID: {id}");

        }
    }
}
