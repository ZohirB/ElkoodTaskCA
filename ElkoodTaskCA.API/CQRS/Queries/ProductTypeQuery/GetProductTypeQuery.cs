using MediatR;

namespace ElkoodTaskCA.API.CQRS.Queries.ProductTypeQuery;

public class GetProductTypeQuery : IRequest<IEnumerable<ProductType>>
{
}