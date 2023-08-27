using ElkoodTaskCA.Contracts.Dtos;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Queries.ProductionOprationQuery;

public class GetAllProductionOprationQuery : IRequest<List<ProductionDetailsDto>>
{
}