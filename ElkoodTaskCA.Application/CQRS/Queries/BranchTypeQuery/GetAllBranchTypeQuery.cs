using ElkoodTaskCA.Application.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Queries.BranchTypeQuery;

public class GetAllBranchTypeQuery : IRequest<IEnumerable<BranchType>>
{
}