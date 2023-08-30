using Elkood.Application.OperationResponses;
using Elkood.Domain.Exceptions;
using Elkood.Domain.Exceptions.Http;
using ElkoodTaskCA.Domain.Entities.General;
using ElkoodTaskCA.Domain.Repositories;
using MediatR;

namespace ElkoodTaskCA.Application.ProductInfos.Commands.Create;

public class CreateProductInfoHandler : IRequestHandler<CreateProductInfoCommand.Request, OperationResponse<ProductInfo>>
{
    private readonly IProductsInfoService _productsInfoService;

    public CreateProductInfoHandler(IProductsInfoService productsInfoService)
    {
        _productsInfoService = productsInfoService;
    }

    public async Task<OperationResponse<ProductInfo>> Handle(CreateProductInfoCommand.Request request,
        CancellationToken cancellationToken)
    {
        var isValidProductType = await _productsInfoService.IsValidProductType(request.ProductTypeId);
        if (!isValidProductType) return new HttpMessage("Invalid Product Type ID", HttpStatusCode.BadRequest400);

        var productInfo = new ProductInfo
        {
            Name = request.Name,
            ProductTypeId = request.ProductTypeId
        };
        
        return await _productsInfoService.CreateProductsInfo(productInfo);
    }
}