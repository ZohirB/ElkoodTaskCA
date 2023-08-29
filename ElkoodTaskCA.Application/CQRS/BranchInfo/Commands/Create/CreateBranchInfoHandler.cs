using Elkood.Application.OperationResponses;
using Elkood.Domain.Exceptions;
using Elkood.Domain.Exceptions.Http;
using ElkoodTaskCA.Application.Repositories.InterfaceRepository;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.BranchInfo.Commands.Create;

public class CreateBranchInfoHandler : IRequestHandler<CreateBranchInfoCommand, OperationResponse<Domain.Models.MainEntities.BranchInfo>>
{
    private readonly IBranchesInfoService _branchesInfoService;

    public CreateBranchInfoHandler(IBranchesInfoService branchesInfoService)
    {
        _branchesInfoService = branchesInfoService;
    }

    public async Task<OperationResponse<Domain.Models.MainEntities.BranchInfo>> Handle(CreateBranchInfoCommand request,
        CancellationToken cancellationToken)
    {
        var isValidBranchType = await _branchesInfoService.IsValidBranchType(request.BranchTypeId);
        var isValidCompanyInfo = await _branchesInfoService.IsValidCompanyInfo(request.CompanyInfoId);

        if (!isValidBranchType) return new HttpMessage("Invalid Branch Type ID", HttpStatusCode.BadRequest400);
        if (!isValidCompanyInfo)
        {
            return new HttpMessage("Invalid Company Info ID", HttpStatusCode.BadRequest400);
        }

        var result = await _branchesInfoService.CreateBranchInfo(request);
        return result;
    }
}