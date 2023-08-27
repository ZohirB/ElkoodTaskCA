using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Domain.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Command.ProductInfoCommand;

public class CreateProductInfoCommand : IRequest<OperationResponse<ProductInfo>>
{
    [MaxLength(100)] public string Name { get; set; }
    public int ProductTypeId { get; set; }
}