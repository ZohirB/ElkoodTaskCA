using MediatR;

namespace ElkoodTaskCA.Application.CQRS.BranchType.Queries.GetAll;

public class GetAllBranchTypeQuery : IRequest<IEnumerable<Domain.Models.BranchType>>
{
}