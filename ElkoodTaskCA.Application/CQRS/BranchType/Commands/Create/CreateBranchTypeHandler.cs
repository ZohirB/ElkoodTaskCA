using ElkoodTaskCA.Application.Repositories.InterfaceRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.BranchType.Commands.Create;

public class CreateBranchTypeHandler : IRequestHandler<CreateBranchTypeCommand, Domain.Models.BranchType>
{
    private readonly IBranchTypesService _branchTypesService;

    public CreateBranchTypeHandler(IBranchTypesService branchTypesService)
    {
        _branchTypesService = branchTypesService;
    }

    public async Task<Domain.Models.BranchType> Handle(CreateBranchTypeCommand request, CancellationToken cancellationToken)
    {
        var branchType = new Domain.Models.BranchType { Name = request.Name };
        await _branchTypesService.CreateBranchType(branchType);
        return branchType;
    }
}