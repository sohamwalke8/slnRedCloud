using MvcApiCallingService.Helpers.ApiHelper;
using RedCloud.Application.Features.Numbers.Commands;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Domain.Entities;
using RedCloud.Interfaces;
using RedCloud.ViewModel;

namespace RedCloud.Services
{
    public class NumberService <T> : INumberService<T> where T : class
    {

        private readonly IApiClient<NumberVM> _client;
        private readonly IApiClient<AssignNumberViewModel> _clientassign;
        public readonly ILogger<NumberService<T>> _logger;


        public NumberService(IApiClient<NumberVM> client, ILogger<NumberService<T>> logger, IApiClient<AssignNumberViewModel> clientassign)
        {
            _client = client;
            _logger = logger;
            _clientassign = clientassign;
        }
       
        public  async Task<int> AddNumber(NumberVM numberVM)
        {
            var users = await _client.PostAsync("Number/AddNumber", numberVM);
           
            return users.Data;
        }

     
        public async Task<AssignNumberViewModel> GetNumberById(int eventId)
        {
            // _logger.LogInformation("GetEventById Service initiated");
            var Events = await _clientassign.GetByIdAsync("Number/" + eventId);
            //_logger.LogInformation("GetEventById Service conpleted");
            return Events.Data;
        }

        public async Task UpdateNumber(AssignNumberViewModel assignNumberViewModel )
        {
            var id = assignNumberViewModel.NumberId;
            await _client.PutAsync($"Number/UpdateNumbers/{id}", assignNumberViewModel);
            //return users.Data;
        }
    }
}
