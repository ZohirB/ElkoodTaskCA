using ElkoodTaskCA.Application.Repositories.InterfaceRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductType.Queries.GetAll;

public class GetProductTypeHandler : IRequestHandler<GetProductTypeQuery, IEnumerable<Domain.Models.ProductType>>
{
    private readonly IProductTypesService productTypesService;

    public GetProductTypeHandler(IProductTypesService productTypesService)
    {
        this.productTypesService = productTypesService;
    }

    public async Task<IEnumerable<Domain.Models.ProductType>> Handle(GetProductTypeQuery request, CancellationToken cancellationToken)
    {
        var productTypes = await productTypesService.GetAllProductTypes();
        return productTypes;
    }
}