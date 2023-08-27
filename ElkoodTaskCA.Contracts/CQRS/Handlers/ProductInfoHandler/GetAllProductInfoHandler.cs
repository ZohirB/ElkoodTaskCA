using ElkoodTaskCA.Contracts.CQRS.Queries.ProductInfoQuery;
using ElkoodTaskCA.Contracts.Dtos;
using ElkoodTaskCA.Contracts.Repositories.ProductsInfoRepository;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Handlers.ProductInfoHandler;

public class GetAllProductInfoHandler : IRequestHandler<GetAllProductsInfoQuery, List<ProductDetailsDto>>
{
    private readonly IProductsInfoService _productsInfoService;

    public GetAllProductInfoHandler(IProductsInfoService productsInfoService)
    {
        _productsInfoService = productsInfoService;
    }

    public async Task<List<ProductDetailsDto>> Handle(GetAllProductsInfoQuery request,
        CancellationToken cancellationToken)
    {
        var productsInfo = await _productsInfoService.GetAllProductsInfo();
        return productsInfo;
    }
}