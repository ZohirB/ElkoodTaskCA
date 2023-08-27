using Elkood.Application.OperationResponses;
using Elkood.Domain.Exceptions;
using Elkood.Domain.Exceptions.Http;
using ElkoodTaskCA.Contracts.CQRS.Command.BranchInfoCommand;
using ElkoodTaskCA.Contracts.Models;
using ElkoodTaskCA.Contracts.Repositories.BranchInfoRepository;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Handlers.BranchInfoHandler;

public class CreateBranchInfoHandler : IRequestHandler<CreateBranchInfoCommand, OperationResponse<BranchInfo>>
{
    private readonly IBranchesInfoService _branchesInfoService;

    public CreateBranchInfoHandler(IBranchesInfoService branchesInfoService)
    {
        _branchesInfoService = branchesInfoService;
    }

    public async Task<OperationResponse<BranchInfo>> Handle(CreateBranchInfoCommand request,
        CancellationToken cancellationToken)
    {
        var isValidBranchType = await _branchesInfoService.IsValidBranchType(request.BranchTypeId);
        var isValidCompanyInfo = await _branchesInfoService.IsValidCompanyInfo(request.CompanyInfoId);

        if (!isValidBranchType) return new HttpMessage("Invalid Branch Type ID", HttpStatusCode.BadRequest400);
        if (!isValidCompanyInfo) return new HttpMessage("Invalid Company Info ID", HttpStatusCode.BadRequest400);

        var result = await _branchesInfoService.CreateBranchInfo(request);
        return result;
    }
}