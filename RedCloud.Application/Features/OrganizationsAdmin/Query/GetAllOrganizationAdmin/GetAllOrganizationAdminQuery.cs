using MediatR;
using RedCloud.Application.Features.OrganizationsAdmin.Query.GetAllOrganizationAdmin;
using RedCloud.Application.Responses;


namespace RedCloud.Application.Features.OrganizationsAdmin.Query
{
    public class GetAllOrganizationAdminQuery : IRequest<Response<IEnumerable<GetAllOrganizationAdminVM>>>
    {


    }


}
