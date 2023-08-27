using ElkoodTaskCA.API.CQRS.Command.ProductInfoCommand;

namespace ElkoodTaskCA.API.Repositories.ProductsInfoRepository;

public interface IProductsInfoService
{
    Task<List<ProductDetailsDto>> GetAllProductsInfo();
    Task<ProductInfo> CreateProductsInfo(CreateProductInfoCommand dto);
    Task<bool> IsValidProductType(int productTypeId);
}