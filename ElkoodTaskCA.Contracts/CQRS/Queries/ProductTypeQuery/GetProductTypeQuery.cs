using ElkoodTaskCA.Contracts.Models;
using MediatR;

namespace ElkoodTaskCA.Contracts.CQRS.Queries.ProductTypeQuery;

public class GetProductTypeQuery : IRequest<IEnumerable<ProductType>>
{
}