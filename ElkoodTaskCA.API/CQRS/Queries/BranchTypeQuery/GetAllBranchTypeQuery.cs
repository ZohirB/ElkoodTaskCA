using MediatR;

namespace ElkoodTaskCA.API.CQRS.Queries.BranchTypeQuery;

public class GetAllBranchTypeQuery : IRequest<IEnumerable<BranchType>>
{
}