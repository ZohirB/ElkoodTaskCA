﻿using Elkood.Application.OperationResponses;
using MediatR;
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
    public async Task<IActionResult> GetAllBranchInfo() 
    {
        var query = new GetAllBranchInfoQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBranchInfo([FromBody] CreateBranchInfoCommand command)
    {
        return await _mediator.Send(command).ToJsonResultAsync();
    }
}