using ElkoodTaskCA.Application.CQRS.Command.ProductInfoCommand;
using ElkoodTaskCA.Application.Dtos;
using ElkoodTaskCA.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace ElkoodTaskCA.Application.Repositories.ProductsInfoRepository;

public class ProductsInfoService : IProductsInfoService
{
    private readonly ApplicationDbContext _context;

    public ProductsInfoService(ApplicationDbContext context)
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

    public async Task<ProductInfoDto> CreateProductsInfo(CreateProductInfoCommand dto)
    {
        var productInfo = new ProductInfoDto
        {
            Name = dto.Name,
            ProductTypeId = dto.ProductTypeId
        };
        _context.Add(productInfo);
        await _context.SaveChangesAsync();
        return productInfo;
    }

    public Task<bool> IsValidProductType(int productTypeId)
    {
        return _context.ProductTypes.AnyAsync(pi => pi.Id == productTypeId);
    }
}