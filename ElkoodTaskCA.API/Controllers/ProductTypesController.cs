using ElkoodTaskCA.API.CQRS.Command.ProductTypeCommand;
using ElkoodTaskCA.API.CQRS.Queries.ProductTypeQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ElkoodTaskCA.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductTypesController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductTypesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProductTypes()
    {
        var query = new GetProductTypeQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductType(CreateProductTypeCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}