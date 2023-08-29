using ElkoodTaskCA.Contracts.Dtos;
using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.DistributionOperation.Queries.GetAll;

public class GetAllDistributionOperationsQuery : IRequest<IEnumerable<DistrubutionDetailsDto>>
{
}