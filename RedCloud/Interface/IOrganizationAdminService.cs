using RedCloud.ModelVM;

namespace RedCloud.Interface
{

    public interface IOrganizationAdminService
    {
        Task<IEnumerable<AllOrganizationAdminVM>> GetAllOrganizationAdmin();
        Task SoftDeleteOrganizationAdmin(int id);
        Task<AllOrganizationAdminVM> GetOrganizationAdminDetailesById(int id);
        Task<AllOrganizationAdminVM> BlockOrganizationAdmin(int Id);

    }

}
