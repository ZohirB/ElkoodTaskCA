using ElkoodTaskCA.Application.CQRS.ProductInfo.Commands.Create;
using ElkoodTaskCA.Application.Repositories.InterfaceRepository;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using ElkoodTaskCA.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ElkoodTaskCA.Application.Repositories.ImplementationRepository;

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