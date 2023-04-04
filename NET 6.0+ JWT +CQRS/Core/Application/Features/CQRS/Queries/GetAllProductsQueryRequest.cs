using MediatR;
using NET_6._0__JWT__CQRS.Core.Application.Dto;

namespace NET_6._0__JWT__CQRS.Core.Application.Features.CQRS.Queries
{
    public class GetAllProductsQueryRequest:IRequest<List<ProductListDto>>
    {
         

    }
}
