using ElkoodTaskCA.API.CQRS.Command.ProductTypeCommand;
using ElkoodTaskCA.API.Repositories.ProductTypeRepository;
using MediatR;

namespace ElkoodTaskCA.API.CQRS.Handlers.ProductTypeHandler;

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