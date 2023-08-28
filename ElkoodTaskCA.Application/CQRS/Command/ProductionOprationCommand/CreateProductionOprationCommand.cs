﻿using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Domain.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Command.ProductionOprationCommand;

public class CreateProductionOprationCommand : IRequest<OperationResponse<ProductionOperation>>
{
    public int BranchInfoId { get; set; }
    public int ProductInfoId { get; set; }
    public int quantity { get; set; }
    public DateTime date { get; set; }
}