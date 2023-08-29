using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductType.Commands.Create;

public class CreateProductTypeCommand : IRequest<Domain.Models.MainEntities.ProductType>
{
    [MaxLength(100)] public string Name { get; set; }
}