using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Application.Dtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Command.ProductInfoCommand;

public class CreateProductInfoCommand : IRequest<OperationResponse<ProductInfoDto>>
{
    [MaxLength(100)] public string Name { get; set; }
    public int ProductTypeId { get; set; }
}