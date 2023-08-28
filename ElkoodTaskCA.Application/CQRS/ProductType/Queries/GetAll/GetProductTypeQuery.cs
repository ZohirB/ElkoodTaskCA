using MediatR;

namespace ElkoodTaskCA.Application.CQRS.ProductType.Queries.GetAll;

public class GetProductTypeQuery : IRequest<IEnumerable<Domain.Models.ProductType>>
{
}