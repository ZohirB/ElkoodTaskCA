using ElkoodTaskCA.Domain.Dtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Queries.BranchInfoQuery;

public class GetAllBranchInfoQuery : IRequest<IEnumerable<BranchDetailsDto>>
{
}