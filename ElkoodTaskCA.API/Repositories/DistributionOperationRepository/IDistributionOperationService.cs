﻿using ElkoodTaskCA.API.CQRS.Command.DistributionOperationCommand;

namespace ElkoodTaskCA.API.Repositories.DistributionOperationRepository;

public interface IDistributionOperationService
{
    Task<List<DistrubutionDetailsDto>> GetAllDistributionOperation();
    void CreateDistributionOperation(CreateDistributionOperationCommand distrubutionOperationDto);
    Task<int> TotalRemainingQuantity(CreateDistributionOperationCommand distrubutionOperationDto);
    Task<bool> IsValidPrimaryBranchTypeTask(CreateDistributionOperationCommand distrubutionOperationDto);
    Task<bool> IsValidSecondaryBranchType(CreateDistributionOperationCommand distrubutionOperationDto);
}