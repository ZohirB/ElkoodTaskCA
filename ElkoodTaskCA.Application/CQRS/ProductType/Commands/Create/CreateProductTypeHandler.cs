using ElkoodTaskCA.Application.Repositories.InterfaceRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductType.Commands.Create;

public class CreateProductTypeHandler : IRequestHandler<CreateProductTypeCommand, Domain.Models.MainEntities.ProductType>
{
    private readonly IProductTypesService productTypesService;

    public CreateProductTypeHandler(IProductTypesService productTypesService)
    {
        this.productTypesService = productTypesService;
    }

    public async Task<Domain.Models.MainEntities.ProductType> Handle(CreateProductTypeCommand request, CancellationToken cancellationToken)
    {
        var productType = new Domain.Models.MainEntities.ProductType { Name = request.Name };
        await productTypesService.CreateProductType(productType);
        return productType;
    }
}