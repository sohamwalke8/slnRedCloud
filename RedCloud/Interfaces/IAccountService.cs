using Microsoft.Win32;
using MvcApiCallingService.Models.Responses;
using RedCloud.Application.Features.Account.Queries.LoginQuery;
using RedCloud.Domain.Common;

namespace RedCloud.Interfaces
{
    public interface IAccountService
    {
        Task<Response<UserVM>> Login(LoginVM login);

        //Task<Register> Register(Register register);
        //Task<LoginResponse> Login(Login login);
        //Task<Register> Register(Register register);


    }
}
