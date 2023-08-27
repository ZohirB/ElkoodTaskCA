using Elkood.Application.OperationResponses;
using ElkoodTaskCA.Contracts.Dtos;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Queries.ProductProducedQuery;

public class GetAllProductProducedQuery : IRequest<OperationResponse<List<ProductProducedDetailsDto>>>
{
    public string CompanyName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}