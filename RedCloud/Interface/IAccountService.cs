using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Protocol.Plugins;
using RedCloud.Domain.Comman;

namespace RedCloud.Interface
{
    public interface IAccountService
    {
        Task<UserVM> Login(Models.Account.Login login);

        //Task<Register> Register(Register register);

    }
}
