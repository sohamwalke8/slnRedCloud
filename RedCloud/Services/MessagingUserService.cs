using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Services
{
    public class MessagingUserService : IMessagingUserService
    {

        private readonly IApiClient<MessagingUsersVM> _client;
        private readonly IApiClient<MessagingUsersVM> _clientTwo;
        public readonly ILogger<MessagingUserService> _logger;


        public MessagingUserService(IApiClient<MessagingUsersVM> client, IApiClient<MessagingUsersVM> clientTwo, ILogger<MessagingUserService> logger)
        {
            _client = client;
            _logger = logger;
            _clientTwo = clientTwo;

        }

        //AAkash
        public async Task<IEnumerable<MessagingUsersVM>> GetAllMessagingUsers()
        {
            // _logger.LogInformation("GetAllOrganizationAdmin Service initiated");
            var messagingUser = await _clientTwo.GetAllAsync("MessagingUser/GetAll");
            //_logger.LogInformation("GetAllCategories Service conpleted");
            return messagingUser.Data;
        }


        public async Task<MessagingUsersVM> GetMessagingUserById(int id)
        {
            //_logger.LogInformation($"GetOrganizationAdminDetailesById Service initiated for ID: {id}");
            var apiUrl = $"MessagingUser/GetDetailsById/{id}";     //apiurl=>controllername/id
            var response = await _clientTwo.GetByIdAsync(apiUrl);
            // _logger.LogInformation($"GetResellerAdminById Service completed for ID: {id}");
            return response.Data;
        }


        public async Task<MessagingUsersVM> BlockMessagingUser(int Id)
        {
            try
            {

                var apiUrl = $"MessagingUser/GetDetailsById/{Id}";
                var response = await _clientTwo.GetByIdAsync(apiUrl);
                var data = response.Data;
                //data.IsActive = false;
                apiUrl = $"MessagingUser/Block/{Id}";
                var updated = await _clientTwo.PutAsyncc(apiUrl, data);
                return updated.Data;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
