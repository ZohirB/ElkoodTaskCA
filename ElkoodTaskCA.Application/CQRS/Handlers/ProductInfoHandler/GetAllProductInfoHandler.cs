using ElkoodTaskCA.Application.CQRS.Queries.ProductInfoQuery;
using ElkoodTaskCA.Domain.Dtos;
using ElkoodTaskCA.Domain.Repositories.ProductsInfoRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.ProductInfoHandler;

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