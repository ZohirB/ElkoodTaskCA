﻿using Elkood.Application.OperationResponses;
using ElkoodTaskCA.API.CQRS.Command.ProductionOprationCommand;
using ElkoodTaskCA.API.CQRS.Queries.ProductionOprationQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ElkoodTaskCA.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductionOperationsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductionOperationsController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllProductionOperations()
    {
        var query = new GetAllProductionOprationQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductionOperation([FromBody] CreateProductionOprationCommand command)
    {
        return await _mediator.Send(command).ToJsonResultAsync();
    }
}