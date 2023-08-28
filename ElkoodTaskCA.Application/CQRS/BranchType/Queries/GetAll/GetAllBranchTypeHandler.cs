using ElkoodTaskCA.Application.Repositories.BranchTypeRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.BranchType.Queries.GetAll;

public class GetAllBranchTypeHandler : IRequestHandler<GetAllBranchTypeQuery, IEnumerable<Domain.Models.BranchType>>
{
    private readonly IBranchTypesService _branchTypesService;

    public GetAllBranchTypeHandler(IBranchTypesService branchTypesService)
    {
        _branchTypesService = branchTypesService;
    }

    public async Task<IEnumerable<Domain.Models.BranchType>> Handle(GetAllBranchTypeQuery request,
        CancellationToken cancellationToken)
    {
        var branchTypes = await _branchTypesService.GetAllBranchType();
        return branchTypes;
    }
}