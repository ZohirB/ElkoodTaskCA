using ElkoodTaskCA.Application.CQRS.Queries.ProductTypeQuery;
using ElkoodTaskCA.Application.Repositories.ProductTypeRepository;
using ElkoodTaskCA.Domain.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.ProductTypeHandler;

public class GetProductTypeHandler : IRequestHandler<GetProductTypeQuery, IEnumerable<ProductType>>
{
    private readonly IProductTypesService productTypesService;

    public GetProductTypeHandler(IProductTypesService productTypesService)
    {
        this.productTypesService = productTypesService;
    }

    public async Task<IEnumerable<ProductType>> Handle(GetProductTypeQuery request, CancellationToken cancellationToken)
    {
        var productTypes = await productTypesService.GetAllProductTypes();
        return productTypes;
    }
}