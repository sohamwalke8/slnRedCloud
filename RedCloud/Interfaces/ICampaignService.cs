using RedCloud.Application.Features.RedCloudAdmins.Commands.CreateRedCloudAdmin;
using RedCloud.Application.Features.ResellerAdminuser.Queries;
using RedCloud.ViewModel;

namespace RedCloud.Interfaces
{
    public interface ICampaignService
    {

        Task<IEnumerable<CampaignVM>> GetallCampaign();


        Task SoftDeleteCampaign(int id);


    }
}
