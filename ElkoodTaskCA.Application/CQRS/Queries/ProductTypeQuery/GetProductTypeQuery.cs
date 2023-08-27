using ElkoodTaskCA.Application.Models;
using MediatR;

namespace ElkoodTaskCA.Application.CQRS.Queries.ProductTypeQuery;

public class GetProductTypeQuery : IRequest<IEnumerable<ProductType>>
{
}