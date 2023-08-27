using MediatR;

namespace ElkoodTaskCA.API.CQRS.Command.ProductTypeCommand;

public class CreateProductTypeCommand : IRequest<ProductType>
{
    [MaxLength(100)] public string Name { get; set; }
}