using RedCloud.ViewModel;

namespace RedCloud.Interfaces
{
    public interface INumberService<T>
    {

        Task<int> AddNumber(NumberVM numberVM);
    }
}
