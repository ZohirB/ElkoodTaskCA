using System.Collections.Generic;
using System.Threading.Tasks;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using ElkoodTaskCA.Domain.Entities.General;

namespace ElkoodTaskCA.Domain.Repositories;

public interface IProductsInfoService
{
    Task<List<ProductDetailsDto>> GetAllProductsInfo();
    Task<ProductInfo> CreateProductsInfo(ProductInfo productInfo);
    Task<bool> IsValidProductType(int productTypeId);
}