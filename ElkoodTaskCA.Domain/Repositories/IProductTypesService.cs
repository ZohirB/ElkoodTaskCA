using System.Collections.Generic;
using System.Threading.Tasks;
using ElkoodTaskCA.Domain.Entities.General;

namespace ElkoodTaskCA.Domain.Repositories;

public interface IProductTypesService
{
    Task<IEnumerable<ProductType>> GetAllProductTypes();
    Task<ProductType> GetProductTypeById(int id);
    Task<ProductType> CreateProductType(ProductType productType);
    ProductType UpdateProductType(ProductType productType);
    //ProductType DeleteProductType(ProductType productType);
}