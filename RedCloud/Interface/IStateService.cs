using RedCloud.Models;

namespace RedCloud.Interface
{
    public interface IStateService<T> 
    {
        Task<IEnumerable<StateVM>> GetStatesByCountryId(int id);
    }
}
