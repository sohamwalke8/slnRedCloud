using RedCloud.Domain.Entities;
using RedCloud.ViewModel;

namespace RedCloud.Interfaces
{
	public interface IResellerAssignCreditService
	{
		Task<IEnumerable<OrganizationAdmin>> GetOrganizationAdminList();
		Task<IEnumerable<CreditsType>> GetCreditsTypeList();
		Task<int> AddRate(RateAssignCreditVM model);
		Task<RateAssignCreditVM> EditRate(RateAssignCreditVM model);
		Task<RateAssignCreditVM> GetRateById(int Id);
    }
}
