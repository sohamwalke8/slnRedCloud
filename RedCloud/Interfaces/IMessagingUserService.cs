using RedCloud.Application.Features.MessagingUsers.Queries;
using RedCloud.ViewModel;

namespace RedCloud.Interfaces
{
    public interface IMessagingUserService
    {
        Task<IEnumerable<MessagingUsersVM>> GetAllMessagingUsers();
     
        Task<MessagingUsersVM> GetMessagingUserById(int id);
        Task<MessagingUsersVM> BlockMessagingUser(int Id);
    }
}
