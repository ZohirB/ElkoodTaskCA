﻿using ElkoodTaskCA.Application.CompaniesInfo.Commands.Create;
using ElkoodTaskCA.Application.CompaniesInfo.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ElkoodTaskCA.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CompaniesInfoController : ControllerBase
{
    private readonly IMediator _mediator;

    public CompaniesInfoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCompaniesInfo()
    {
        var query = new GetAllCompaniesInfoQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCompanyInfo(CreateCompanyInfoCommand.Request command)
    {
        var result = await _mediator.Send(command);
        return new JsonResult(result);
    }
}