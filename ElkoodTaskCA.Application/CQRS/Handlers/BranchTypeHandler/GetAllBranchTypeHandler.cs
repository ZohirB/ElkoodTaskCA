using ElkoodTaskCA.Application.CQRS.Queries.BranchTypeQuery;
using ElkoodTaskCA.Domain.Models;
using ElkoodTaskCA.Domain.Repositories.BranchTypeRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Handlers.BranchTypeHandler;

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