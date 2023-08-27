using Elkood.Application.OperationResponses;
using Elkood.Domain.Exceptions;
using Elkood.Domain.Exceptions.Http;
using ElkoodTaskCA.Application.CQRS.Command.ProductInfoCommand;
using ElkoodTaskCA.Application.Dtos;
using ElkoodTaskCA.Application.Repositories.ProductsInfoRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.ProductInfoHandler;

public class CreateProductInfoHandler : IRequestHandler<CreateProductInfoCommand, OperationResponse<ProductInfoDto>>
{
    private readonly IProductsInfoService _productsInfoService;

    public CreateProductInfoHandler(IProductsInfoService productsInfoService)
    {
        _productsInfoService = productsInfoService;
    }

    public async Task<OperationResponse<ProductInfoDto>> Handle(CreateProductInfoCommand request,
        CancellationToken cancellationToken)
    {
        var isValidProductType = await _productsInfoService.IsValidProductType(request.ProductTypeId);
        if (!isValidProductType) return new HttpMessage("Invalid Product Type ID", HttpStatusCode.BadRequest400);

        var productInfo = await _productsInfoService.CreateProductsInfo(request);
        return productInfo;
    }
}