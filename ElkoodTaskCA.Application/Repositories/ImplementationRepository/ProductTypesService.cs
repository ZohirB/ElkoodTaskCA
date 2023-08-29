using ElkoodTaskCA.Application.Repositories.InterfaceRepository;
using ElkoodTaskCA.Domain.Models;
using ElkoodTaskCA.Domain.Models.MainEntities;
using ElkoodTaskCA.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ElkoodTaskCA.Application.Repositories.ImplementationRepository;

public class ProductTypesService : IProductTypesService
{
    private readonly ElkoodTaskCADbContext _context;

    public ProductTypesService(ElkoodTaskCADbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ProductType>> GetAllProductTypes()
    {
        return await _context.ProductTypes.ToListAsync();
    }

    public async Task<ProductType> GetProductTypeById(int id)
    {
        return await _context.ProductTypes.SingleOrDefaultAsync(pt => pt.Id == id);
    }

    public async Task<ProductType> CreateProductType(ProductType productType)
    {
        _context.Add(productType);
        await _context.SaveChangesAsync();
        return productType;
    }

    public ProductType UpdateProductType(ProductType productType)
    {
        _context.Update(productType);
        _context.SaveChanges();
        return productType;
    }

    /*
    public ProductType DeleteProductType(ProductType productType)
    {
        _context.Remove(productType);
        _context.SaveChanges();
        return productType;
    }
    */
}