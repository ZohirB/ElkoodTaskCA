using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Contracts.CQRS.Queries.ProductProducedQuery;
using ElkoodTaskCA.Contracts.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ElkoodTaskCA.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsProducedController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsProducedController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<ProductProducedDetailsDto>>> GetAllProductsProduced(
        [FromQuery] GetAllProductProducedQuery query)
    {
        return await _mediator.Send(query).ToJsonResultAsync();
    }
}