using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using ElkoodTaskCA.Domain.Entities.General;
using ElkoodTaskCA.Domain.Repositories;
using ElkoodTaskCA.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ElkoodTaskCA.Persistence.Repositories;

public class ProductsInfoService : IProductsInfoService
{
    private readonly ElkoodTaskCADbContext _context;

    public ProductsInfoService(ElkoodTaskCADbContext context)
    {
        _context = context;
    }

    public async Task<List<ProductDetailsDto>> GetAllProductsInfo()
    {
        var productsInfo = await _context.ProductInfo
            .Include(pi => pi.ProductType)
            .Select(pi => new ProductDetailsDto
            {
                Id = pi.Id,
                Name = pi.Name,
                ProductTypeName = pi.ProductType.Name
            })
            .ToListAsync();
        return productsInfo;
    }

    public async Task<ProductInfo> CreateProductsInfo(ProductInfo productInfo)
    {
        _context.Add(productInfo);
        await _context.SaveChangesAsync();
        return productInfo;
    }

    public Task<bool> IsValidProductType(int productTypeId)
    {
        return _context.ProductTypes.AnyAsync(pi => pi.Id == productTypeId);
    }
}