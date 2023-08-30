using ElkoodTaskCA.Domain.Entities.General;
using MediatR;

namespace ElkoodTaskCA.Application.ProductTypes.Commands.Create;

public class CreateProductTypeCommand : IRequest<ProductType>
{
    [MaxLength(100)] public string Name { get; set; }
}