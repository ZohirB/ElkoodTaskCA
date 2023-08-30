using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using ElkoodTaskCA.Domain.Repositories;
using MediatR;

namespace ElkoodTaskCA.Application.DistributionOperations.Queries.GetAll;

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