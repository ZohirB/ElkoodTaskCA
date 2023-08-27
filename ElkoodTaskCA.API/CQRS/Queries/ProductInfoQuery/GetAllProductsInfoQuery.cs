using MediatR;

namespace ElkoodTaskCA.API.CQRS.Queries.ProductInfoQuery;

public class GetAllProductsInfoQuery : IRequest<List<ProductDetailsDto>>
{
}