using ElkoodTaskCA.Domain.Entities.General;
using ElkoodTaskCA.Domain.Repositories;
using MediatR;

namespace ElkoodTaskCA.Application.ProductTypes.Commands.Create;

public class CreateProductTypeHandler : IRequestHandler<CreateProductTypeCommand, ProductType>
{
    private readonly IProductTypesService productTypesService;

    public CreateProductTypeHandler(IProductTypesService productTypesService)
    {
        this.productTypesService = productTypesService;
    }

    public async Task<ProductType> Handle(CreateProductTypeCommand request, CancellationToken cancellationToken)
    {
        var productType = new ProductType { Name = request.Name };
        await productTypesService.CreateProductType(productType);
        return productType;
    }
}