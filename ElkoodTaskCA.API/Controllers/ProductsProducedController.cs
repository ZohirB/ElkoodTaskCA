using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Application.ProductProduceds.Queries.GetAll;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
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