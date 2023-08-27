using MediatR;

namespace ElkoodTaskCA.API.CQRS.Queries.ProductionOprationQuery;

public class GetAllProductionOprationQuery : IRequest<List<ProductionDetailsDto>>
{
}