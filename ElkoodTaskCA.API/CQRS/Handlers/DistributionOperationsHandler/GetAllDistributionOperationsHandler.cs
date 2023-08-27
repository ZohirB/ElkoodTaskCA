﻿using ElkoodTaskCA.API.CQRS.Queries.DistributionOperationsQueries;
using ElkoodTaskCA.API.Repositories.DistributionOperationRepository;
using MediatR;

namespace ElkoodTaskCA.API.CQRS.Handlers.DistributionOperationsHandler;

public class
    GetAllDistributionOperationsHandler : IRequestHandler<GetAllDistributionOperationsQuery,
        IEnumerable<DistrubutionDetailsDto>>
{
    private readonly IDistributionOperationService _distributionOperationService;

    public GetAllDistributionOperationsHandler(IDistributionOperationService distributionOperationService)
    {
        _distributionOperationService = distributionOperationService;
    }

    public async Task<IEnumerable<DistrubutionDetailsDto>> Handle(GetAllDistributionOperationsQuery request,
        CancellationToken cancellationToken)
    {
        var distributionOperation = await _distributionOperationService.GetAllDistributionOperation();
        return distributionOperation;
    }
}