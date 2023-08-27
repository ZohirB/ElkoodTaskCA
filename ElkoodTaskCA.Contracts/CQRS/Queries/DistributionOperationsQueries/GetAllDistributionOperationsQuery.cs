using ElkoodTaskCA.Contracts.Dtos;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Queries.DistributionOperationsQueries;

public class GetAllDistributionOperationsQuery : IRequest<IEnumerable<DistrubutionDetailsDto>>
{
}