using ElkoodTaskCA.Contracts.CQRS.Command.BranchTypeCommand;
using ElkoodTaskCA.Contracts.Models;
using ElkoodTaskCA.Contracts.Repositories.BranchTypeRepository;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Handlers.BranchTypeHandler;

public class CreateBranchTypeHandler : IRequestHandler<CreateBranchTypeCommand, BranchType>
{
    private readonly IBranchTypesService _branchTypesService;

    public CreateBranchTypeHandler(IBranchTypesService branchTypesService)
    {
        _branchTypesService = branchTypesService;
    }

    public async Task<BranchType> Handle(CreateBranchTypeCommand request, CancellationToken cancellationToken)
    {
        var branchType = new BranchType { Name = request.Name };
        await _branchTypesService.CreateBranchType(branchType);
        return branchType;
    }
}