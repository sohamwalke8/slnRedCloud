using Microsoft.AspNetCore.Mvc;
using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Application.Features.RedCloudAdmins.Commands.CreateRedCloudAdmin;
using RedCloud.Domain.Entities;
using RedCloud.Interfaces;

namespace RedCloud.Services
{
    public class RedCloudAdminService : IRedCloudAdminService
    {

        private readonly IApiClient<RedCloudAdminVM> _client;
        public readonly ILogger<RedCloudAdminService> _logger;

        public RedCloudAdminService(IApiClient<RedCloudAdminVM> client, ILogger<RedCloudAdminService> logger)
        {
            _client = client;
            _logger = logger;
        }

        //public async Task<int> CreateAdminUser(RedCloudAdmin adminUser)
        //{
        //    //_logger.LogInformation("CreateCategory Service initiated");
        //    var users = await _client.PostAsync("AdminUser/AddAdminUser", adminUser);
        //    //_logger.LogInformation("CreateCategory Service conpleted");
        //    return users.Data;
        //}


        [HttpPost]
        public async Task EditAdminUser(RedCloudAdmin adminUser)
        {
            var users = _client.PutAsync("AdminUser/EditAdminUser", adminUser);
            //not returning anything here.
            //return users.Data;  
        }



        public async Task<RedCloudAdminVM> GetAdminUserById(int Id)
        {
            // _logger.LogInformation("GetEventById Service initiated");
            var Events = await _client.GetByIdAsync($"AdminUser/{Id}");
            //_logger.LogInformation("GetEventById Service conpleted");
            return Events.Data;
        }

        public async Task<int> CreateAdminUser(RedCloudAdmin adminUser)
        {
            //changed return type to int
            //_logger.LogInformation("CreateCategory Service initiated");
            var users = await _client.PostAsync("RedCloudAdmin/AddAdminUser", adminUser);
            //_logger.LogInformation("CreateCategory Service conpleted");
           // return a;
            return users.Data;


        }
    }
}
