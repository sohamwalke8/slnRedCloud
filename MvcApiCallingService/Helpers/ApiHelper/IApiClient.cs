using Azure;
using MvcApiCallingService.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApiCallingService.Helpers.ApiHelper
{
    public interface IApiClient<T>
    {

        Task<MvcApiCallingService.Response.Response<IEnumerable<T>>> GetAllAsync(string apiUrl);
        Task<MvcApiCallingService.Response.Response<List<T>>> GetListByIdAsync(string apiUrl);
        Task<PagedResponse<IEnumerable<T>>> GetPagedAsync(string apiUrl);
        Task<MvcApiCallingService.Response.Response<T>> GetByIdAsync(string apiUrl);
        Task<MvcApiCallingService.Response.Response<int>> PostAsync<TEntity>(string apiUrl, TEntity entity);
        // for Account
        Task<T> PostAuthAsync<TEntity>(string apiUrl, TEntity entity);
        Task<MvcApiCallingService.Response.Response<T>> PutAsync<TEntity>(string apiUrl, TEntity entity);
        Task<string> DeleteAsync(string apiUrl);
    }
}
