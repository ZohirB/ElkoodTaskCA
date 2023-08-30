using ElkoodTaskCA.Domain.Entities.General;
using MediatR;

namespace ElkoodTaskCA.Application.ProductTypes.Queries.GetAll;

public class GetProductTypeQuery : IRequest<IEnumerable<ProductType>>
{
}