using System.Collections.Generic;
using System.Threading.Tasks;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using ElkoodTaskCA.Domain.Entities.General;

namespace ElkoodTaskCA.Domain.Repositories;

public interface IDistributionOperationService
{
    Task<List<DistrubutionDetailsDto>> GetAllDistributionOperation();
    void CreateDistributionOperation(DistributionOperation distrubutionOperationDto,int quantity);
    Task<int> TotalRemainingQuantity(int primaryBranchInfoId, int productInfoId);
    Task<bool> IsValidPrimaryBranchTypeTask(int primaryBranchInfoId);
    Task<bool> IsValidSecondaryBranchType(int secondaryBranchInfoId);
}