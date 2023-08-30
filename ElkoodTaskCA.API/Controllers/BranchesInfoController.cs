using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Application.BranchInfos.Commands.Create;
using ElkoodTaskCA.Application.BranchInfos.Queries.GetAll;
using ElkoodTaskCA.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElkoodTaskCA.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BranchesInfoController : ControllerBase
{
    private readonly IMediator _mediator;

    public BranchesInfoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Authorize(Roles = StaticUserRoles.APP_USER)]
    public async Task<IActionResult> GetAllBranchInfo()
    {
        var query = new GetAllBranchInfoQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBranchInfo([FromBody] CreateBranchInfoCommand.Request command)
    {
        return await _mediator.Send(command).ToJsonResultAsync();
    }
}