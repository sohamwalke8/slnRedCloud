using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Domain.Entities;
using RedCloud.Interface;
using RedCloud.Models;
using RedCloud.ModelVM;

namespace RedCloud.Services
{
    public class AdminResellerService : IAdminReseller
    {

        private readonly IApiClient<ResellerAdminVM> _client;//name of Entity or viewmodel
        public readonly ILogger<AdminResellerService> _logger;//add service name

        public AdminResellerService(IApiClient<ResellerAdminVM> client, ILogger<AdminResellerService> logger)//first one is entity and is service
        {
            _client = client;
            _logger = logger;
        }
        public async Task<int> CreateAdminResellerAsync(ResellerAdmin ResellerAdmin)
        {
            //_logger.LogInformation("CreateCategory Service initiated");
            var users = await _client.PostAsync("ResellerAdmin", ResellerAdmin);//add api link and entity
            //_logger.LogInformation("CreateCategory Service conpleted");
            return users.Data;
        }
        public async Task UpdateAdminReseller(ResellerAdmin ResellerAdmin)
        {

            var users = _client.PutAsync("ResellerAdmin/UpdateResellerAdmin", ResellerAdmin);//
            //return users.Data;

        }

        public async Task<ResellerAdminVM> GetResellerAdminById(int eventId)
        {
            // _logger.LogInformation("GetEventById Service initiated");
            var Events = await _client.GetByIdAsync("ResellerAdmin/" + eventId);
            //_logger.LogInformation("GetEventById Service conpleted");
            return Events.Data;
        }
    }
}
