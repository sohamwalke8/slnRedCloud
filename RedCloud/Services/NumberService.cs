using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Services
{
    public class NumberService <T> : INumberService<T> where T : class
    {

        private readonly IApiClient<NumberVM> _client;
        public readonly ILogger<NumberService<T>> _logger;


        public NumberService(IApiClient<NumberVM> client, ILogger<NumberService<T>> logger)
        {
            _client = client;
            _logger = logger;
        }
       
        public  async Task<int> AddNumber(NumberVM numberVM)
        {
            var users = await _client.PostAsync("Number/AddNumber", numberVM);
           
            return users.Data;
        }
    }
}
