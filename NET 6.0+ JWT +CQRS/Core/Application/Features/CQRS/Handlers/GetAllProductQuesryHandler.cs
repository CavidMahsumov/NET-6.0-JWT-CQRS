using AutoMapper;
using MediatR;
using NET_6._0__JWT__CQRS.Core.Application.Dto;
using NET_6._0__JWT__CQRS.Core.Application.Features.CQRS.Queries;
using NET_6._0__JWT__CQRS.Core.Application.Interfaces;
using NET_6._0__JWT__CQRS.Core.Domain;

namespace NET_6._0__JWT__CQRS.Core.Application.Features.CQRS.Handlers
{
    public class GetAllProductQuesryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper mapper;

        public GetAllProductQuesryHandler(IRepository<Product> repository, IMapper mapper)
        {     
            _repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            return this.mapper.Map<List<ProductListDto>>(await this._repository.GetAllAsync()) ;
        }
    }
}
