using ElkoodTaskCA.Contracts.Dtos;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Queries.BranchInfoQuery;

public class GetAllBranchInfoQuery : IRequest<IEnumerable<BranchDetailsDto>>
{
}