using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET_6._0__JWT__CQRS.Core.Application.Features.CQRS.Queries;

namespace NET_6._0__JWT__CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetAllProductsQueryRequest());
            return Ok(result);
        }
    }
}
