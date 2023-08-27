﻿using ElkoodTaskCA.API.CQRS.Queries.BranchTypeQuery;
using ElkoodTaskCA.API.Repositories.BranchTypeRepository;
using MediatR;

namespace ElkoodTaskCA.API.CQRS.Handlers.BranchTypeHandler;

public class GetAllBranchTypeHandler : IRequestHandler<GetAllBranchTypeQuery, IEnumerable<BranchType>>
{
    private readonly IBranchTypesService _branchTypesService;

    public GetAllBranchTypeHandler(IBranchTypesService branchTypesService)
    {
        _branchTypesService = branchTypesService;
    }

    public async Task<IEnumerable<BranchType>> Handle(GetAllBranchTypeQuery request,
        CancellationToken cancellationToken)
    {
        var branchTypes = await _branchTypesService.GetAllBranchType();
        return branchTypes;
    }
}