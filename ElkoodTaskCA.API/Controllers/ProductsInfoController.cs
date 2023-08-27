using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Application.CQRS.Command.ProductInfoCommand;
using ElkoodTaskCA.Application.CQRS.Queries.ProductInfoQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ElkoodTaskCA.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsInfoController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsInfoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProductsInfo()
    {
        var query = new GetAllProductsInfoQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductsInfo([FromBody] CreateProductInfoCommand command)
    {
        return await _mediator.Send(command).ToJsonResultAsync();
    }
}