using ElkoodTaskCA.Contracts.Models;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Queries.BranchTypeQuery;

public class GetAllBranchTypeQuery : IRequest<IEnumerable<BranchType>>
{
}