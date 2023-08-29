using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.BranchInfo.Queries.GetAll;

public class GetAllBranchInfoQuery : IRequest<IEnumerable<BranchDetailsDto>>
{
}