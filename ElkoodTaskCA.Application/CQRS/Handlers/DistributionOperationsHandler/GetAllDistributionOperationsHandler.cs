using ElkoodTaskCA.Application.CQRS.Queries.DistributionOperationsQueries;
using ElkoodTaskCA.Application.Repositories.DistributionOperationRepository;
using ElkoodTaskCA.Contracts.Dtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.DistributionOperationsHandler;

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