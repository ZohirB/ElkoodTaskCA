﻿using ElkoodTaskCA.Application.Repositories.BranchInfoRepository;
using ElkoodTaskCA.Contracts.Dtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.BranchInfo.Queries.GetAll;

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