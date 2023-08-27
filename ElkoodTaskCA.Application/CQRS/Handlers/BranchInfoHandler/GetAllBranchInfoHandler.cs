using ElkoodTaskCA.Application.CQRS.Queries.BranchInfoQuery;
using ElkoodTaskCA.Domain.Dtos;
using ElkoodTaskCA.Domain.Repositories.BranchInfoRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.BranchInfoHandler;

public class GetAllBranchInfoHandler : IRequestHandler<GetAllBranchInfoQuery, IEnumerable<BranchDetailsDto>>
{
    private readonly IBranchesInfoService _branchesInfoService;

    public GetAllBranchInfoHandler(IBranchesInfoService branchesInfoService)
    {
        _branchesInfoService = branchesInfoService;
    }

    public async Task<IEnumerable<BranchDetailsDto>> Handle(GetAllBranchInfoQuery request,
        CancellationToken cancellationToken)
    {
        var branchInfo = await _branchesInfoService.GetAllBranchInfo();
        return branchInfo;
    }
}