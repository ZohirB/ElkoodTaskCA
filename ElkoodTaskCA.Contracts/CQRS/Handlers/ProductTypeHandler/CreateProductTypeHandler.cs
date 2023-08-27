using ElkoodTaskCA.Contracts.CQRS.Command.ProductTypeCommand;
using ElkoodTaskCA.Contracts.Models;
using ElkoodTaskCA.Contracts.Repositories.ProductTypeRepository;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Handlers.ProductTypeHandler;

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