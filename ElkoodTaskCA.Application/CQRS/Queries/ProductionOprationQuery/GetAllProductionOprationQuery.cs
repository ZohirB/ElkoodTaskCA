using ElkoodTaskCA.Application.Dtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Queries.ProductionOprationQuery;

public class GetAllProductionOprationQuery : IRequest<List<ProductionDetailsDto>>
{
}