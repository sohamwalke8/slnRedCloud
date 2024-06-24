using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Domain.Common;
using RedCloud.Domain.Entities;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Services
{
	public class ResellerAssignCreditService : IResellerAssignCreditService
	{
		private readonly IApiClient<OrganizationAdmin> _apiClientOrganizationAdmin;
		private readonly IApiClient<CreditsType> _apiClientCreditsType;
		private readonly IApiClient<RateAssignCreditVM> _apiClientRateAssignCredit;
		private readonly IApiClient<GetAllAssignCredit> _apiClientGetAllAssignCredit;

        public ResellerAssignCreditService(IApiClient<OrganizationAdmin> apiClientOrganizationAdmin, IApiClient<CreditsType> apiClientCreditsType, IApiClient<RateAssignCreditVM> apiClientRateAssignCredit, IApiClient<GetAllAssignCredit> apiClientGetAllAssignCredit)
        {
            _apiClientOrganizationAdmin = apiClientOrganizationAdmin;
            _apiClientCreditsType = apiClientCreditsType;
			_apiClientRateAssignCredit = apiClientRateAssignCredit;
            _apiClientGetAllAssignCredit = apiClientGetAllAssignCredit;
        }

        public async Task<IEnumerable<GetAllAssignCredit>> GetAllAssignCredit()
        {
            //_logger.LogInformation("GetAllCountry Service initiated");
            var result = await _apiClientGetAllAssignCredit.GetAllAsync("ResellerAssignCredit/GetAllAssignCredit");
            //_logger.LogInformation("GetAllCountry Service conpleted");
            return result.Data;
        }

        public async Task<IEnumerable<OrganizationAdmin>> GetOrganizationAdminList()
		{
			//_logger.LogInformation("GetAllCountry Service initiated");
			var result = await _apiClientOrganizationAdmin.GetAllAsync("ResellerAssignCredit/GetOrganizationList");
			//_logger.LogInformation("GetAllCountry Service conpleted");
			return result.Data;
		}
		public async Task<IEnumerable<CreditsType>> GetCreditsTypeList()
		{
			//_logger.LogInformation("GetAllCountry Service initiated");
			var result = await _apiClientCreditsType.GetAllAsync("ResellerAssignCredit/GetCreditList");
			//_logger.LogInformation("GetAllCountry Service conpleted");
			return result.Data;
		}
        public async Task<int> AddRate(RateAssignCreditVM model)
        {
            var users = await _apiClientRateAssignCredit.PostAsync("ResellerAssignCredit/AddRate", model);
            return users.Data;
        }
        public async Task<RateAssignCreditVM> GetRateById(int Id)
        {
            var rate = await _apiClientRateAssignCredit.GetByIdAsync("ResellerAssignCredit/GetRateById/"+Id);
            return rate.Data;
        }

        public async Task<RateAssignCreditVM> EditRate(RateAssignCreditVM model)
        {
            var users = await _apiClientRateAssignCredit.PutAsync("ResellerAssignCredit/EditRate", model);
            return users.Data;
        }
    }
}
