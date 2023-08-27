using ElkoodTaskCA.Application.CQRS.Command.ProductTypeCommand;
using ElkoodTaskCA.Application.Repositories.ProductTypeRepository;
using ElkoodTaskCA.Domain.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.ProductTypeHandler;

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