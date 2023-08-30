using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using ElkoodTaskCA.Domain.Entities.General;
using ElkoodTaskCA.Domain.Repositories;
using ElkoodTaskCA.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ElkoodTaskCA.Persistence.Repositories;

public class DistributionOperationService : IDistributionOperationService
{
    private readonly ElkoodTaskCADbContext _context;

    public DistributionOperationService(ElkoodTaskCADbContext context)
    {
        _context = context;
    }

    public async Task<List<DistrubutionDetailsDto>> GetAllDistributionOperation()
    {
        var distributionOperation = await _context.DistributionOperations
            .Include(dio => dio.ProductInfo)
            .Select(dio => new DistrubutionDetailsDto
            {
                Id = dio.Id,
                PrimaryBranchInfoName = dio.PrimaryBranchInfo.Name,
                SecondaryBranchInfoName = dio.SecondaryBranchInfo.Name,
                ProductInfoName = dio.ProductInfo.Name,
                Quantity = dio.Quantity,
                Date = dio.Date
            })
            .ToListAsync();
        return distributionOperation;
    }

    public async void CreateDistributionOperation(DistributionOperation distributionOperation, int quantity)
    {
        _context.DistributionOperations.Add(distributionOperation);
        var remainingQuantityToUpdate = quantity;
        var productionOperations = await _context.ProductionOperations
            .Where(po =>
                po.BranchInfoId == distributionOperation.PrimaryBranchInfoId &&
                po.ProductInfoId == distributionOperation.ProductInfoId)
            .OrderBy(po => po.Date)
            .ToListAsync();
        foreach (var production in productionOperations)
        {
            if (remainingQuantityToUpdate <= 0) break;
            var quantityToUpdate = Math.Min(remainingQuantityToUpdate, production.RemainingQuantity);
            production.RemainingQuantity -= quantityToUpdate;
            remainingQuantityToUpdate -= quantityToUpdate;
        }

        await _context.SaveChangesAsync();
    }

    public async Task<int> TotalRemainingQuantity(int primaryBranchInfoId, int productInfoId)
    {
        var totalRemainingQuantity = await _context.ProductionOperations
            .Where(po =>
                po.BranchInfoId == primaryBranchInfoId &&
                po.ProductInfoId == productInfoId)
            .SumAsync(po => po.RemainingQuantity);
        return totalRemainingQuantity;
    }

    public async Task<bool> IsValidPrimaryBranchTypeTask(int primaryBranchInfoId)
    {
        var isValidPrimaryBranchType = await _context.BranchInfo
            .Where(bt => bt.BranchTypeId == 1)
            .AnyAsync(bt => bt.Id == primaryBranchInfoId);
        return isValidPrimaryBranchType;
    }
    
    public async Task<bool> IsValidSecondaryBranchType(int secondaryBranchInfoId)
    {
        var isValidSecondaryBranchType = await _context.BranchInfo
            .Where(bt => bt.BranchTypeId == 2)
            .AnyAsync(bt => bt.Id == secondaryBranchInfoId);
        return isValidSecondaryBranchType;
    }
}