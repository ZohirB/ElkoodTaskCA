using Elkood.Application.OperationResponses;
using Elkood.Domain.Exceptions;
using Elkood.Domain.Exceptions.Http;
using ElkoodTaskCA.Domain.Entities.General;
using ElkoodTaskCA.Domain.Repositories;
using MediatR;

namespace ElkoodTaskCA.Application.DistributionOperations.Commands.Create;

public class
    CreateDistributionOperationHandler : IRequestHandler<CreateDistributionOperationCommand.Request,
        OperationResponse<DistributionOperation>>
{
    private readonly IDistributionOperationService _distributionOperationService;

    public CreateDistributionOperationHandler(IDistributionOperationService distributionOperationService)
    {
        _distributionOperationService = distributionOperationService;
    }

    public async Task<OperationResponse<DistributionOperation>> Handle(CreateDistributionOperationCommand.Request request,
        CancellationToken cancellationToken)
    {
        var totalRemainingQuantity = await _distributionOperationService.TotalRemainingQuantity(request.PrimaryBranchInfoId,request.ProductInfoId);
        if (totalRemainingQuantity < request.quantity)
            return new HttpMessage("Not enough remaining product quantity ;-)", HttpStatusCode.BadRequest400);

        var isValidPrimaryBranchType = await _distributionOperationService.IsValidPrimaryBranchTypeTask(request.PrimaryBranchInfoId);
        if (!isValidPrimaryBranchType)
            return new HttpMessage("Invalid Branch Type ID... you can only USE ID:2 (Secondary) for Distrubution",
                HttpStatusCode.BadRequest400);

        var isValidSecondaryBranchType = await _distributionOperationService.IsValidSecondaryBranchType(request.SecondaryBranchInfoId);
        if (!isValidSecondaryBranchType)
            return new HttpMessage("Invalid Branch Type ID... you can only USE ID:2 (Secondary) for Distrubution",
                HttpStatusCode.BadRequest400);

        
        var distribution = new DistributionOperation
        {
            PrimaryBranchInfoId = request.PrimaryBranchInfoId,
            SecondaryBranchInfoId = request.SecondaryBranchInfoId,
            ProductInfoId = request.ProductInfoId,
            Quantity = request.quantity,
            Date = request.date
        };
        
        _distributionOperationService.CreateDistributionOperation(distribution, request.quantity);
        var distributionOperation = new DistributionOperation
        {
            Quantity = request.quantity,
            Date = request.date
        };
        return distributionOperation;
        //return "The products have been transfer from Production to Distrubution";
    }
}