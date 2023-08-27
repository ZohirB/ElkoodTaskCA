using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ElkoodTaskCA.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BranchTypesController : ControllerBase
{
    private readonly IMediator _mediator;

    public BranchTypesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBranchTypes()
    {
        var query = new GetAllBranchTypeQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBranchType(CreateBranchTypeCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}