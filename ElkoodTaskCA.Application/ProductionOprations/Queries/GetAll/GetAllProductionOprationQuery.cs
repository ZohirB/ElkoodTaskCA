using ElkoodTaskCA.Contracts.Dtos.MainDtos;
using MediatR;

namespace ElkoodTaskCA.Application.ProductionOprations.Queries.GetAll;

public class GetAllProductionOprationQuery : IRequest<List<ProductionDetailsDto>>
{
}