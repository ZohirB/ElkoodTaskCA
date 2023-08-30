using Elkood.Application.OperationResponses;
using Elkood.Domain.Exceptions;
using Elkood.Domain.Exceptions.Http;
using ElkoodTaskCA.Domain.Entities.General;
using ElkoodTaskCA.Domain.Repositories;
using MediatR;

namespace ElkoodTaskCA.Application.BranchInfos.Commands.Create;

public class CreateBranchInfoHandler : IRequestHandler<CreateBranchInfoCommand.Request, OperationResponse<BranchInfo>>
{
    private readonly IBranchesInfoService _branchesInfoService;

    public CreateBranchInfoHandler(IBranchesInfoService branchesInfoService)
    {
        _branchesInfoService = branchesInfoService;
    }

    public async Task<OperationResponse<BranchInfo>> Handle(CreateBranchInfoCommand.Request request,
        CancellationToken cancellationToken)
    {
        var isValidBranchType = await _branchesInfoService.IsValidBranchType(request.BranchTypeId);
        var isValidCompanyInfo = await _branchesInfoService.IsValidCompanyInfo(request.CompanyInfoId);

        if (!isValidBranchType) return new HttpMessage("Invalid Branch Type ID", HttpStatusCode.BadRequest400);
        if (!isValidCompanyInfo)
        {
            return new HttpMessage("Invalid Company Info ID", HttpStatusCode.BadRequest400);
        }
        
        var branchInfo = new BranchInfo
        {
            Name = request.Name,
            BranchTypeId = request.BranchTypeId,
            CompanyInfoId = request.CompanyInfoId,
            Location = request.Location
        };
        
        var result = await _branchesInfoService.CreateBranchInfo(branchInfo);
        return result;
    }
}