using Microsoft.Extensions.Logging;
using RedCloud.Application.Features.ReSellerAdmin.QueryHandler.GetAllResellerAdmin;
using RedCloud.Application.Responses;
using RedCloud.Controllers;
using RedCloud.Domain.Entities;
using RedCloud.Models;

namespace RedCloud.Interface
{
    public interface IReSellerAdminService
    {
        Task<IEnumerable<ResellerAdminVM>> GetallResellerAdmin();
        Task SoftDeleteResellerAdmin(int id);
        Task<ResellerAdminVM> GetResellerAdminById(int id);
        Task<ResellerAdminVM> Block(int Id);

    }
}
