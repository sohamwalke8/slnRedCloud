using Microsoft.AspNetCore.Mvc;
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
        private readonly IApiClient<AdminUser> _adminuser;

        public AdminResellerService(IApiClient<ResellerAdminVM> client, ILogger<AdminResellerService> logger, IApiClient<AdminUser> adminuser)//first one is entity and is service
        {
            _client = client;
            _logger = logger;
            _adminuser = adminuser;
        }
        public async Task<int> CreateAdminResellerAsync(ResellerAdmin ResellerAdmin)
        {
            //_logger.LogInformation("CreateCategory Service initiated");
             var users = await _client.PostAsync("ReSellerAdmin", ResellerAdmin);//add api link and entity 
          
            //_logger.LogInformation("CreateCategory Service conpleted");
            return users.Data;
        }
        public async Task UpdateAdminReseller(ResellerAdmin ResellerAdmin)
        {

            var users = _client.PutAsync("ReSellerAdmin/UpdateResellerAdmin", ResellerAdmin);//
            //return users.Data;

        }

        public async Task<ResellerAdminVM> GetResellerAdminById(int eventId)
        {
            // _logger.LogInformation("GetEventById Service initiated");
            var Events = await _client.GetByIdAsync("ResellerAdmin/" + eventId);
            //_logger.LogInformation("GetEventById Service conpleted");
            return Events.Data;
        }


        //[HttpGet]
        //public async Task<IEnumerable<AdminUser>> GetallResellerAdmin()
        //{
        //    _logger.LogInformation("GetAllRedCloudAdmin Service initiated");
        //    var reSelleradmin = await _client.GetAllAsync("");//add api link hehe
        //    _logger.LogInformation("GetAllRedCloudAdmin Service conpleted");
        //    return reSelleradmin.Data;
        //}

        [HttpGet]
        public async Task<IEnumerable<AdminUser>> GetallResellerAdmin()
        {
            _logger.LogInformation("GetAllRedCloudAdmin Service initiated");
            var reSelleradmin = await _adminuser.GetAllAsync("AdminUser/all");//add api link hehe
            _logger.LogInformation("GetAllRedCloudAdmin Service conpleted");
            return reSelleradmin.Data;
        }
    }
}
