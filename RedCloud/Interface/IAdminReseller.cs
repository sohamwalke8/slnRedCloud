using RedCloud.Domain.Entities;
using RedCloud.Models;

namespace RedCloud.Interface
{
    public interface IAdminReseller
    {
        Task<int> CreateAdminResellerAsync(ResellerAdmin ResellerAdmin);

        Task UpdateAdminReseller(ResellerAdmin ResellerAdmin);


        Task<ResellerAdminVM> GetResellerAdminById(int eventId);

        Task<IEnumerable<AdminUser>> GetallResellerAdmin();
    }
}
