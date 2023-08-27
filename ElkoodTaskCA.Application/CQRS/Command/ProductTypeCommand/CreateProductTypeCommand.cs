using ElkoodTaskCA.Application.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Command.ProductTypeCommand;

public class CreateProductTypeCommand : IRequest<ProductType>
{
    [MaxLength(100)] public string Name { get; set; }
}