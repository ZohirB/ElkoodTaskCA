using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductInfo.Commands.Create;

public class CreateProductInfoCommand : IRequest<OperationResponse<ProductInfoDto>>
{
    [MaxLength(100)] public string Name { get; set; }
    public int ProductTypeId { get; set; }
}