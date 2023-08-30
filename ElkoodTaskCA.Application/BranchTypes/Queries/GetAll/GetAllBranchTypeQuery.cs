using ElkoodTaskCA.Domain.Entities.General;
using MediatR;

namespace ElkoodTaskCA.Application.BranchTypes.Queries.GetAll;

public class GetAllBranchTypeQuery : IRequest<IEnumerable<BranchType>>
{
}