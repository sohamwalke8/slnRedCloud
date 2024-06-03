using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Interface;
using RedCloud.Models;
using RedCloud.ModelVM;

namespace RedCloud.Service
{
    public class OrganizationAdminService : IOrganizationAdminService
    {

        private readonly IApiClient<AllOrganizationAdminVM> _client;
        private readonly ILogger<OrganizationAdminService> _logger;

        public OrganizationAdminService(ILogger<OrganizationAdminService> logger, IApiClient<AllOrganizationAdminVM> client)
        {
            _logger = logger;
            _client = client;
        }


        public async Task<IEnumerable<AllOrganizationAdminVM>> GetAllOrganizationAdmin()
        {
           // _logger.LogInformation("GetAllOrganizationAdmin Service initiated");
            var OrganizationAdmin = await _client.GetAllAsync("OrganizationAdmin/all");
            //_logger.LogInformation("GetAllCategories Service conpleted");
            return OrganizationAdmin.Data;
        }
        
        
        public async Task<AllOrganizationAdminVM> GetOrganizationAdminDetailesById(int id)
        {
            //_logger.LogInformation($"GetOrganizationAdminDetailesById Service initiated for ID: {id}");
            var apiUrl = $"OrganizationAdmin/{id}";     //apiurl=>controllername/id
            var response = await _client.GetByIdAsync(apiUrl);
           // _logger.LogInformation($"GetResellerAdminById Service completed for ID: {id}");
            return response.Data;
        }


        public async Task<AllOrganizationAdminVM> BlockOrganizationAdmin(int Id)
        {
            var apiUrl = $"OrganizationAdmin/{Id}";
            var response = await _client.GetByIdAsync(apiUrl);
            var data = response.Data;
            data.IsActive = false;
            var updated = await _client.PutAsyncc(apiUrl, data);
            return updated.Data;
        }

        

        public async Task SoftDeleteOrganizationAdmin(int id)
        {
           // _logger.LogInformation($"Soft delete initiated for ResellerAdmin with ID: {id}");

            await _client.DeleteAsync($"OrganizationAdmin/{id}");

            //_logger.LogInformation($"Soft delete completed for ResellerAdmin with ID: {id}");
        }
    }
}
