using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Services
{
    public class OrganizationAdminService : IOrganizationAdminService
    {
        private readonly IApiClient<OrganizationAdminVM> _client;
        public readonly ILogger<OrganizationAdminService> _logger;


        public OrganizationAdminService(IApiClient<OrganizationAdminVM> client, ILogger<OrganizationAdminService> logger)
        {
            _client = client;
            _logger = logger;
        }
        public async Task<int> CreateOrganizationAdmin(OrganizationAdminVM organizationAdmin)
        {
            //_logger.LogInformation("CreateCategory Service initiated");
            var users = await _client.PostAsync("OrganizationAdmin/AddOrganizationAdmin", organizationAdmin);
            //_logger.LogInformation("CreateCategory Service conpleted");
            return users.Data;
        }

        public async Task EditOrganizationAdmin(OrganizationAdminVM organizationAdmin)
        {

            var users = _client.PutAsync("OrganizationAdmin/UpdateOrganizationAdmin", organizationAdmin);
            //return users.Data;

        }

        public async Task<OrganizationAdminVM> GetOrganizationAdminById(int eventId)
        {
            // _logger.LogInformation("GetEventById Service initiated");
            var Events = await _client.GetByIdAsync("OrganizationAdmin/" + eventId);
            //_logger.LogInformation("GetEventById Service conpleted");
            return Events.Data;
        }

        public async  Task<IEnumerable<OrganizationAdminVM>> GetAllOrganizationAdmin()
        {
            // _logger.LogInformation("GetAllOrganizationAdmin Service initiated");
            var OrganizationAdmin = await _client.GetAllAsync("OrganizationAdmin/GetAll");
            //_logger.LogInformation("GetAllCategories Service conpleted");
            return OrganizationAdmin.Data;
        }
    }
    }

