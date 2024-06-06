using RedCloud.Application.Features.Campaign;

namespace RedCloud.Interfaces
{
    public interface ICampaign<T>
    {
        Task<IEnumerable<CampaignVM>> GetallCampaignlist();
    }
}
