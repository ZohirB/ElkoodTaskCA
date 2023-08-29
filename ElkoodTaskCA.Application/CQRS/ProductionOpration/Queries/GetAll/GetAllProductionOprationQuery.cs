using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductionOpration.Queries.GetAll;

public class GetAllProductionOprationQuery : IRequest<List<ProductionDetailsDto>>
{
}