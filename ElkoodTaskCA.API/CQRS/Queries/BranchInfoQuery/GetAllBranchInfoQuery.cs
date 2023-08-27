using MediatR;

namespace ElkoodTaskCA.API.CQRS.Queries.BranchInfoQuery;

public class GetAllBranchInfoQuery : IRequest<IEnumerable<BranchDetailsDto>>
{
}