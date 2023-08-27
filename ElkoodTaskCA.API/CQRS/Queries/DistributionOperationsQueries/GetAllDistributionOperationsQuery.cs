using MediatR;

namespace ElkoodTaskCA.API.CQRS.Queries.DistributionOperationsQueries;

public class GetAllDistributionOperationsQuery : IRequest<IEnumerable<DistrubutionDetailsDto>>
{
}