using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Contracts.Models;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Command.DistributionOperationCommand;

public class CreateDistributionOperationCommand : IRequest<OperationResponse<DistributionOperation>>
{
    public int PrimaryBranchInfoId { get; set; }
    public int SecondaryBranchInfoId { get; set; }
    public int ProductInfoId { get; set; }
    public int quantity { get; set; }
    public DateTime date { get; set; }
}