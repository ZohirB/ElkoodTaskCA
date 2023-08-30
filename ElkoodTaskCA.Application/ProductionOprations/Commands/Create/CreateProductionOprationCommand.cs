using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Domain.Entities.General;
using MediatR;

namespace ElkoodTaskCA.Application.ProductionOprations.Commands.Create;

public class CreateProductionOprationCommand 
{
    public class Request : IRequest<OperationResponse<ProductionOperation>>
    {
        public int BranchInfoId { get; set; }
        public int ProductInfoId { get; set; }
        public int quantity { get; set; }
        public DateTime date { get; set; }
    }

}