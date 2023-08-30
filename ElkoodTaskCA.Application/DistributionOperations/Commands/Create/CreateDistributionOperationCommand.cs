using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Domain.Entities.General;
using MediatR;

namespace ElkoodTaskCA.Application.DistributionOperations.Commands.Create;

public class CreateDistributionOperationCommand 
{
    public class Request : IRequest<OperationResponse<DistributionOperation>>
    {
        public int PrimaryBranchInfoId { get; set; }
        public int SecondaryBranchInfoId { get; set; }
        public int ProductInfoId { get; set; }
        public int quantity { get; set; }
        public DateTime date { get; set; }
    }
}