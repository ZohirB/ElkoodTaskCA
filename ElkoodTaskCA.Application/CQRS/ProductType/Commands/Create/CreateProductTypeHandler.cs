using ElkoodTaskCA.Application.Repositories.ProductTypeRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductType.Commands.Create;

public class CreateProductTypeHandler : IRequestHandler<CreateProductTypeCommand, Domain.Models.ProductType>
{
    private readonly IProductTypesService productTypesService;

    public CreateProductTypeHandler(IProductTypesService productTypesService)
    {
        this.productTypesService = productTypesService;
    }

    public async Task<Domain.Models.ProductType> Handle(CreateProductTypeCommand request, CancellationToken cancellationToken)
    {
        var productType = new Domain.Models.ProductType { Name = request.Name };
        await productTypesService.CreateProductType(productType);
        return productType;
    }
}