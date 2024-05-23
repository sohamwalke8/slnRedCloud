using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Protocol.Plugins;
using RedCloud.Domain.Comman;
using RedCloud.Models.Account;

namespace RedCloud.Interface
{
    public interface IAccountService
    {
        Task<UserVM> Login(LoginVM login);

        //Task<Register> Register(Register register);

    }
}
