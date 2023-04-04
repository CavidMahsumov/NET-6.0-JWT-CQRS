using AutoMapper;
using NET_6._0__JWT__CQRS.Core.Application.Dto;
using NET_6._0__JWT__CQRS.Core.Domain;

namespace NET_6._0__JWT__CQRS.Core.Application.Mappings
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
