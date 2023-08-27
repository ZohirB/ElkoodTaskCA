using Elkood.Application.OperationResponses;
using Elkood.Domain.Exceptions;
using Elkood.Domain.Exceptions.Http;
using ElkoodTaskCA.API.CQRS.Command.DistributionOperationCommand;
using ElkoodTaskCA.API.Repositories.DistributionOperationRepository;
using MediatR;

namespace ElkoodTaskCA.API.CQRS.Handlers.DistributionOperationsHandler;

public class
    CreateDistributionOperationHandler : IRequestHandler<CreateDistributionOperationCommand,
        OperationResponse<DistributionOperation>>
{
    private readonly IDistributionOperationService _distributionOperationService;

    public CreateDistributionOperationHandler(IDistributionOperationService distributionOperationService)
    {
        _distributionOperationService = distributionOperationService;
    }

    public async Task<OperationResponse<DistributionOperation>> Handle(CreateDistributionOperationCommand request,
        CancellationToken cancellationToken)
    {
        var totalRemainingQuantity = await _distributionOperationService.TotalRemainingQuantity(request);
        if (totalRemainingQuantity < request.quantity)
            return new HttpMessage("Not enough remaining product quantity ;-)", HttpStatusCode.BadRequest400);

        var isValidPrimaryBranchType = await _distributionOperationService.IsValidPrimaryBranchTypeTask(request);
        if (!isValidPrimaryBranchType)
            return new HttpMessage("Invalid Branch Type ID... you can only USE ID:2 (Secondary) for Distrubution",
                HttpStatusCode.BadRequest400);

        var isValidSecondaryBranchType = await _distributionOperationService.IsValidSecondaryBranchType(request);
        if (!isValidSecondaryBranchType)
            return new HttpMessage("Invalid Branch Type ID... you can only USE ID:2 (Secondary) for Distrubution",
                HttpStatusCode.BadRequest400);

        // TODO check for bug
        _distributionOperationService.CreateDistributionOperation(request);
        var distributionOperation = new DistributionOperation
        {
            Quantity = request.quantity,
            Date = request.date
        };
        return distributionOperation;
        //return "The products have been transfer from Production to Distrubution";
    }
}