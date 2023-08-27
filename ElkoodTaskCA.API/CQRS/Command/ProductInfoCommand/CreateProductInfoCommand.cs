﻿using Elkood.Application.OperationResponses;
using MediatR;

namespace ElkoodTaskCA.API.CQRS.Command.ProductInfoCommand;

public class CreateProductInfoCommand : IRequest<OperationResponse<ProductInfo>>
{
    [MaxLength(100)] public string Name { get; set; }
    public int ProductTypeId { get; set; }
}