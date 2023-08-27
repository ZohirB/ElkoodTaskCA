using ElkoodTaskCA.Contracts.CQRS.Command.ProductInfoCommand;
using ElkoodTaskCA.Contracts.Dtos;
using ElkoodTaskCA.Contracts.Models;

namespace ElkoodTaskCA.Contracts.Repositories.ProductsInfoRepository;

public interface IProductsInfoService
{
    Task<List<ProductDetailsDto>> GetAllProductsInfo();
    Task<ProductInfo> CreateProductsInfo(CreateProductInfoCommand dto);
    Task<bool> IsValidProductType(int productTypeId);
}