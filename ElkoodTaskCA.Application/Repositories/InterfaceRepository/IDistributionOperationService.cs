﻿using ElkoodTaskCA.Application.CQRS.DistributionOperation.Commands.Create;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;

namespace ElkoodTaskCA.Application.Repositories.InterfaceRepository;

public interface IDistributionOperationService
{
    Task<List<DistrubutionDetailsDto>> GetAllDistributionOperation();
    void CreateDistributionOperation(CreateDistributionOperationCommand distrubutionOperationDto);
    Task<int> TotalRemainingQuantity(CreateDistributionOperationCommand distrubutionOperationDto);
    Task<bool> IsValidPrimaryBranchTypeTask(CreateDistributionOperationCommand distrubutionOperationDto);
    Task<bool> IsValidSecondaryBranchType(CreateDistributionOperationCommand distrubutionOperationDto);
}