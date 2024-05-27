using RedCloud.Application.Features.CountryFolder.Query.GetCountryList;
using RedCloud.Models;

namespace RedCloud.Interface
{
    public interface IDropDownService<T>
    {

        Task<IEnumerable<CountryVM>> GetAllCountryList();
    }
}
