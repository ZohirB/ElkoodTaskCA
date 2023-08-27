using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Contracts.Models;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Command.ProductInfoCommand;

public class CreateProductInfoCommand : IRequest<OperationResponse<ProductInfo>>
{
    [MaxLength(100)] public string Name { get; set; }
    public int ProductTypeId { get; set; }
}