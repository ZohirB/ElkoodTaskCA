using ElkoodTaskCA.Application.CQRS.ProductInfo.Commands.Create;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;

namespace ElkoodTaskCA.Application.Repositories.InterfaceRepository;

public interface IProductsInfoService
{
    Task<List<ProductDetailsDto>> GetAllProductsInfo();
    Task<ProductInfoDto> CreateProductsInfo(CreateProductInfoCommand dto);
    Task<bool> IsValidProductType(int productTypeId);
}