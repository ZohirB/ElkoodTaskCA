using Elkood.Application.OperationResponses;
using Elkood.Domain.Exceptions;
using Elkood.Domain.Exceptions.Http;
using ElkoodTaskCA.API.CQRS.Command.ProductInfoCommand;
using ElkoodTaskCA.API.Repositories.ProductsInfoRepository;
using MediatR;

namespace ElkoodTaskCA.API.CQRS.Handlers.ProductInfoHandler;

public class CreateProductInfoHandler : IRequestHandler<CreateProductInfoCommand, OperationResponse<ProductInfo>>
{
    private readonly IProductsInfoService _productsInfoService;

    public CreateProductInfoHandler(IProductsInfoService productsInfoService)
    {
        _productsInfoService = productsInfoService;
    }

    public async Task<OperationResponse<ProductInfo>> Handle(CreateProductInfoCommand request,
        CancellationToken cancellationToken)
    {
        var isValidProductType = await _productsInfoService.IsValidProductType(request.ProductTypeId);
        if (!isValidProductType) return new HttpMessage("Invalid Product Type ID", HttpStatusCode.BadRequest400);

        var productInfo = await _productsInfoService.CreateProductsInfo(request);
        return productInfo;
    }
}