using RedCloud.Domain.Entities;
using RedCloud.ModelVM;

namespace RedCloud.Interface
{
    public interface IOrganizationAdminService
    {
        Task<int> CreateOrganizationAdmin(OrganizationAdminVM organizationAdmin);

        Task EditOrganizationAdmin(OrganizationAdminVM organizationAdmin);

        Task<OrganizationAdminVM> GetOrganizationAdminById (int eventId);
    }
}
