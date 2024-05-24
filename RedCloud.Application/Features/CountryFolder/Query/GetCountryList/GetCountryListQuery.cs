using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using RedCloud.Application.Responses;

namespace RedCloud.Application.Features.CountryFolder.Query.GetCountryList
{
    public class GetCountryListQuery:IRequest<Response<IEnumerable<CountryListVM>>>
    {
    }
}
