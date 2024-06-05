using Microsoft.Extensions.Logging;
using MvcApiCallingService.Helpers.ApiHelper;
using Newtonsoft.Json;
using RedCloud.Application.Features.Rates.Queries;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Domain.Entities;
using RedCloud.Interfaces;

namespace RedCloud.Services
{
    public class RateServices : IRate
    {

        private readonly IApiClient<Rate> _rate;
        private readonly IApiClient<GetRate> _rateuser;
        private readonly IApiClient<RateDetailVM> _client;

        public RateServices(IApiClient<Rate> rate, IApiClient<GetRate> rateuser, IApiClient<RateDetailVM> client)
        {
            _client = client;
            _rate = rate;
            _rateuser = rateuser;
        }
        public async Task<IEnumerable<GetRate>> GetallRate()
        {

            var ratr = await _rateuser.GetAllAsync("Rate");

            return ratr.Data;
        }

        public async Task<RateDetailVM> GetRateId(int id)
        {
            var rate = await _client.GetByIdAsync("Rate/" + id);
            return rate.Data;
        }

        public async Task<bool> SoftDeleteById(int id)
        {
            var response = await _rate.DeleteAsync("Rate/" + id);
            return !string.IsNullOrEmpty(response);
        }
    }



}
