using RedCloud.Models;

namespace RedCloud.Interface
{
    public interface ICityService<T>
    {
        Task<IEnumerable<CityVM>> GetCityByStateId(int id);
    }
}
