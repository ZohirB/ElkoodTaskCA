using ElkoodTaskCA.Domain.Dtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Queries.DistributionOperationsQueries;

public class GetAllDistributionOperationsQuery : IRequest<IEnumerable<DistrubutionDetailsDto>>
{
}