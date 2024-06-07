using Microsoft.Extensions.Logging;
using MvcApiCallingService.Helpers.ApiHelper;
using Newtonsoft.Json;
using RedCloud.Application.Features.Rates.Queries;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.Application.Helper;
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

        //public async Task<RateDetailVM> GetRateByEncryptedId(string encryptedId)
        //{
        //    // Decrypt the encrypted ID
        //    //var decryptedId = EncryptionDecryption.DecryptString(encryptedId);

        //    //// Convert the decrypted ID to the appropriate type (e.g., int)
        //    //if (!int.TryParse(decryptedId, out int id))
        //    //{
        //    //    throw new ArgumentException("Invalid ID format");
        //    //}

        //    // Fetch data using the decrypted ID
        //    var rate = await _client.EncryptGetByIdAsync("Rate/" + encryptedId);

        //    return rate.Data;
        //}






        public async Task<bool> SoftDeleteById(int id)
        {
            var response = await _rate.DeleteAsync("Rate/" + id);
            return !string.IsNullOrEmpty(response);
        }
    }



}
