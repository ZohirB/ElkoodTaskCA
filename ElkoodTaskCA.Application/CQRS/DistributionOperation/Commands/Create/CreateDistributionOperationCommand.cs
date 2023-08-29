using Elkood.Application.OperationResponses;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.DistributionOperation.Commands.Create;

public class CreateDistributionOperationCommand : IRequest<OperationResponse<Domain.Models.MainEntities.DistributionOperation>>
{
    public int PrimaryBranchInfoId { get; set; }
    public int SecondaryBranchInfoId { get; set; }
    public int ProductInfoId { get; set; }
    public int quantity { get; set; }
    public DateTime date { get; set; }
}