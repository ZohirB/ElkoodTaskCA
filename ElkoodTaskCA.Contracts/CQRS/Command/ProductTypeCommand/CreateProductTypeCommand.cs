using ElkoodTaskCA.Contracts.Models;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Command.ProductTypeCommand;

public class CreateProductTypeCommand : IRequest<ProductType>
{
    [MaxLength(100)] public string Name { get; set; }
}