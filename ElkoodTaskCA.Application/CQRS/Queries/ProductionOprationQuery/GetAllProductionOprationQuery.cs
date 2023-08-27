using ElkoodTaskCA.Domain.Dtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Queries.ProductionOprationQuery;

public class GetAllProductionOprationQuery : IRequest<List<ProductionDetailsDto>>
{
}