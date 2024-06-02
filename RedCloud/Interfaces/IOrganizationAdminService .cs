using RedCloud.Application.Features.OrganizationAdmins.Queries;

namespace RedCloud.Interfaces
{
    public interface IOrganizationAdminService
    {
        Task<int> CreateOrganizationAdmin(OrganizationAdminVM organizationAdmin);

        Task EditOrganizationAdmin(OrganizationAdminVM organizationAdmin);

        Task<OrganizationAdminVM> GetOrganizationAdminById(int eventId);
    }
}
