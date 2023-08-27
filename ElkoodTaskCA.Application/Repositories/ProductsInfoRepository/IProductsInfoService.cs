using ElkoodTaskCA.Application.CQRS.Command.ProductInfoCommand;
using ElkoodTaskCA.Application.Dtos;

namespace ElkoodTaskCA.Application.Repositories.ProductsInfoRepository;

public interface IProductsInfoService
{
    Task<List<ProductDetailsDto>> GetAllProductsInfo();
    Task<ProductInfoDto> CreateProductsInfo(CreateProductInfoCommand dto);
    Task<bool> IsValidProductType(int productTypeId);
}