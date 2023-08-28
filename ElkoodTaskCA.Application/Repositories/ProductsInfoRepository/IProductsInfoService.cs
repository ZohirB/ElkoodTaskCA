using ElkoodTaskCA.Application.CQRS.ProductInfo.Commands.Create;
using ElkoodTaskCA.Contracts.Dtos;

namespace ElkoodTaskCA.Application.Repositories.ProductsInfoRepository;

public interface IProductsInfoService
{
    Task<List<ProductDetailsDto>> GetAllProductsInfo();
    Task<ProductInfoDto> CreateProductsInfo(CreateProductInfoCommand dto);
    Task<bool> IsValidProductType(int productTypeId);
}