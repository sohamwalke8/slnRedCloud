using RedCloud.Application.Features.Rates.Queries;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Domain.Entities;

namespace RedCloud.Interfaces
{
    public interface IRate
    {
        Task<RateDetailVM> GetRateId(int id);
        //Task<RateDetailVM> GetRateByEncryptedId(string encryptedId);

        Task<IEnumerable<GetRate>> GetallRate();

        Task<bool> SoftDeleteById(int id);
    }
}
